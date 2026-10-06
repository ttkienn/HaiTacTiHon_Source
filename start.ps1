$ErrorActionPreference = 'Stop'
Set-Location $PSScriptRoot

$mysqlBin = 'C:\xampp\mysql\bin'
$mysql = Join-Path $mysqlBin 'mysql.exe'
$mysqld = Join-Path $mysqlBin 'mysqld.exe'
$installDb = Join-Path $mysqlBin 'mysql_install_db.exe'
if (!(Test-Path $mysql) -or !(Test-Path $mysqld)) {
    throw 'MariaDB was not found at C:\xampp\mysql\bin.'
}
if (!(Test-Path 'backend-src\build\htth-server.jar') -and !(Test-Path 'backend-src\build\htth-server.next.jar') -or !(Test-Path 'data\map') -or !(Test-Path 'database\htth_full.sql')) {
    throw 'Missing source-built backend, data, or database. Run backend-src\build.ps1 first.'
}

function Test-Port([int]$Port) {
    $client = [Net.Sockets.TcpClient]::new()
    try { $client.Connect('127.0.0.1', $Port); return $true }
    catch { return $false }
    finally { $client.Dispose() }
}

New-Item -ItemType Directory -Force -Path 'logs' | Out-Null
$dbPath = Join-Path $PSScriptRoot 'db'
if (!(Test-Path (Join-Path $dbPath 'mysql'))) {
    New-Item -ItemType Directory -Force -Path $dbPath | Out-Null
    & $installDb --datadir=$dbPath --password='' --port=3306 --silent
    if ($LASTEXITCODE -ne 0) { throw 'Could not initialize the private MariaDB data directory.' }
}
if (Test-Port 3306) {
    if (!(Test-Path '.mysql.pid')) { throw 'Port 3306 is occupied. Stop the other MySQL instance first.' }
} else {
    $dbArgs = @('--defaults-file=my.ini','--bind-address=127.0.0.1','--skip-name-resolve')
    $db = Start-Process -FilePath $mysqld -ArgumentList $dbArgs -WorkingDirectory $dbPath -WindowStyle Hidden -PassThru
    Set-Content -LiteralPath '.mysql.pid' -Value $db.Id
    for ($i = 0; $i -lt 30 -and !(Test-Port 3306); $i++) { Start-Sleep -Milliseconds 500 }
    if (!(Test-Port 3306)) { throw 'MariaDB failed to start.' }
}

$tableCount = & $mysql --batch --skip-column-names -uroot -e "SELECT COUNT(*) FROM information_schema.tables WHERE table_schema='htth';" 2>$null
if (!$tableCount -or [int]$tableCount -lt 10) {
    $sqlPath = (Resolve-Path 'database\htth_full.sql').Path
    $command = '"{0}" -uroot --default-character-set=utf8mb4 < "{1}"' -f $mysql, $sqlPath
    cmd.exe /d /c $command
    if ($LASTEXITCODE -ne 0) { throw 'Database import failed.' }
}

if (Test-Port 2228) {
    Write-Host 'Server is already running at 127.0.0.1:2228'
    if (Test-Path 'backend-src\build\htth-server.next.jar') { Write-Host 'A new build is pending; run stop.ps1, then start.ps1 to activate it.' }
    exit 0
}
if (Test-Path 'backend-src\build\htth-server.next.jar') {
    Move-Item 'backend-src\build\htth-server.next.jar' 'backend-src\build\htth-server.jar' -Force
}
$server = Start-Process -FilePath 'java.exe' -ArgumentList '-cp','backend-src\build\htth-server.jar','core.Start' -WorkingDirectory $PSScriptRoot -RedirectStandardOutput 'logs\server.log' -RedirectStandardError 'logs\server-error.log' -WindowStyle Hidden -PassThru
Set-Content -LiteralPath '.server.pid' -Value $server.Id
for ($i = 0; $i -lt 120 -and !(Test-Port 2228); $i++) { Start-Sleep -Milliseconds 500 }
if (!(Test-Port 2228)) {
    Get-Content 'logs\server-error.log' -ErrorAction SilentlyContinue
    throw 'Game server did not open port 2228.'
}
Write-Host 'HTTH server is ready at 127.0.0.1:2228'
Write-Host 'Test account: eragirl / 123456'

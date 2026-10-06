$ErrorActionPreference = 'Stop'
Set-Location $PSScriptRoot

$classes = 'backend-src\build\classes\core\AdminPanel.class'
if (!(Test-Path -LiteralPath $classes)) {
    throw 'Admin panel is not built. Run backend-src\build.ps1 first.'
}
$classpath = 'backend-src\build\classes;backend-src\lib\dependencies.jar'
& java.exe -cp $classpath core.AdminPanel --check
if ($LASTEXITCODE -ne 0) { throw 'Cannot connect to the private MariaDB. Start the server with start.ps1 first.' }

Write-Host 'HTTH Admin Panel opened.'
Start-Process -FilePath 'javaw.exe' -ArgumentList '-cp', $classpath, 'core.AdminPanel' -WorkingDirectory $PSScriptRoot -WindowStyle Normal -Wait

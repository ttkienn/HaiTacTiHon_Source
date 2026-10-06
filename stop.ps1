$ErrorActionPreference = 'Stop'
Set-Location $PSScriptRoot
foreach ($name in '.server.pid','.mysql.pid') {
    if (!(Test-Path $name)) { continue }
    $processId = [int](Get-Content $name -Raw).Trim()
    $process = Get-Process -Id $processId -ErrorAction SilentlyContinue
    if ($process) { Stop-Process -Id $processId -Force }
    Remove-Item -LiteralPath $name -Force
}
Write-Host 'Stopped the game server and its private MariaDB process.'

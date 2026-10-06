$ErrorActionPreference = 'Stop'
$base = 'http://127.0.0.1:2237'
$key = (Get-Content -LiteralPath (Join-Path $PSScriptRoot 'admin.key') -Raw).Trim()
$session = New-Object Microsoft.PowerShell.Commands.WebRequestSession

$public = Invoke-WebRequest "$base/admin" -UseBasicParsing -WebSession $session
if ($public.StatusCode -ne 200 -or !$public.Content.Contains('/admin/login')) { throw 'Login page failed.' }
$localhost = Invoke-WebRequest 'http://localhost:2237/admin' -UseBasicParsing
if ($localhost.StatusCode -ne 200 -or !$localhost.Content.Contains('/admin/login')) { throw 'Localhost login page failed.' }

$dashboard = Invoke-WebRequest "$base/admin/login" -Method Post -UseBasicParsing -WebSession $session -Headers @{ Origin = $base } -Body @{ key = $key }
if ($dashboard.StatusCode -ne 200 -or !$dashboard.Content.Contains('/admin/lock')) { throw 'Admin login failed.' }

try {
    Invoke-WebRequest "$base/admin/lock" -Method Post -UseBasicParsing -WebSession $session -Headers @{ Origin = $base } -Body @{ username = 'eragirl'; value = '1'; csrf = 'invalid' } | Out-Null
    throw 'CSRF protection failed.'
} catch [System.Net.WebException] {
    if ([int]$_.Exception.Response.StatusCode -ne 403) { throw }
}

Write-Host 'Admin web smoke test passed.'

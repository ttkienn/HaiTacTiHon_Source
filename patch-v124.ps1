$ErrorActionPreference = 'Stop'
$dll = Join-Path $PSScriptRoot 'client-v124\HaiTacTiHon_VN_v124 (big)_Data\Managed\Assembly-CSharp.dll'
$backup = "$dll.original.bak"
if (!(Test-Path -LiteralPath $backup)) { Copy-Item -LiteralPath $dll -Destination $backup }
$bytes = [IO.File]::ReadAllBytes($backup)

foreach ($pair in @(
    @('210.211.109.119', '127.000.000.001'),
    @('54.255.184.239', '127.00.000.001')
)) {
    $old = [Text.Encoding]::Unicode.GetBytes($pair[0])
    $new = [Text.Encoding]::Unicode.GetBytes($pair[1])
    if ($old.Length -ne $new.Length) { throw 'Replacement must have the same byte length.' }
    $count = 0
    for ($i = 0; $i -le $bytes.Length - $old.Length; $i++) {
        $match = $true
        for ($j = 0; $j -lt $old.Length; $j++) {
            if ($bytes[$i + $j] -ne $old[$j]) { $match = $false; break }
        }
        if ($match) {
            [Array]::Copy($new, 0, $bytes, $i, $new.Length)
            $count++
            $i += $old.Length - 1
        }
    }
    if ($count -eq 0) { throw "Address not found: $($pair[0])" }
    Write-Host "Patched $($pair[0]): $count occurrence(s)"
}

[IO.File]::WriteAllBytes($dll, $bytes)
Write-Host "Client v124 now points at local server on its built-in port 2228. Original DLL: $backup"

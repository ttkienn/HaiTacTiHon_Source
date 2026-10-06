param([ValidateRange(1, 4)][int]$Zoom = 1)
$ErrorActionPreference = 'Stop'

function Read-Exact($Stream, [int]$Length) {
    $bytes = [byte[]]::new($Length)
    $read = 0
    while ($read -lt $Length) {
        $count = $Stream.Read($bytes, $read, $Length - $read)
        if ($count -eq 0) { throw 'Resource server closed the connection.' }
        $read += $count
    }
    return $bytes
}

$client = [Net.Sockets.TcpClient]::new()
try {
    $client.ReceiveTimeout = 30000
    $client.Connect('210.211.109.119', 2229)
    $stream = $client.GetStream()
    $stream.Write([byte[]](0xE5, 0, 0), 0, 3)
    $header = Read-Exact $stream 3
    $length = ($header[1] -shl 8) -bor $header[2]
    $payload = Read-Exact $stream $length
    if ($header[0] -ne 0xE5 -or $payload[0] -ne $length - 1) { throw 'Invalid resource-server handshake.' }

    $key = [byte[]]::new($payload[0])
    $key[0] = $payload[1]
    for ($i = 1; $i -lt $key.Length; $i++) { $key[$i] = $payload[$i + 1] -bxor $key[$i - 1] }
    $writeIndex = 0
    $request = [byte[]]::new(4)
    foreach ($value in @(0xDA, 0, 1, $Zoom)) {
        $request[$writeIndex] = $value -bxor $key[$writeIndex % $key.Length]
        $writeIndex++
    }
    $stream.Write($request, 0, $request.Length)

    $target = Join-Path $PSScriptRoot "data\datafromsver\x$Zoom"
    New-Item -ItemType Directory -Path $target -Force | Out-Null
    $readIndex = 0
    $sequence = 0
    try {
        while ($true) {
            $wireCommand = (Read-Exact $stream 1)[0]
            $commandByte = $wireCommand -bxor $key[$readIndex++ % $key.Length]
            $command = if ($commandByte -ge 128) { $commandByte - 256 } else { $commandByte }
            $sizeBytes = Read-Exact $stream $(if ($command -eq -39) { 4 } else { 2 })
            $size = 0
            foreach ($wireByte in $sizeBytes) {
                $size = ($size -shl 8) -bor ($wireByte -bxor $key[$readIndex++ % $key.Length])
            }
            $data = Read-Exact $stream $size
            for ($i = 0; $i -lt $data.Length; $i++) { $data[$i] = $data[$i] -bxor $key[$readIndex++ % $key.Length] }
            $name = '{0:D4}_{1}' -f $sequence++, $command
            [IO.File]::WriteAllBytes((Join-Path $target $name), $data)
            Write-Host "$name ($size bytes)"
            if ($command -eq -40) { break }
        }
    } catch {
        if ($sequence -eq 0) { throw }
        Write-Warning "Resource server closed after $sequence packets; the local backend will append completion."
    }
    Write-Host "Saved $sequence resource packets to $target"
} finally {
    $client.Dispose()
}

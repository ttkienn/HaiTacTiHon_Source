$ErrorActionPreference = 'Stop'

$client = [Net.Sockets.TcpClient]::new()
try {
    $client.ReceiveTimeout = 3000
    $client.Connect('127.0.0.1', 2228)
    $stream = $client.GetStream()
    $stream.Write([byte[]](0xE5, 0, 0), 0, 3)
    $header = [byte[]]::new(3)
    $headerRead = 0
    while ($headerRead -lt 3) {
        $count = $stream.Read($header, $headerRead, 3 - $headerRead)
        if ($count -eq 0) { throw 'Connection closed during handshake header.' }
        $headerRead += $count
    }
    $length = ($header[1] -shl 8) -bor $header[2]
    $payload = [byte[]]::new($length)
    $read = 0
    while ($read -lt $length) {
        $count = $stream.Read($payload, $read, $length - $read)
        if ($count -eq 0) { throw 'Connection closed during handshake.' }
        $read += $count
    }
    if ($header[0] -ne 0xE5 -or $length -lt 2 -or $payload[0] -ne $length - 1) {
        throw 'Invalid HTTH handshake response.'
    }
    $key = [byte[]]::new($payload[0])
    $key[0] = $payload[1]
    for ($i = 1; $i -lt $key.Length; $i++) { $key[$i] = $payload[$i + 1] -bxor $key[$i - 1] }
    $request = [byte[]]((0xDA -bxor $key[0]), (0 -bxor $key[1]), (1 -bxor $key[2]), (1 -bxor $key[3]))
    $stream.Write($request, 0, $request.Length)
    $response = [byte[]]::new(3)
    $read = 0
    while ($read -lt $response.Length) {
        $count = $stream.Read($response, $read, $response.Length - $read)
        if ($count -eq 0) { throw 'Connection closed during resource check.' }
        $read += $count
    }
    $resourceCommand = $response[0] -bxor $key[0]
    $resourceLength = (($response[1] -bxor $key[1]) -shl 8) -bor ($response[2] -bxor $key[2])
    if ($resourceCommand -ne 0xD7 -and $resourceCommand -ne 0xD8) {
        throw 'Invalid resource response.'
    }
    Write-Host "OK: HTTH handshake and resource stream (first packet $resourceLength bytes), key length $($payload[0]), port 2228"
} finally {
    $client.Dispose()
}

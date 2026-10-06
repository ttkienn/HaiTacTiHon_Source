$ErrorActionPreference = 'Stop'

$gameRoot = Split-Path $PSScriptRoot -Parent
$assembly = Join-Path $gameRoot 'GameAssembly.dll'
$metadata = Join-Path $gameRoot 'Haitac_Data\il2cpp_data\Metadata\global-metadata.dat'

function Replace-Bytes([string]$Path, [byte[]]$Old, [byte[]]$New) {
    if ($Old.Length -ne $New.Length) { throw 'Replacement patterns must have equal lengths.' }
    $bytes = [IO.File]::ReadAllBytes($Path)
    $hits = [Collections.Generic.List[int]]::new()
    for ($i = 0; $i -le $bytes.Length - $Old.Length; $i++) {
        $same = $true
        for ($j = 0; $j -lt $Old.Length; $j++) {
            if ($bytes[$i + $j] -ne $Old[$j]) { $same = $false; break }
        }
        if ($same) { $hits.Add($i) }
    }
    if ($hits.Count -eq 0) {
        for ($i = 0; $i -le $bytes.Length - $New.Length; $i++) {
            $same = $true
            for ($j = 0; $j -lt $New.Length; $j++) {
                if ($bytes[$i + $j] -ne $New[$j]) { $same = $false; break }
            }
            if ($same) { return $false }
        }
        throw "Patch pattern was not found in $Path"
    }
    if ($hits.Count -ne 1) { throw "Found $($hits.Count) patch patterns in $Path; refusing an ambiguous patch." }
    [Array]::Copy($New, 0, $bytes, $hits[0], $New.Length)
    [IO.File]::WriteAllBytes($Path, $bytes)
    return $true
}

function Replace-BytesAt([string]$Path, [int]$Offset, [byte[]]$Old, [byte[]]$New) {
    if ($Old.Length -ne $New.Length) { throw 'Replacement patterns must have equal lengths.' }
    $bytes = [IO.File]::ReadAllBytes($Path)
    $current = [byte[]]::new($Old.Length)
    [Array]::Copy($bytes, $Offset, $current, 0, $current.Length)
    if ([Linq.Enumerable]::SequenceEqual($current, $New)) { return $false }
    if (![Linq.Enumerable]::SequenceEqual($current, $Old)) {
        throw "Unexpected bytes at offset 0x$($Offset.ToString('X')) in $Path"
    }
    [Array]::Copy($New, 0, $bytes, $Offset, $New.Length)
    [IO.File]::WriteAllBytes($Path, $bytes)
    return $true
}

$assemblyBackup = "$assembly.official.bak"
$metadataBackup = "$metadata.official.bak"
if (!(Test-Path $assemblyBackup)) { Copy-Item -LiteralPath $assembly -Destination $assemblyBackup }
if (!(Test-Path $metadataBackup)) { Copy-Item -LiteralPath $metadata -Destination $metadataBackup }

$utf8 = [Text.Encoding]::UTF8
$legacyIpChanged = Replace-BytesAt $metadata 144848 ($utf8.GetBytes('112.213.94.23')) ($utf8.GetBytes('127.000.0.001'))
$downloadIpChanged = Replace-BytesAt $metadata 145579 ($utf8.GetBytes('210.211.109.119')) ($utf8.GetBytes('127.000.000.001'))
$gameIpChanged = Replace-BytesAt $metadata 145751 ($utf8.GetBytes('54.255.184.239')) ($utf8.GetBytes('127.000.00.001'))
$urlChanged = Replace-BytesAt $metadata 448256 ($utf8.GetBytes('http://54.255.184.239/service/thongbao.txt')) ($utf8.GetBytes('http://127.0.0.1:2237/thongbao.txt?x=12345'))
$locationChanged = Replace-BytesAt $assembly 0x255160 ([byte[]](0x40,0x57,0x48,0x83,0xEC,0x60,0x80,0x3D)) ([byte[]](0x31,0xC0,0xC3,0x90,0x90,0x90,0x90,0x90))
$connectionChanged = Replace-BytesAt $assembly 0x6B4E6F ([byte[]](0x0F,0x84,0x27,0x01,0x00,0x00)) ([byte[]](0x0F,0x84,0x88,0x00,0x00,0x00))
$downloadPortChanged = Replace-BytesAt $assembly 0x6B492C ([byte[]](0xBB,0xB5,0x08,0x00,0x00)) ([byte[]](0xBB,0xB4,0x08,0x00,0x00))

Write-Host "Client: 127.0.0.1:2228"
Write-Host "Legacy IP changed: $legacyIpChanged; download IP changed: $downloadIpChanged; game IP changed: $gameIpChanged; URL changed: $urlChanged; location loop changed: $locationChanged; connection fallback changed: $connectionChanged; download port changed: $downloadPortChanged"
Write-Host "Backup: $assemblyBackup"
Write-Host "Backup: $metadataBackup"

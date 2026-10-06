$ErrorActionPreference = 'Stop'
$gameRoot = Split-Path $PSScriptRoot -Parent
$pairs = @(
    @((Join-Path $gameRoot 'GameAssembly.dll.official.bak'), (Join-Path $gameRoot 'GameAssembly.dll')),
    @((Join-Path $gameRoot 'Haitac_Data\il2cpp_data\Metadata\global-metadata.dat.official.bak'), (Join-Path $gameRoot 'Haitac_Data\il2cpp_data\Metadata\global-metadata.dat'))
)
foreach ($pair in $pairs) {
    if (!(Test-Path $pair[0])) { throw "Missing backup: $($pair[0])" }
    Copy-Item -LiteralPath $pair[0] -Destination $pair[1] -Force
}
Write-Host 'Restored the official client files.'

$ErrorActionPreference = 'Stop'
Set-Location $PSScriptRoot

$dependencyJar = 'lib\dependencies.jar'
$classes = 'build\classes'
$serverJar = 'build\htth-server.jar'
$nextJar = 'build\htth-server.next.jar'

if (!(Test-Path $dependencyJar)) { throw "Missing $dependencyJar" }

if (Test-Path $classes) {
    $resolved = (Resolve-Path $classes).Path
    if ($resolved -ne (Join-Path $PSScriptRoot $classes)) { throw "Unsafe build path: $resolved" }
    Remove-Item -LiteralPath $resolved -Recurse -Force
}
New-Item -ItemType Directory -Force $classes | Out-Null

$sources = Get-ChildItem 'src\main\java' -Recurse -Filter '*.java' | ForEach-Object FullName
if (!$sources) { throw 'No Java sources found.' }

javac -encoding UTF-8 -cp $dependencyJar -d $classes $sources
if ($LASTEXITCODE -ne 0) { throw 'Java compilation failed.' }

Copy-Item $dependencyJar $nextJar -Force
jar uf $nextJar -C $classes .
if ($LASTEXITCODE -ne 0) { throw 'JAR packaging failed.' }
if (!(jar tf $nextJar | Select-String -Quiet '^core/Start.class$')) { throw 'Built JAR is missing core.Start.' }

try {
    Move-Item $nextJar $serverJar -Force -ErrorAction Stop
    Write-Host "Built $serverJar from $($sources.Count) source files."
} catch {
    Write-Warning "Built $nextJar. The running server is using the current JAR; stop and start it to activate this build."
}

dotnet-gitversion /output file /outputfile .git/GitVersion.json
$gitversion =  Get-Content -Path .git/GitVersion.json -Encoding UTF8 | ConvertFrom-Json

foreach ($Property in $gitversion.PSObject.Properties) {
    Write-Output "$($Property.Name) = $($Property.Value)"
    Set-Variable -Name $Property.Name -Value $Property.Value -Scope Global -Visibility Public
}

# If it's tagged so that's the version
if ($BranchName.StartsWith("tags/")) {
    $InformationalVersion = $BranchName.Split("/")[1]
} else {
    $AssemblySemVer = $AssemblySemFileVer = "$($MajorMinorPatch).$($CommitsSinceVersionSourcePadded)"
    $InformationalVersion = "$($MajorMinorPatch)-$($EscapedBranchName).build-$($CommitsSinceVersionSource).Sha.$($ShortSha)"
}

Write-Output "AssemblySemVer: $($AssemblySemVer)"
Write-Output "AssemblySemFileVer: $($AssemblySemFileVer)"
Write-Output "InformationalVersion: $($InformationalVersion)"

$csprojs = Get-ChildItem -Path .\*.csproj -Recurse -Force

foreach ($csproj in $csprojs) {

    $csprojText = Get-Content -Path $csproj.fullName -Encoding UTF8
    $csprojText = $csprojText -creplace '(?s)<AssemblyVersion>.*?</AssemblyVersion>', "<AssemblyVersion>$($AssemblySemVer)</AssemblyVersion>"
    $csprojText = $csprojText -creplace '(?s)<FileVersion>.*?</FileVersion>', "<FileVersion>$($AssemblySemFileVer)</FileVersion>"
    $csprojText = $csprojText -creplace '(?s)<Version>.*?</Version>', "<Version>$($InformationalVersion)</Version>"
    Set-Content -Path $csproj.fullName -Value $csprojText -Encoding UTF8
    Write-Output "Patching project versions '$($csproj.fullName)'"
}

# On Azure Pipelines update build number
if ($Env:AGENT_NAME -ne "") {
    Write-Host "##vso[build.updatebuildnumber]$($InformationalVersion)"
}

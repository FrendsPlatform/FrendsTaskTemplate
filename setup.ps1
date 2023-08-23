$workflow = "../.github/workflows"
Get-ChildItem "./workflows" | ForEach-Object {
    Move-Item -Path $_.FullName -Destination $workflow + $_.Name
}

Remove-Item './workflows'
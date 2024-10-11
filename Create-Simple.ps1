param (
    [Parameter(Mandatory=$true)]
    [string]$ProjectName        
)

# Define repository directories
$axopenRepoDir = ".\axopen"
$axopenTemplatesRepoDir = ".\axopen.templates"

# Check if axopen repository is already cloned
if (-Not (Test-Path -Path $axopenRepoDir)) {
    git clone -b dev https://github.com/ix-ax/AXOpen.git axopen
    Write-Host "AXOpen repository cloned."

    # Build axopen if it was just cloned or already exists
    cd $axopenRepoDir
    .\build
    cd ..
} 
else {
    Write-Host "AXOpen repository already exists. Skipping cloning."
}

# Check if axopen.templates repository is already cloned
if (-Not (Test-Path -Path $axopenTemplatesRepoDir)) {
    git clone -b dev https://github.com/ix-ax/axopen.templates.git
    Write-Host "AXOpen templates repository cloned."
} else {
    Write-Host "AXOpen templates repository already exists. Skipping cloning."
}

# Copy the workspace_apax.yml file
Copy-Item -Path "$axopenTemplatesRepoDir\workspace_apax.yml" -Destination "apax.yml" -Force
Write-Host "workspace_apax.yml copied."

# Install dotnet template and create project
dotnet new install "$axopenTemplatesRepoDir\axopen.template.simple\" --force
dotnet new axosimple -n $ProjectName -o "$ProjectName/app/"
Write-Host "New AXOpen project created in '$ProjectName/app/'."

param (
    [Parameter(Mandatory=$true)]
    [string]$ProjectName        
)

git clone -b dev-2311 https://github.com/ix-ax/AXOpen.git axopen
git clone -b dev-2311 https://github.com/ix-ax/axopen.templates.git

Copy-Item -Path ".\axopen.templates\workspace_apax.yml" -Destination "apax.yml"

cd .\axopen 
.\build
cd ..

dotnet new install .\axopen.templates\axopen.template.simple\ --force
dotnet new axosimple -n $ProjectName -o $ProjectName/app/

Remove-Item -Path ".\axopen.templates" -Force -Recurse

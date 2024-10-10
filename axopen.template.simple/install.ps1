
function OpenSolutionWithVS2022 {
    param(
        [Parameter(Mandatory=$true)]
        [string]$solutionPath
    )

    # Validate if the solution path exists
    if (-not (Test-Path $solutionPath)) {
        Write-Error "The provided solution path does not exist: $solutionPath"
        return
    }

    # Define the possible paths for each edition of Visual Studio 2022
    $enterprisePath = "C:\Program Files\Microsoft Visual Studio\2022\Enterprise\Common7\IDE\devenv.exe"
    $professionalPath = "C:\Program Files\Microsoft Visual Studio\2022\Professional\Common7\IDE\devenv.exe"
    $communityPath = "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe"

    # Determine the most advanced edition installed
    $vsPath = $null
    if (Test-Path $enterprisePath) {
        $vsPath = $enterprisePath
    } elseif (Test-Path $professionalPath) {
        $vsPath = $professionalPath
    } elseif (Test-Path $communityPath) {
        $vsPath = $communityPath
    }

    # If we found an edition of VS2022, open the solution with it
    if ($vsPath) {
        & $vsPath $solutionPath
    } else {
        Write-Host "Visual Studio 2022 not found at '$vsPath'!"
    }
}

$currentPath = pwd
$startingPath = $currentPath.Path

dotnet tool restore
Set-Location ax
apax install
apax build
Set-Location ..\tools\AXOpen.Simple.Tools\AXOpen.Simple.Tools\.apax
apax install
Set-Location ..\..\..\..\

#Create an empty cert file

$filepath = ".\ax\certs\Communication.cer"
$placeholderDisclaimer = "This is a placeholder certificate file and must be replaced with a valid certificate before use."

# Check if the file exists
if (Test-Path $filepath) {
    # Read the content of the file (optional, if needed to confirm it contains the placeholder)
    $fileContent = Get-Content -Path $filepath
    
    # Check if the file contains the placeholder disclaimer (or just check existence)
    if ($fileContent -like $placeholderDisclaimer) {
        Write-Host "`nIMPORTANT: The file 'Communication.cer' is a placeholder certificate." -ForegroundColor Yellow
        Write-Host "You must replace this file with a valid certificate obtained from the TIA Portal." -ForegroundColor Yellow
        Write-Host "Please follow the instructions in the README.md file to replace it before deployment.`n" -ForegroundColor Yellow

        # Prompt the user for confirmation to continue
        $input = Read-Host "Press Enter once you've understood this message and replaced the certificate, or when you're ready to proceed"
        } else {
        Write-Host "The certificate file 'Communication.cer' has been updated." -ForegroundColor Green
    }
} else {
    Write-Host "Certificate file 'Communication.cer' not found." -ForegroundColor Red
    Write-Host "If you are using TIA portal for your hardware configuration, please ensure you have the correct file in the './axosimple/app/ax/certs/Communication.cer'" -ForegroundColor Red
    Write-Host "If you're using 'hwc' you can ignore this prompt the application is equiped with a script that will create and store the certificate for you." -ForegroundColor Red
    
    # Wait for user input before continuing
    $input = Read-Host "Press Enter to continue after verifying the certificate"

   if (-not (Test-Path $filepath)) {
        New-Item -Path $filepath -ItemType File
        Add-Content -Path $filepath -Value $placeholderDisclaimer
        Write-Host "No cert file found. I created one that you'll need to replace later".
        Write-Host "`nIMPORTANT: The file 'Communication.cer' is a placeholder certificate." -ForegroundColor Yellow
        Write-Host "You must replace this file with a valid certificate obtained from the TIA Portal." -ForegroundColor Yellow
        Write-Host "Please follow the instructions in the README.md file to replace it before deployment.`n" -ForegroundColor Yellow 
    }     
}

axcode .\ax\ 
axcode -g README.md:0

dotnet clean this.proj
dotnet build this.proj
dotnet slngen this.proj -o axosimple.sln --folders true --launch false
OpenSolutionWithVS2022 -solutionPath axosimple.sln








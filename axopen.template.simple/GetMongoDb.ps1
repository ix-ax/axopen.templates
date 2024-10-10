# Define the MongoDB download URL and paths
$mongoDBVersion = "8.0.0"  # Replace with the version you need
$downloadUrl = "https://fastdl.mongodb.org/windows/mongodb-windows-x86_64-$mongoDBVersion.zip"
$zipFilePath = "$env:TEMP\mongodb.zip"  # Path to save the zip file
$currentFolder = pwd
$extractFolder = "$currentFolder\.runtime\mongodbserver\"  # Folder where you want to extract the zip
$dataFolder = "$currentFolder\.runtime\data\db\"

# Function to download a file
function DownloadFile {
    param (
        [string]$url,
        [string]$outputPath
    )

    Write-Host "Downloading MongoDB from $url to $outputPath"
    Invoke-WebRequest -Uri $url -OutFile $outputPath
    Write-Host "Download complete."
}

# Function to unzip the file
function UnzipFile {
    param (
        [string]$zipFilePath,
        [string]$destinationFolder
    )

    Write-Host "Unzipping $zipFilePath to $destinationFolder"
    Expand-Archive -Path $zipFilePath -DestinationPath $destinationFolder -Force
    Write-Host "Extraction complete."
}

function Ensure-DirectoryExists {
    param (
        [string]$Path
    )

    if (-Not (Test-Path -Path $Path)) {
        Write-Host "Directory '$Path' does not exist. Creating it now..." -ForegroundColor Yellow
        New-Item -Path $Path -ItemType Directory | Out-Null
        Write-Host "Directory '$Path' created successfully." -ForegroundColor Green
    } else {
        Write-Host "Directory '$Path' already exists." -ForegroundColor Cyan
    }
}

# Step 1: Ensure data folder exists
Ensure-DirectoryExists($dataFolder)

# Step 2: Download MongoDB zip file
DownloadFile -url $downloadUrl -outputPath $zipFilePath

# Step 3: Create the target directory if it doesn't exist
if (-Not (Test-Path $extractFolder)) {
    Write-Host "Creating folder: $extractFolder"
    New-Item -Path $extractFolder -ItemType Directory
}

# Step 4: Unzip the MongoDB zip file into the target directory
UnzipFile -zipFilePath $zipFilePath -destinationFolder $extractFolder

# Step 5: Clean up the downloaded zip file (optional)
Write-Host "Cleaning up zip file."
Remove-Item -Path $zipFilePath -Force

Write-Host "MongoDB setup complete. MongoDB has been extracted to $extractFolder"


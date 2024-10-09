# Certificate Replacement Guide

## Overview

This project includes a **placeholder certificate** located at:

```
./ax/certs/Communication.cer
```

This certificate is **not valid** and is provided only for development and testing purposes. 
Before deploying the project, you **must replace** this placeholder certificate with a valid one obtained using the **TIA Portal**.


### 1. Replace the Placeholder Certificate

After obtaining the valid certificate from TIA Portal:

1. Navigate to the following directory in your project:

    ```
    ./ax/certs/
    ```

2. Replace the file named `Communication.cer` with the newly exported certificate.
   - **Ensure** the file name remains `Communication.cer`. If you change the file name, update any configurations or scripts referencing the certificate.
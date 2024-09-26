# Axosimple application template

This application template provides the starting point for application developers within [MTS](www.mts.sk/en). It covers the most common scenarios to help scaffold the application in a fast way.

**IMPORTANT!!! When you create the project from Visual Studio, you will need to run `install.ps1` manually to finish creating the project.**


## Preparing your target PLC 

### Using TIA portal

How to setup the communication in TIA portal

https://console.simatic-ax.siemens.io/docs/sld/example

You will need to export the certificates into `ax/certs/` folder of this directory named `Communication.cer` and `Webserver.cer`. For program loading and web server communication respectively. 

> IMPORTANT!
> This template points to these files with these exact names; please make sure you named the files as indicated.

your.project/
├──ax
│  └─ certs                          [Communication certificates]
│      ├── Communication.cer         [Program loading (sld)]
│      └── Webserver.cer             [WebAPI server application communication]


### Using `hwc`

You can alternatively use hwc to prepare your target system (see here)[https://console.simatic-ax.siemens.io/docs/hw/hwc].

For a quick configuration of a target system using `hwc` you can run the following:

```bash
apax alf
```


Prior running the script you should check/modify the following. Set the variable `HWCONFIG` to `HWC`. The `AX_USERNAME` and `AX_TARGET_PWD` will be used to configure WebAPI communication interface. Consider providing password in opaque way e.g. using environment variables.

```bash
  HWCONFIG: "HWC"
  AXTARGET: 192.168.0.4
  AXTARGETPLATFORMINPUT: .\bin\1500\
  AX_USERNAME: "adm"
  AX_TARGET_PWD: "123ABCDabcd$#!"
```

This script is preconfigured for **S71516 (6ES7 516-3AP03-0AB0) FW3.0**, if you whish to use another target system you will need to modify `ax\hwc\plc_line.hwl.json` file to use appropriate template for your target system.

ATTENTION! `apax alf` will attempt to download the hardware configuration in the target system.

## Template directory structure
```
your.project/
├── .config             [dotnet config]
├── .runtime            [contains kiosk client configuration]
├── .tests              [should contain tests of the application]
├── ax                  [SIMATIC-AX application]
│    ├ certs            [Communication certificates]  
│    ├ hwc              [Hardware configuration]  
│    ├ snippets         [Collection of snippets for this application template]  
│    ├ src              [Controller program sources]
│    ├ SystemConstants  [System constants for binding HW I/O to controller program]   
│    └ tests            [Unit test for this application]
├── axpansion/
│   ├── server          [Application server]
│   └── twin            [AX twin]
│ 
├── .gitignore    
│
├── README.md           [THIS README]
│
├── slngen.ps1          [Run to regenerate visual studio solution file]
├── axosimple.sln       [VS2022 solution file open to work with server, hmi, etc]
└── this.proj           [traversal project for this directory]
```

## Setting up the connection

### .NET


Go to [Entry.cs](axosimple.twin/Entry.cs) to configure the comunication between your controller and .net twin connector.


Define what method has been used to set up your controller. There are three options:

- `TIA` configured with TIA portal with full security (certificates and password)
- `TIA-NON-SECURE` configured with TIA portal without any security except for UserName and password for WebAPI access.
- `HWC` configured using `hwc` with fully featured security.

e.g.
```C#
#define TIA
```

~~~C#
private static string TargetIp = "192.168.0.4"; // <- replace by your IP 
private const string UserName = "Everybody"; //<- replace by user name you have set up in your WebAPI settings
private const string Pass = ""; // <- Pass in the password that you have set up for the user. NOT AS PLAIN TEXT! Use user secrets instead.
private const bool IgnoreSslErrors = true; // <- When you have your certificates in order set this to false.
~~~

### AX

#### Connection parameters


## Download the project to the PLC

Navigate to your ax folder and run the script command:

~~~
PS [your_root_folder]\>apax push
~~~

## To quickly run the hmi

~~~
PS [your_root_folder]\>dotnet run --project ..\axosimple.app\axosimple.server.csproj
~~~

~~~
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5262
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
.
.      
~~~

**To terminate the application press `ctrl+c`**

Navigate to the address indicated in "Now listening on:".

> NOTE!
> Your browser may redirect to https. In that case, temporarily disable the redirection. 
> (Opening the page in incognito mode should not redirect.)

## Modifying your HMI project

In Visual Studio (VS2022), open the solution file from the project folder `axosimple.sln`. You can then run the solution directly from Visual Studio.

> **NOTE: Security is set to a minimal level for a speedy start. Make sure you set the security appropriately**.

## Other useful scripts

Build both AX and AX# part of the project and DOWNLOADS the program to the target controller
```
apax push
```

Downloads current build into the controller.
```
apax download
```

Build the both SIMATIC-AX and AXOpen projects.
```
apax build
```

Running ixc
```
dotnet ixc
```


## Resources

Documentation sources: 
- `docs` in this folder
- [AXOpen]https://ix-ax.github.io/AXOpen/
- [AX#]https://ix-ax.github.io/axsharp/

# How to add controlled unit

## Run `create-unit` script

```bash
apax create-unit MyUnit
```
or

```bash
apax create-unit

```
**When running the script interactively or when unit name is non compliant, you might see something like this:**

```bash
> apax create-unit

Enter the unit name (mandatory):
ATTENTION: The name must start with an upper-case letter, no spaces, and no special characters.
```

This script will do the following:

- Installs a .NET template located in the ./src/templates/unit/ directory using the 
- Generates a new unit using the placing it in the `./src/Units/$unitname` folder.
- Moves specific twin-related files from the generated unit to the `../axpansion/twin/Context/Units/` directory.
- Moves server-related files to the `../axpansion/server/Pages/Context/Units/ directory`.
- The script will also modify your source code adding necessary variables and calls. 


## Adding controlled unit manually

**The following assumes you have the controlled unit created from the template and the files were copied to the server and twin manually**

### Controller program


#### Create a new instance of new controlled unit in 


Navigate to [`src\Context.st`](src\Context.st#7) `VAR PUBLIC` section and add new instance of newly create controlled unit.

```iecst
 VAR PUBLIC          
    Glob : GlobalContextObjects;           
    Inputs : REF_TO axosimple.Inputs;
    Outputs : REF_TO axosimple.Outputs; 
    Safety : TechnologySafety;

    // Units

    {#ix-set:AttributeName = "<#MY UNIT#>"} 
    MyUnit : MyUnit.UnitContainer;
END_VAR      
```

You can use `unitDeclaration` snippet.


#### Add data of the unit to Process data.

Navigate to [`src\Glob\ProcessData.st`](src\Glob\ProcessData.st) `VAR PUBLIC` section and add new instance of process data of newly create controlled unit.


```iecst
NAMESPACE axosimple
    {S7.extern=ReadWrite}
    CLASS ProcessData EXTENDS AXOpen.Data.AxoDataFragmentExchange
        VAR PUBLIC                    
            {#ix-attr:[AXOpen.Data.AxoDataFragmentAttribute]}
            Entity : SharedDataExchange;   
                                                           
            {#ix-set:AttributeName = "<#MY UNIT#>"} 
            MyUnit : MyUnit.ProcessDataExchange;
        END_VAR        
    END_CLASS
END_NAMESPACE   
```
You can use `unitAddProcessData` snippet.


#### Add data of the unit to technological data.

Navigate to [`src\Glob\TechnologyData.st`](src\Glob\TechnologyData.st) `VAR PUBLIC` section and add new instance of process data of newly create controlled unit.


```iecst
NAMESPACE axosimple
    {S7.extern=ReadWrite}
    CLASS TechnologyData EXTENDS AXOpen.Data.AxoDataFragmentExchange
        VAR PUBLIC                    
            {#ix-attr:[AXOpen.Data.AxoDataFragmentAttribute]}
            Common : TechnologySharedDataExchange;   
            
            {#ix-set:AttributeName = "<#MY UNIT#>"} 
            MyUnit : MyUnit.TechnologyDataExchange;
        END_VAR        
    END_CLASS
END_NAMESPACE 
```
You can use `unitAddTechnologyData` snippet.


#### Add entry call of the newly added controlled unit


Navigate to [`src\Context.st`](src\Context.st) `Main` method and add entry call for the newly created controlled unit.


```iecst
METHOD PROTECTED OVERRIDE Main    
    Safety.Run(THIS);                    
    Glob.Run(THIS)
    
    IF(Inputs = NULL || Outputs = NULL) THEN
        RETURN;
    END_IF;      
                                                    
    MyUnit.Run(THIS, Inputs^, Outputs^, REF(Glob));                                       
END_METHOD            
```

#### Build and Download

```iecst
apax push
```

### Server

Navigate to [`..\axpansion\server\Program.cs`](..\axpansion\server\Program.cs) add services initialization for newly created controlled unit to `CreateUnitServices` method and add appropriate call.

```C#
static void CreateUnitServices()
{   
    axosimple.MyUnit.UnitServices.Create(ContextService.Instance); 
    .
    .
    .
    .
}
```

Important! Call must be placed after Twin connector is initialzed and running and AxoApplication has been initialized. It should be places in `


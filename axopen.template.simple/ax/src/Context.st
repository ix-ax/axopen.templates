USING AXOpen.Core;
USING AXOpen.Data;

NAMESPACE axosimple
    {S7.extern=ReadWrite}
    CLASS PUBLIC Context EXTENDS AXOpen.Core.AxoContext                   
        VAR PUBLIC          
            Glob : GlobalContextObjects;
            
            Inputs : REF_TO axosimple.Inputs;
            Outputs : REF_TO axosimple.Outputs; 

            Safety : TechnologySafety;

            // Units - You can use snippet unitDeclaration 

            UnitTemplate : axosimple.UnitTemplate.Unit;
                                                               
        END_VAR      
        
        METHOD PROTECTED OVERRIDE Main    
            Safety.Run(THIS);        
            
            Glob.TS.Run(THIS);
            Glob.PS.Run(THIS);
            Glob.PD.Run(THIS);
            Glob.Persits.Run(THIS);
            
            // initialize global object references
                                    
            // remember last selected identifier 
            if Glob.TS.Common.Payload.DataEntityId <> '' THEN
                IF Glob.LastTechnologySettings <> Glob.TS.Common.Payload.DataEntityId THEN 
                    IF Glob.Persits.InvokeUpdate(Glob.TS, '') THEN 
                        Glob.LastTechnologySettings := Glob.TS.Common.Payload.DataEntityId;
                   END_IF;
                END_IF;
            END_IF;

           IF(Inputs <> NULL AND Outputs <> NULL) THEN
               ;//Units entry calls - You can use snippet unitRootCall
            
               UnitTemplate.X.StationNumber := eStations#UnitTemplate;                          
               UnitTemplate.Run(THIS, Inputs^, Outputs^, REF(Glob));


               
           END_IF;                           
        END_METHOD        
    END_CLASS   
             
    {S7.extern=ReadWrite}
    CLASS PUBLIC GlobalContextObjects
        VAR PUBLIC
            {#ix-attr:[AXOpen.Data.PersistentAttribute("")]}
            LastTechnologySettings : STRING ;

            Persits         : AxoDataPersistentExchange;
            PS              : axosimple.ProcessData;
            TS              : axosimple.TechnologyData; 
            PD              : axosimple.ProcessData;                        
        END_VAR
    END_CLASS

    {S7.extern=ReadWrite}
    CLASS ProcessData EXTENDS AXOpen.Data.AxoDataFragmentExchange
        VAR PUBLIC                    
            {#ix-attr:[AXOpen.Data.AxoDataFragmentAttribute]}
            Entity : SharedDataExchange;   
            
            // Units data - You can use snippet unitAddProcessData
                        
            {#ix-attr:[AXOpen.Data.AxoDataFragmentAttribute]}
            UnitTemplate : axosimple.UnitTemplate.ProcessDataExchange;
        
        END_VAR        
    END_CLASS

    {S7.extern=ReadWrite}
    CLASS TechnologyData EXTENDS AXOpen.Data.AxoDataFragmentExchange
        VAR PUBLIC                    
            {#ix-attr:[AXOpen.Data.AxoDataFragmentAttribute]}
            Common : TechnologySharedDataExchange;   
            
            {#ix-attr:[AXOpen.Data.AxoDataFragmentAttribute]}
            UnitTemplate : axosimple.UnitTemplate.TechnologyDataExchange;
        END_VAR        
    END_CLASS
END_NAMESPACE


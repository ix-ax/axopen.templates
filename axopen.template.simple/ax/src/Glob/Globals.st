NAMESPACE axosimple
    
    USING AXOpen.Data;
    USING AXOpen.Core;

    {S7.extern=ReadWrite}
    CLASS PUBLIC GlobalContextObjects EXTENDS AxoObject
        VAR PUBLIC
            {#ix-attr:[AXOpen.Data.PersistentAttribute("")]}
            LastTechnologySettings : STRING ;

            Persits         : AxoDataPersistentExchange;
            PS              : axosimple.ProcessData;
            TS              : axosimple.TechnologyData; 
            PD              : axosimple.ProcessData;                        
        END_VAR

        METHOD PUBLIC Run
            VAR_INPUT
                inParent : IAxoContext;
            END_VAR    
            THIS.Initialize(inParent);
            
            TS.Run(THIS);
            PS.Run(THIS);
            PD.Run(THIS);
            Persits.Run(THIS);

        END_METHOD    

    END_CLASS
END_NAMESPACE    
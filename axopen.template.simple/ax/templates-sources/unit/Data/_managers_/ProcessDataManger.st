NAMESPACE axosimple.UnitTemplate
    USING axosimple;
    USING AXOpen.Data;
    USING AXOpen.Core;
    USING System.Strings;
    
    {S7.extern=ReadWrite}
    CLASS ProcessDataManager
        EXTENDS AXOpen.Data.AxoDataFragmentExchange
        VAR PUBLIC
            {#ix-attr:[AXOpen.Data.AxoDataFragmentAttribute]}
            Shared : axosimple.SharedDataExchange;
            {#ix-attr:[AXOpen.Data.AxoDataFragmentAttribute]}
            Data : ProcessDataExchange;
        END_VAR 
        
        METHOD PUBLIC OVERRIDE Run
            VAR_INPUT
                parent : IAxoObject;
            END_VAR             
              SUPER.Run(parent := parent);
              Shared.Run(parent);
              Data.Run(parent);
        END_METHOD     
    END_CLASS
END_NAMESPACE    

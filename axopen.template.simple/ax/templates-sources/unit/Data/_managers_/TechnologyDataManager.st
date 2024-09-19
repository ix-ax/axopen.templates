NAMESPACE axosimple.UnitTemplate
    USING axosimple;
    USING AXOpen.Data;
    USING AXOpen.Core;
    USING System.Strings;
    
    {S7.extern=ReadWrite}
    CLASS TechnologyDataManager
        EXTENDS AXOpen.Data.AxoDataFragmentExchange
        VAR PUBLIC
            {#ix-attr:[AXOpen.Data.AxoDataFragmentAttribute]}
            Shared : axosimple.TechnologySharedDataExchange;            
            {#ix-attr:[AXOpen.Data.AxoDataFragmentAttribute]}
            Data : TechnologyDataExchange;
        END_VAR  

        METHOD PUBLIC OVERRIDE Run
            VAR_INPUT
                parent : IAxoObject;
            END_VAR
              Shared.Run(THIS);
              Data.Run(THIS);
              SUPER.Run(parent := parent);
        END_METHOD           
    END_CLASS
END_NAMESPACE    

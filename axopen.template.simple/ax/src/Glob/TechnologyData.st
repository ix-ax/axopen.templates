NAMESPACE axosimple
    {S7.extern=ReadWrite}
    CLASS TechnologyData EXTENDS AXOpen.Data.AxoDataFragmentExchange
        VAR PUBLIC                    
            {#ix-attr:[AXOpen.Data.AxoDataFragmentAttribute]}
            Common : TechnologySharedDataExchange;   
                 
            // Units data - snippet unitAddTechnologyData
            //{#ix-attr:[AXOpen.Data.AxoDataFragmentAttribute]}
            //UnitTemplate : axosimple.UnitTemplate.TechnologyDataExchange;
            
            
        END_VAR        
    END_CLASS
END_NAMESPACE    
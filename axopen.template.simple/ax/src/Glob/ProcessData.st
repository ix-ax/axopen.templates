NAMESPACE axosimple
    {S7.extern=ReadWrite}
    CLASS ProcessData EXTENDS AXOpen.Data.AxoDataFragmentExchange
        VAR PUBLIC                    
            {#ix-attr:[AXOpen.Data.AxoDataFragmentAttribute]}
            Shared : SharedDataExchange;   
                        
            // Units data - snippet unitAddProcessData
            //{#ix-attr:[AXOpen.Data.AxoDataFragmentAttribute]}
            // UnitTemplate : axosimple.UnitTemplate.ProcessDataExchange;
           
            
                                                
        END_VAR        
    END_CLASS
END_NAMESPACE    
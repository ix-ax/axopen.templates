NAMESPACE axosimple
    {S7.extern=ReadWrite}
    CLASS ProcessData EXTENDS AXOpen.Data.AxoDataFragmentExchange
        VAR PUBLIC                    
            {#ix-attr:[AXOpen.Data.AxoDataFragmentAttribute]}
            Entity : SharedDataExchange;   
                        
            // Units data - snippet unitAddProcessData
            {#ix-attr:[AXOpen.Data.AxoDataFragmentAttribute]}
            Cu10 : axosimple.Cu10.ProcessDataExchange;
                                                            
        END_VAR        
    END_CLASS
END_NAMESPACE    
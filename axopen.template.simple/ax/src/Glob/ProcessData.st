NAMESPACE axosimple
    {S7.extern=ReadWrite}
    CLASS ProcessData EXTENDS AXOpen.Data.AxoDataFragmentExchange
        VAR PUBLIC                    
            {#ix-attr:[AXOpen.Data.AxoDataFragmentAttribute]}
            Entity : SharedDataExchange;   
            
            // Units data - You can use snippet unitAddProcessData
                                                
        END_VAR        
    END_CLASS
END_NAMESPACE    
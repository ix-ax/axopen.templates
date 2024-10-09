NAMESPACE axosimple
    {S7.extern=ReadWrite}
    CLASS SharedDataExchange EXTENDS AXOpen.Data.AxoDataExchange
        VAR PUBLIC
            {#ix-generic:TOnline}
            {#ix-generic:TPlain as POCO}
            {#ix-attr:[AXOpen.Data.AxoDataEntityAttribute]}
            {#ix-attr:[Container(Layout.Stack)]}    
            {#ix-set:AttributeName = "<#UnitTemplate#>"}   
            Payload : SharedDataPayload;
        END_VAR        
    END_CLASS
        
END_NAMESPACE

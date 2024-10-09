NAMESPACE axosimple
    {S7.extern=ReadWrite}
    CLASS TechnologySharedDataExchange EXTENDS AXOpen.Data.AxoDataExchange
        VAR PUBLIC
            {#ix-generic:TOnline}
            {#ix-generic:TPlain as POCO}
            {#ix-attr:[AXOpen.Data.AxoDataEntityAttribute]}
            {#ix-attr:[Container(Layout.Stack)]}    
            {#ix-set:AttributeName = "<#UnitTemplate#>"}   
            Payload : TechnologySharedDataPayload;
        END_VAR        
    END_CLASS
        
END_NAMESPACE

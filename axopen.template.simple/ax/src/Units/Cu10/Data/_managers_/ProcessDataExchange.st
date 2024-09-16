NAMESPACE axosimple.Cu10
    USING axosimple;
    USING AXOpen.Data;
    USING AXOpen.Core;
    USING System.Strings;
    
    {S7.extern=ReadWrite}
    CLASS ProcessDataExchange
        EXTENDS AXOpen.Data.AxoDataExchange
        VAR PUBLIC
            {#ix-generic:TOnline}
            {#ix-generic:TPlain as POCO}
            {#ix-attr:[AXOpen.Data.AxoDataEntityAttribute]}        
            {#ix-attr:[Container(Layout.Stack)]}  
            {#ix-set:AttributeName = "<#Cu10#>"}   
            Payload : ProcessDataPayload;
        END_VAR
    END_CLASS
END_NAMESPACE    

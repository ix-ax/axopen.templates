NAMESPACE axosimple.Cu10
    USING axosimple;
    USING AXOpen.Data;
    USING AXOpen.Core;
    USING System.Strings;
    
    {S7.extern=ReadWrite}
    CLASS TechnologyDataExchange
        EXTENDS AXOpen.Data.AxoDataExchange
        VAR PUBLIC
            {#ix-generic:TOnline}
            {#ix-generic:TPlain as POCO}
            {#ix-attr:[AXOpen.Data.AxoDataEntityAttribute]}        
            {#ix-attr:[Container(Layout.Stack)]}
            {#ix-set:AttributeName = "<#Cu10#>"}         
            Payload : TechnologyDataPayload;
        END_VAR
    END_CLASS
END_NAMESPACE    

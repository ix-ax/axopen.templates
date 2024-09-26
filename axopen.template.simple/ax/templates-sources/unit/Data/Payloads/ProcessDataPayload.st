NAMESPACE axosimple.UnitTemplate
    USING axosimple;
    USING AXOpen.Data;
    USING AXOpen.Core;
    USING System.Strings;
 
    {S7.extern=ReadWrite}
    CLASS ProcessDataPayload
        EXTENDS AXOpen.Data.AxoDataEntity
        VAR PUBLIC
            {#ix-set:AttributeName = "<#Unit header#>"}             
            UnitHeader : UnitHeader;     
        END_VAR
    END_CLASS
END_NAMESPACE    

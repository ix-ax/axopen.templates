NAMESPACE axosimple.UnitTemplate
    USING axosimple;
    USING AXOpen.Data;
    USING AXOpen.Core;
    USING System.Strings;
 
    {S7.extern=ReadWrite}
    CLASS TechnologyDataPayload
        EXTENDS AXOpen.Data.AxoDataEntity
        VAR PUBLIC
            Header : axosimple.TechnologyUnitHeader;            
        END_VAR
    END_CLASS
END_NAMESPACE    

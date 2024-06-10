NAMESPACE axosimple.UnitTemplate
    USING axosimple;
    USING AXOpen.Data;
    USING AXOpen.Core;
    USING System.Strings;
 
    {S7.extern=ReadWrite}
    CLASS ProcessData
        EXTENDS AXOpen.Data.AxoDataEntity
        VAR PUBLIC
            Header : axosimple.UnitHeader;            
            DimX    : AXOpen.Inspectors.AxoAnalogueInspector;
            DimY    : AXOpen.Inspectors.AxoAnalogueInspector;
            DimZ    : AXOpen.Inspectors.AxoAnalogueInspector;            
        END_VAR
    END_CLASS
END_NAMESPACE    

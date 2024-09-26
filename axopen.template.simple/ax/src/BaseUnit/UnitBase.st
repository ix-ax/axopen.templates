NAMESPACE axosimple.BaseUnit
    
    USING axosimple;
    USING AXOpen.Data;
    USING AXOpen.Core;
    USING System.Strings;

    {S7.extern=ReadWrite}
    CLASS PUBLIC UnitBase
        VAR PUBLIC
            ///<summary>
            /// Station/Unit number.
            ///</summary>
            StationNumber : INT;
            
            ///<summary>
            /// Reference global objects in this technology
            ///</summary>
            G : REF_TO axosimple.GlobalContextObjects;

            {#ix-attr:[AXOpen.Data.PersistentAttribute("")]}
            LastTechnologySettings : STRING[64] ;
        END_VAR                        
    END_CLASS

END_NAMESPACE

NAMESPACE axosimple.UnitTemplate

    USING axosimple;
    USING AXOpen.Data;
    USING AXOpen.Core;
    USING System.Strings;

    {S7.extern=ReadWrite}
    CLASS PUBLIC Unit EXTENDS axosimple.BaseUnit.UnitBase
        VAR PUBLIC            
            ///<summary>
            /// Handles and intializes components used by this unit.
            ///</summary>
            C : axosimple.UnitTemplate.Components;
            
            ///<summary>
            /// Provides access to process data manager of this unit.
            ///</summary>
            PD : axosimple.UnitTemplate.ProcessDataManager;
            
            ///<summary>
            /// Provides access to technology data manager of this unit.
            ///</summary>
            TS : axosimple.UnitTemplate.TechnologyDataManager;

            // ///<summary>
            // /// Provides access to technology settings of this unit.
            // ///</summary>
            // TS : REF_TO axosimple.UnitTemplate.TechnologyDataExchange;

            // ///<summary>
            // /// Provides access to process setting of this unit.
            // ///</summary>
            // PS : REF_TO axosimple.UnitTemplate.ProcessDataExchange;

            {#ix-attr:[AXOpen.Data.PersistentAttribute("UnitTemplate")]}
            SpecialSettings :STRING[64] ;

            // https://ix-ax.github.io/AXOpen/core/docs/AXODIALOG.html#closing-a-dialog-with-external-signal
            _DL     : AXOpen.Core.AxoDialog;

            // https://ix-ax.github.io/AXOpen/core/docs/AXOALERTDIALOG.html#invoking-alerts-from-plc
            _ADL    : AXOpen.Core.AxoAlert;

            // it needs to be handle from auto or ground sequnce
            _IDL    : AXOpen.Inspectors.AxoInspectorDialog;
        END_VAR               
    END_CLASS

END_NAMESPACE

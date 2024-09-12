NAMESPACE axosimple.StarterUnitTemplate

    USING axosimple;
    USING AXOpen.Data;
    USING AXOpen.Core;
    USING System.Strings;

    {S7.extern=ReadWrite}
    CLASS PUBLIC UnitObjects EXTENDS axosimple.BaseUnit.UnitObjects
        VAR PUBLIC            
            ///<summary>
            /// Handles and intializes components used by this unit.
            ///</summary>
            C : axosimple.StarterUnitTemplate.Components;
            
            ///<summary>
            /// Provides access to process data manager of this unit.
            ///</summary>
            PD : axosimple.StarterUnitTemplate.ProcessDataManager;
            
            ///<summary>
            /// Provides access to technology data manager of this unit.
            ///</summary>
            TD : axosimple.StarterUnitTemplate.TechnologyDataManager;

            ///<summary>
            /// Provides access to technology settings of this unit.
            ///</summary>
            TS : REF_TO axosimple.StarterUnitTemplate.TechnologyDataExchange;

            ///<summary>
            /// Provides access to process setting of this unit.
            ///</summary>
            PS : REF_TO axosimple.StarterUnitTemplate.ProcessDataExchange;

            {#ix-attr:[AXOpen.Data.PersistentAttribute("StarterUnitTemplate")]}
            SpecialSettings :STRING[64] ;

            // https://ix-ax.github.io/AXOpen/core/docs/AXODIALOG.html#closing-a-dialog-with-external-signal
            _dialog : AXOpen.Core.AxoDialog;

            // https://ix-ax.github.io/AXOpen/core/docs/AXOALERTDIALOG.html#invoking-alerts-from-plc
            _alertDialog : AXOpen.Core.AxoAlert;

            // it needs to be handle from auto or ground sequnce
            _inspectorDialog       : AXOpen.Inspectors.AxoInspectorDialog;

        END_VAR        
    END_CLASS

END_NAMESPACE

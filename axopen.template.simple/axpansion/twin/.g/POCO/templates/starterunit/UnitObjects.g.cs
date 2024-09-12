using System;

namespace Pocos
{
    namespace axosimple.StarterUnitTemplate
    {
        public partial class UnitObjects : axosimple.BaseUnit.UnitObjects, AXSharp.Connector.IPlain
        {
            public UnitObjects() : base()
            {
            }

            public axosimple.StarterUnitTemplate.Components C { get; set; } = new axosimple.StarterUnitTemplate.Components();
            public axosimple.StarterUnitTemplate.ProcessDataManager PD { get; set; } = new axosimple.StarterUnitTemplate.ProcessDataManager();
            public axosimple.StarterUnitTemplate.TechnologyDataManager TD { get; set; } = new axosimple.StarterUnitTemplate.TechnologyDataManager();
            public string SpecialSettings { get; set; } = string.Empty;
            public AXOpen.Core.AxoDialog _DL { get; set; } = new AXOpen.Core.AxoDialog();
            public AXOpen.Core.AxoAlert _ADL { get; set; } = new AXOpen.Core.AxoAlert();
            public AXOpen.Inspectors.AxoInspectorDialog _IDL { get; set; } = new AXOpen.Inspectors.AxoInspectorDialog();
        }
    }
}
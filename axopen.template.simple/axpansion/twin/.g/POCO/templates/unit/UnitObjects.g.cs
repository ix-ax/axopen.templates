using System;

namespace Pocos
{
    namespace axosimple.UnitTemplate
    {
        public partial class UnitObjects : axosimple.BaseUnit.UnitObjects, AXSharp.Connector.IPlain
        {
            public UnitObjects() : base()
            {
            }

            public axosimple.UnitTemplate.Components C { get; set; } = new axosimple.UnitTemplate.Components();
            public axosimple.UnitTemplate.ProcessDataManager PD { get; set; } = new axosimple.UnitTemplate.ProcessDataManager();
            public axosimple.UnitTemplate.TechnologyDataManager TD { get; set; } = new axosimple.UnitTemplate.TechnologyDataManager();
            public string SpecialSettings { get; set; } = string.Empty;
            public AXOpen.Core.AxoDialog _DL { get; set; } = new AXOpen.Core.AxoDialog();
            public AXOpen.Core.AxoAlert _ADL { get; set; } = new AXOpen.Core.AxoAlert();
            public AXOpen.Inspectors.AxoInspectorDialog _IDL { get; set; } = new AXOpen.Inspectors.AxoInspectorDialog();
        }
    }
}
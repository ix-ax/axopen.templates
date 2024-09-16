using System;

namespace Pocos
{
    namespace axosimple.Cu10
    {
        public partial class UnitObjects : axosimple.BaseUnit.UnitObjects, AXSharp.Connector.IPlain
        {
            public UnitObjects() : base()
            {
            }

            public axosimple.Cu10.Components C { get; set; } = new axosimple.Cu10.Components();
            public axosimple.Cu10.ProcessDataManager PD { get; set; } = new axosimple.Cu10.ProcessDataManager();
            public axosimple.Cu10.TechnologyDataManager TD { get; set; } = new axosimple.Cu10.TechnologyDataManager();
            public string SpecialSettings { get; set; } = string.Empty;
            public AXOpen.Core.AxoDialog _DL { get; set; } = new AXOpen.Core.AxoDialog();
            public AXOpen.Core.AxoAlert _ADL { get; set; } = new AXOpen.Core.AxoAlert();
            public AXOpen.Inspectors.AxoInspectorDialog _IDL { get; set; } = new AXOpen.Inspectors.AxoInspectorDialog();
        }
    }
}
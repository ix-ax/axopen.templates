using System;

namespace Pocos
{
    namespace axosimple.MyUnit
    {
        public partial class UnitObjects : axosimple.BaseUnit.UnitObjects, AXSharp.Connector.IPlain
        {
            public UnitObjects() : base()
            {
            }

            public axosimple.MyUnit.Components C { get; set; } = new axosimple.MyUnit.Components();
            public axosimple.MyUnit.ProcessDataManager PD { get; set; } = new axosimple.MyUnit.ProcessDataManager();
            public axosimple.MyUnit.TechnologyDataManager TD { get; set; } = new axosimple.MyUnit.TechnologyDataManager();
            public string SpecialSettings { get; set; } = string.Empty;
            public AXOpen.Core.AxoDialog _DL { get; set; } = new AXOpen.Core.AxoDialog();
            public AXOpen.Core.AxoAlert _ADL { get; set; } = new AXOpen.Core.AxoAlert();
            public AXOpen.Inspectors.AxoInspectorDialog _IDL { get; set; } = new AXOpen.Inspectors.AxoInspectorDialog();
        }
    }
}
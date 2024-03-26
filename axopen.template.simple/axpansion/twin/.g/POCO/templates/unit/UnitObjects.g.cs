using System;

namespace Pocos
{
    namespace axosimple.UnitTemplate
    {
        public partial class UnitObjects : axosimple.BaseUnit.UnitObjects, AXSharp.Connector.IPlain
        {
            public string SpecialSettings { get; set; } = string.Empty;
            public AXOpen.Core.AxoDialog _dialog { get; set; } = new AXOpen.Core.AxoDialog();
            public AXOpen.Core.AxoAlert _alertDialog { get; set; } = new AXOpen.Core.AxoAlert();
            public AXOpen.Inspectors.AxoInspectorDialog _inspectorDialog { get; set; } = new AXOpen.Inspectors.AxoInspectorDialog();
        }
    }
}
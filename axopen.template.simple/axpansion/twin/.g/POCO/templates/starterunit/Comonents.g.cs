using System;

namespace Pocos
{
    namespace axosimple.StarterUnitTemplate
    {
        public partial class Components : AXOpen.Core.AxoObject, AXSharp.Connector.IPlain
        {
            public AXOpen.Components.Pneumatics.AxoCylinder HorizontalCylinder { get; set; } = new AXOpen.Components.Pneumatics.AxoCylinder();
            public AXOpen.Components.Pneumatics.AxoCylinder VerticalCylinder { get; set; } = new AXOpen.Components.Pneumatics.AxoCylinder();
            public AXOpen.Components.Pneumatics.AxoCylinder GripperCylinder { get; set; } = new AXOpen.Components.Pneumatics.AxoCylinder();
            public AXOpen.Components.Cognex.Vision.v_6_0_0_0.AxoDataman DMCReader { get; set; } = new AXOpen.Components.Cognex.Vision.v_6_0_0_0.AxoDataman();
            public AXOpen.Elements.AxoDi PartPresenceSensor { get; set; } = new AXOpen.Elements.AxoDi();
        }
    }
}
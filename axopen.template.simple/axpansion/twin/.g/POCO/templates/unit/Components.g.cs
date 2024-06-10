using System;

namespace Pocos
{
    namespace axosimple.UnitTemplate
    {
        public partial class Components : AXOpen.Core.AxoObject, AXSharp.Connector.IPlain
        {
            public Components() : base()
            {
            }

            public AXOpen.Components.Pneumatics.AxoCylinder HorizontalCylinder { get; set; } = new AXOpen.Components.Pneumatics.AxoCylinder();
            public AXOpen.Components.Pneumatics.AxoCylinder VerticalCylinder { get; set; } = new AXOpen.Components.Pneumatics.AxoCylinder();
            public AXOpen.Components.Pneumatics.AxoCylinder GripperCylinder { get; set; } = new AXOpen.Components.Pneumatics.AxoCylinder();
        }
    }
}
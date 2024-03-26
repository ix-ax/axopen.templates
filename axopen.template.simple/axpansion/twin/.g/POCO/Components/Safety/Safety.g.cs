using System;

namespace Pocos
{
    namespace axosimple.Safety
    {
        public partial class BaseZoneLogic : AXOpen.Core.AxoObject, AXSharp.Connector.IPlain, axosimple.Safety.IZone
        {
            public Boolean AllUnitInAuto { get; set; }

            public Boolean AllUnitInGrounded { get; set; }

            public Boolean AllUnitInService { get; set; }

            public Boolean AllKeysMan { get; set; }

            public Boolean AllKeysAuto { get; set; }
        }

        public partial class ControlPanel : AXOpen.Core.AxoObject, AXSharp.Connector.IPlain, axosimple.Safety.IControlPanel
        {
            public axosimple.Safety.EmergencyStop EStop { get; set; } = new axosimple.Safety.EmergencyStop();
            public AXOpen.Elements.AxoDi ButtonStart { get; set; } = new AXOpen.Elements.AxoDi();
            public AXOpen.Elements.AxoDi ButtonStop { get; set; } = new AXOpen.Elements.AxoDi();
            public AXOpen.Elements.AxoDi KeyManual { get; set; } = new AXOpen.Elements.AxoDi();
            public AXOpen.Elements.AxoDi KeyAuto { get; set; } = new AXOpen.Elements.AxoDi();
        }

        public partial class Door : AXOpen.Core.AxoObject, AXSharp.Connector.IPlain, axosimple.Safety.IDoor
        {
            public AXOpen.Components.Pneumatics.AxoCylinder Lock { get; set; } = new AXOpen.Components.Pneumatics.AxoCylinder();
        }

        public partial class EmergencyStop : AXOpen.Elements.AxoDi, AXSharp.Connector.IPlain, axosimple.Safety.IEmergencyStop
        {
        }
    }
}
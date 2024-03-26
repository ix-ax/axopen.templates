using System;

namespace Pocos
{
    namespace axosimple
    {
        public partial class TechnologySafety : AXOpen.Core.AxoObject, AXSharp.Connector.IPlain
        {
            public axosimple.SafetyZone_1 Zone_1 { get; set; } = new axosimple.SafetyZone_1();
            public axosimple.SafetyZone_2 Zone_2 { get; set; } = new axosimple.SafetyZone_2();
        }

        public partial class SafetyZone_1 : AXOpen.Core.AxoObject, AXSharp.Connector.IPlain
        {
            public axosimple.Safety.BaseZoneLogic LogicController { get; set; } = new axosimple.Safety.BaseZoneLogic();
            public axosimple.Safety.ControlPanel Panel_1 { get; set; } = new axosimple.Safety.ControlPanel();
            public axosimple.Safety.ControlPanel Panel_2 { get; set; } = new axosimple.Safety.ControlPanel();
            public axosimple.Safety.EmergencyStop EStop_External_1 { get; set; } = new axosimple.Safety.EmergencyStop();
            public axosimple.Safety.EmergencyStop EStop_External_2 { get; set; } = new axosimple.Safety.EmergencyStop();
            public axosimple.Safety.Door Door_1 { get; set; } = new axosimple.Safety.Door();
            public axosimple.Safety.Door Door_2 { get; set; } = new axosimple.Safety.Door();
        }

        public partial class SafetyZone_2 : AXOpen.Core.AxoObject, AXSharp.Connector.IPlain
        {
            public axosimple.Safety.BaseZoneLogic LogicController { get; set; } = new axosimple.Safety.BaseZoneLogic();
            public axosimple.Safety.ControlPanel Panel_1 { get; set; } = new axosimple.Safety.ControlPanel();
            public axosimple.Safety.EmergencyStop EStop_External_1 { get; set; } = new axosimple.Safety.EmergencyStop();
            public axosimple.Safety.Door Door_1 { get; set; } = new axosimple.Safety.Door();
        }
    }
}
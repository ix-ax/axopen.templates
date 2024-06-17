using System;
using Pocos.AXOpen.Core;
using Pocos.AXOpen.Messaging;
using Pocos.AXOpen.Messaging.Static;

namespace Pocos
{
    namespace AXOpen.Pneumatics
    {
        public partial class Cylinder : AXOpen.Core.AxoComponent, AXSharp.Connector.IPlain
        {
            public Cylinder() : base()
            {
            }

            public AXOpen.Core.AxoTask MoveToWork { get; set; } = new AXOpen.Core.AxoTask();
            public AXOpen.Core.AxoTask Stop { get; set; } = new AXOpen.Core.AxoTask();
            public AXOpen.Core.AxoTask MoveToHome { get; set; } = new AXOpen.Core.AxoTask();
            public Boolean _HomeSensor { get; set; }

            public Boolean _WorkSensor { get; set; }

            public Boolean _MoveHomeSignal { get; set; }

            public Boolean _MoveWorkSignal { get; set; }

            public AXOpen.Messaging.Static.AxoMessenger _MoveToWorkNotReached { get; set; } = new AXOpen.Messaging.Static.AxoMessenger();
            public AXOpen.Messaging.Static.AxoMessenger _MoveToHomeNotReached { get; set; } = new AXOpen.Messaging.Static.AxoMessenger();
        }
    }
}
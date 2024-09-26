using System;
using Pocos.AXOpen.Core;
using Pocos.AXOpen;
using Pocos.AXOpen.Core;
using Pocos.AXOpen.Data;

namespace Pocos
{
    namespace axosimple
    {
        public partial class Context : AXOpen.Core.AxoContext, AXSharp.Connector.IPlain
        {
            public Context() : base()
            {
            }

            public axosimple.GlobalContextObjects Glob { get; set; } = new axosimple.GlobalContextObjects();
            public axosimple.TechnologySafety Safety { get; set; } = new axosimple.TechnologySafety();
            public AXOpen.S71500.Rtc S71500Rtc { get; set; } = new AXOpen.S71500.Rtc();
            public AXOpen.S71500.Rtm S71500Rtm { get; set; } = new AXOpen.S71500.Rtm();
            public AXOpen.Logging.AxoLogger ContextLogger { get; set; } = new AXOpen.Logging.AxoLogger();
            public Boolean DoSynchronize { get; set; }

            public DateTime TimeSynch { get; set; } = default(DateTime);
            public DateTime ControllerRtm { get; set; } = default(DateTime);
        }
    }
}
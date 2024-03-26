using System;

namespace Pocos
{
    using axosimple;

    public partial class axosimpleTwinController
    {
        public axosimple.Inputs Inputs { get; set; } = new axosimple.Inputs();
        public axosimple.Outputs Outputs { get; set; } = new axosimple.Outputs();
        public axosimple.Context Context { get; set; } = new axosimple.Context();
        public AXOpen.S71500.Rtc S71500Rtc { get; set; } = new AXOpen.S71500.Rtc();
        public AXOpen.Logging.AxoLogger ContextLogger { get; set; } = new AXOpen.Logging.AxoLogger();
    }
}
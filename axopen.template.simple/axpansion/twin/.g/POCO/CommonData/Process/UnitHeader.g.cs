using System;

namespace Pocos
{
    namespace axosimple
    {
        public partial class UnitHeader
        {
            public Int16 OnPassed { get; set; }

            public Int16 OnFailed { get; set; }

            public TimeSpan CycleTime { get; set; } = default(TimeSpan);
            public TimeSpan CleanLoopTime { get; set; } = default(TimeSpan);
            public DateTime OperationsStarted { get; set; } = default(DateTime);
            public DateTime OperationsEnded { get; set; } = default(DateTime);
            public string Operator { get; set; } = string.Empty;
        }
    }
}
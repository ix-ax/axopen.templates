using System;

namespace Pocos
{
    namespace axosimple
    {
        public partial class TechnologyUnitHeader
        {
            public TimeSpan IdealCycleTime { get; set; } = default(TimeSpan);
            public TimeSpan WarningCycleTime { get; set; } = default(TimeSpan);
            public TimeSpan ErrorCycleTime { get; set; } = default(TimeSpan);
            public TimeSpan WarningStepAlarmTime { get; set; } = default(TimeSpan);
            public TimeSpan ErrorStepAlarmTime { get; set; } = default(TimeSpan);
            public TimeSpan TimeToEntryEnergySavingMode { get; set; } = default(TimeSpan);
            public UInt16 ConsecutiveErrorCount { get; set; }
        }
    }
}
using System;

namespace Pocos
{
    namespace axosimple
    {
        public partial class TechnologyCommonData : AXOpen.Data.AxoDataEntity, AXSharp.Connector.IPlain
        {
            public TechnologyCommonData() : base()
            {
            }

            public TimeSpan IdealCycleTime { get; set; } = default(TimeSpan);
            public TimeSpan WarningCycleTime { get; set; } = default(TimeSpan);
            public TimeSpan ErrorCycleTime { get; set; } = default(TimeSpan);
            public TimeSpan TimeToEntryEnergySavingMode { get; set; } = default(TimeSpan);
        }
    }
}
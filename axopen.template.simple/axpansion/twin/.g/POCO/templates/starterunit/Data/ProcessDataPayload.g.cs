using System;

namespace Pocos
{
    namespace axosimple.StarterUnitTemplate
    {
        public partial class ProcessDataPayload : AXOpen.Data.AxoDataEntity, AXSharp.Connector.IPlain
        {
            public ProcessDataPayload() : base()
            {
            }

            public UInt64 CounterDelay { get; set; }

            public AXOpen.Inspectors.AxoDigitalInspector PartPresence { get; set; } = new AXOpen.Inspectors.AxoDigitalInspector();
            public AXOpen.Inspectors.AxoDataInspector JigDataMatrixCode { get; set; } = new AXOpen.Inspectors.AxoDataInspector();
            public AXOpen.Inspectors.AxoAnalogueInspector LoadPosition { get; set; } = new AXOpen.Inspectors.AxoAnalogueInspector();
        }
    }
}
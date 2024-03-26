using System;

namespace Pocos
{
    namespace axosimple.UnitTemplate
    {
        public partial class ProcessData : AXOpen.Data.AxoDataEntity, AXSharp.Connector.IPlain
        {
            public axosimple.UnitHeader Header { get; set; } = new axosimple.UnitHeader();
            public AXOpen.Inspectors.AxoDataInspector JigDataMatrixCode { get; set; } = new AXOpen.Inspectors.AxoDataInspector();
            public AXOpen.Inspectors.AxoDigitalInspector PartPresence { get; set; } = new AXOpen.Inspectors.AxoDigitalInspector();
            public AXOpen.Inspectors.AxoAnalogueInspector RivetingPreasure { get; set; } = new AXOpen.Inspectors.AxoAnalogueInspector();
        }
    }
}
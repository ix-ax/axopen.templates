using System;

namespace Pocos
{
    namespace axosimple.UnitTemplate
    {
        public partial class ProcessData : AXOpen.Data.AxoDataEntity, AXSharp.Connector.IPlain
        {
            public ProcessData() : base()
            {
            }

            public axosimple.UnitHeader Header { get; set; } = new axosimple.UnitHeader();
            public AXOpen.Inspectors.AxoAnalogueInspector DimX { get; set; } = new AXOpen.Inspectors.AxoAnalogueInspector();
            public AXOpen.Inspectors.AxoAnalogueInspector DimY { get; set; } = new AXOpen.Inspectors.AxoAnalogueInspector();
            public AXOpen.Inspectors.AxoAnalogueInspector DimZ { get; set; } = new AXOpen.Inspectors.AxoAnalogueInspector();
        }
    }
}
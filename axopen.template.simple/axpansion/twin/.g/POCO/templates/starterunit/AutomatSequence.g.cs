using System;

namespace Pocos
{
    namespace axosimple.StarterUnitTemplate
    {
        public partial class AutomatSequence : AXOpen.Core.AxoSequencerContainer, AXSharp.Connector.IPlain, IModeContainer
        {
            public AXOpen.Core.AxoStep[] Steps { get; set; } = new AXOpen.Core.AxoStep[101];
            public Boolean _inspectionResult { get; set; }

            public Double _inspectionValue { get; set; }

            public string _inspectionData { get; set; } = string.Empty;
            public AXOpen.Inspectors.AxoComprehensiveResult _comprehensiveResult { get; set; } = new AXOpen.Inspectors.AxoComprehensiveResult();
        }
    }
}
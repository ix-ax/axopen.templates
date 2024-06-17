using System;

namespace Pocos
{
    namespace axosimple.StarterUnitTemplate
    {
        public partial class AutomatSequence : AXOpen.Core.AxoSequencerContainer, AXSharp.Connector.IPlain, IModeContainer
        {
            public AutomatSequence() : base()
            {
#pragma warning disable CS0612
                AXSharp.Connector.BuilderHelpers.Arrays.InstantiateArray(Steps, () => new AXOpen.Core.AxoStep(), new[] { (0, 100) });
#pragma warning restore CS0612
            }

            public AXOpen.Core.AxoStep[] Steps { get; set; } = new AXOpen.Core.AxoStep[101];
            public Boolean _inspectionResult { get; set; }

            public Double _inspectionValue { get; set; }

            public string _inspectionData { get; set; } = string.Empty;
            public AXOpen.Inspectors.AxoComprehensiveResult _comprehensiveResult { get; set; } = new AXOpen.Inspectors.AxoComprehensiveResult();
        }
    }
}
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
        }
    }
}
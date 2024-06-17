using System;

namespace Pocos
{
    namespace axosimple.StarterUnitTemplate
    {
        public partial class GroundSequence : AXOpen.Core.AxoSequencerContainer, AXSharp.Connector.IPlain, IModeContainer
        {
            public GroundSequence() : base()
            {
#pragma warning disable CS0612
                AXSharp.Connector.BuilderHelpers.Arrays.InstantiateArray(Steps, () => new AXOpen.Core.AxoStep(), new[] { (0, 100) });
#pragma warning restore CS0612
            }

            public AXOpen.Core.AxoStep[] Steps { get; set; } = new AXOpen.Core.AxoStep[101];
            public AXOpen.Core.AxoTask MoveToWork { get; set; } = new AXOpen.Core.AxoTask();
        }
    }
}
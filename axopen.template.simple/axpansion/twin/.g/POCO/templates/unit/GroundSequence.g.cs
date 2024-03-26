using System;

namespace Pocos
{
    namespace axosimple.UnitTemplate
    {
        public partial class GroundSequence : AXOpen.Core.AxoSequencerContainer, AXSharp.Connector.IPlain, IModeContainer
        {
            public AXOpen.Core.AxoStep[] Steps { get; set; } = new AXOpen.Core.AxoStep[21];
            public AXOpen.Core.AxoTask MoveToWork { get; set; } = new AXOpen.Core.AxoTask();
        }
    }
}
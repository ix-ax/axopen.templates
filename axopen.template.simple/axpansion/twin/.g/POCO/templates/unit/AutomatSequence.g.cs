using System;

namespace Pocos
{
    namespace axosimple.UnitTemplate
    {
        public partial class AutomatSequence : AXOpen.Core.AxoSequencerContainer, AXSharp.Connector.IPlain, IModeContainer
        {
            public AXOpen.Core.AxoStep[] Steps { get; set; } = new AXOpen.Core.AxoStep[151];
        }
    }
}
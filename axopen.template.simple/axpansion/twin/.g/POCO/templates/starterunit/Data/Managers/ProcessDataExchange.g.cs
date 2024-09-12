using System;

namespace Pocos
{
    namespace axosimple.StarterUnitTemplate
    {
        public partial class ProcessDataExchange : AXOpen.Data.AxoDataExchange, AXSharp.Connector.IPlain
        {
            public ProcessDataExchange() : base()
            {
            }

            public axosimple.StarterUnitTemplate.ProcessDataPayload Payload { get; set; } = new axosimple.StarterUnitTemplate.ProcessDataPayload();
        }
    }
}
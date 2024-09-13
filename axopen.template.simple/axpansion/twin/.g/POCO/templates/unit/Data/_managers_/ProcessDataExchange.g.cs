using System;

namespace Pocos
{
    namespace axosimple.UnitTemplate
    {
        public partial class ProcessDataExchange : AXOpen.Data.AxoDataExchange, AXSharp.Connector.IPlain
        {
            public ProcessDataExchange() : base()
            {
            }

            public axosimple.UnitTemplate.ProcessDataPayload Payload { get; set; } = new axosimple.UnitTemplate.ProcessDataPayload();
        }
    }
}
using System;

namespace Pocos
{
    namespace axosimple.Cu10
    {
        public partial class ProcessDataExchange : AXOpen.Data.AxoDataExchange, AXSharp.Connector.IPlain
        {
            public ProcessDataExchange() : base()
            {
            }

            public axosimple.Cu10.ProcessDataPayload Payload { get; set; } = new axosimple.Cu10.ProcessDataPayload();
        }
    }
}
using System;

namespace Pocos
{
    namespace axosimple.MyUnit
    {
        public partial class ProcessDataExchange : AXOpen.Data.AxoDataExchange, AXSharp.Connector.IPlain
        {
            public ProcessDataExchange() : base()
            {
            }

            public axosimple.MyUnit.ProcessDataPayload Payload { get; set; } = new axosimple.MyUnit.ProcessDataPayload();
        }
    }
}
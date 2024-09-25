using System;

namespace Pocos
{
    namespace axosimple
    {
        public partial class SharedDataExchange : AXOpen.Data.AxoDataExchange, AXSharp.Connector.IPlain
        {
            public SharedDataExchange() : base()
            {
            }

            public axosimple.SharedDataPayload Payload { get; set; } = new axosimple.SharedDataPayload();
        }
    }
}
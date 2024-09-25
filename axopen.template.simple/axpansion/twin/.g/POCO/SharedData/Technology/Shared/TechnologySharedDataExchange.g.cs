using System;

namespace Pocos
{
    namespace axosimple
    {
        public partial class TechnologySharedDataExchange : AXOpen.Data.AxoDataExchange, AXSharp.Connector.IPlain
        {
            public TechnologySharedDataExchange() : base()
            {
            }

            public axosimple.TechnologySharedDataPayload Payload { get; set; } = new axosimple.TechnologySharedDataPayload();
        }
    }
}
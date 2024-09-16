using System;

namespace Pocos
{
    namespace axosimple.Cu10
    {
        public partial class TechnologyDataExchange : AXOpen.Data.AxoDataExchange, AXSharp.Connector.IPlain
        {
            public TechnologyDataExchange() : base()
            {
            }

            public axosimple.Cu10.TechnologyDataPayload Payload { get; set; } = new axosimple.Cu10.TechnologyDataPayload();
        }
    }
}
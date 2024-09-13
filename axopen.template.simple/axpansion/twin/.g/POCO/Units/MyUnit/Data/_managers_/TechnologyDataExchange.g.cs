using System;

namespace Pocos
{
    namespace axosimple.MyUnit
    {
        public partial class TechnologyDataExchange : AXOpen.Data.AxoDataExchange, AXSharp.Connector.IPlain
        {
            public TechnologyDataExchange() : base()
            {
            }

            public axosimple.MyUnit.TechnologyDataPayload Payload { get; set; } = new axosimple.MyUnit.TechnologyDataPayload();
        }
    }
}
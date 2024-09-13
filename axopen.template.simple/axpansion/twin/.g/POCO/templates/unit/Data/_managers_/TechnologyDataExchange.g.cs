using System;

namespace Pocos
{
    namespace axosimple.UnitTemplate
    {
        public partial class TechnologyDataExchange : AXOpen.Data.AxoDataExchange, AXSharp.Connector.IPlain
        {
            public TechnologyDataExchange() : base()
            {
            }

            public axosimple.UnitTemplate.TechnologyDataPayload Payload { get; set; } = new axosimple.UnitTemplate.TechnologyDataPayload();
        }
    }
}
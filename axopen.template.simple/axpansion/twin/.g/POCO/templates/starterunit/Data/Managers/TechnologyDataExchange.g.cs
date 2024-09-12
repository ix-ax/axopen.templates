using System;

namespace Pocos
{
    namespace axosimple.StarterUnitTemplate
    {
        public partial class TechnologyDataExchange : AXOpen.Data.AxoDataExchange, AXSharp.Connector.IPlain
        {
            public TechnologyDataExchange() : base()
            {
            }

            public axosimple.StarterUnitTemplate.TechnologyDataPayload Payload { get; set; } = new axosimple.StarterUnitTemplate.TechnologyDataPayload();
        }
    }
}
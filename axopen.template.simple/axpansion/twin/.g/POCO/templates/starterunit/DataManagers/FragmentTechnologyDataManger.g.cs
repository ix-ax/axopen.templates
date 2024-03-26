using System;

namespace Pocos
{
    namespace axosimple.StarterUnitTemplate
    {
        public partial class FragmentTechnologyDataManger : AXOpen.Data.AxoDataExchange, AXSharp.Connector.IPlain
        {
            public axosimple.StarterUnitTemplate.TechnologyData Payload { get; set; } = new axosimple.StarterUnitTemplate.TechnologyData();
        }
    }
}
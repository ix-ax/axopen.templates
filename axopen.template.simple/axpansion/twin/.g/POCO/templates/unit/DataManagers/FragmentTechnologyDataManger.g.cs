using System;

namespace Pocos
{
    namespace axosimple.UnitTemplate
    {
        public partial class FragmentTechnologyDataManger : AXOpen.Data.AxoDataExchange, AXSharp.Connector.IPlain
        {
            public axosimple.UnitTemplate.TechnologyData Payload { get; set; } = new axosimple.UnitTemplate.TechnologyData();
        }
    }
}
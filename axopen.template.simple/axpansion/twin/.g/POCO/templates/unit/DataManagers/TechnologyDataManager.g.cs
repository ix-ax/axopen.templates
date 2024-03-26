using System;

namespace Pocos
{
    namespace axosimple.UnitTemplate
    {
        public partial class TechnologyDataManager : AXOpen.Data.AxoDataFragmentExchange, AXSharp.Connector.IPlain
        {
            public axosimple.TechnologyCommonDataManager Shared { get; set; } = new axosimple.TechnologyCommonDataManager();
            public axosimple.UnitTemplate.FragmentTechnologyDataManger DataManger { get; set; } = new axosimple.UnitTemplate.FragmentTechnologyDataManger();
        }
    }
}
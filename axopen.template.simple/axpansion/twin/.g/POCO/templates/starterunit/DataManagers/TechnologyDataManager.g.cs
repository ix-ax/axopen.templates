using System;

namespace Pocos
{
    namespace axosimple.StarterUnitTemplate
    {
        public partial class TechnologyDataManager : AXOpen.Data.AxoDataFragmentExchange, AXSharp.Connector.IPlain
        {
            public TechnologyDataManager() : base()
            {
            }

            public axosimple.TechnologyCommonDataManager Shared { get; set; } = new axosimple.TechnologyCommonDataManager();
            public axosimple.StarterUnitTemplate.FragmentTechnologyDataManger DataManger { get; set; } = new axosimple.StarterUnitTemplate.FragmentTechnologyDataManger();
        }
    }
}
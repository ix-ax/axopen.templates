using System;

namespace Pocos
{
    namespace axosimple.UnitTemplate
    {
        public partial class TechnologyDataManager : AXOpen.Data.AxoDataFragmentExchange, AXSharp.Connector.IPlain
        {
            public TechnologyDataManager() : base()
            {
            }

            public axosimple.TechnologySharedDataExchange Shared { get; set; } = new axosimple.TechnologySharedDataExchange();
            public axosimple.UnitTemplate.FragmentTechnologyDataManger DataManger { get; set; } = new axosimple.UnitTemplate.FragmentTechnologyDataManger();
        }
    }
}
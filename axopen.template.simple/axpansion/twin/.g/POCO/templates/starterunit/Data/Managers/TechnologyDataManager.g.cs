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

            public axosimple.TechnologySharedDataExchange Shared { get; set; } = new axosimple.TechnologySharedDataExchange();
            public axosimple.StarterUnitTemplate.TechnologyDataExchange Data { get; set; } = new axosimple.StarterUnitTemplate.TechnologyDataExchange();
        }
    }
}
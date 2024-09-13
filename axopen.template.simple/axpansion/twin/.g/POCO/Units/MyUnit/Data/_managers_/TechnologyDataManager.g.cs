using System;

namespace Pocos
{
    namespace axosimple.MyUnit
    {
        public partial class TechnologyDataManager : AXOpen.Data.AxoDataFragmentExchange, AXSharp.Connector.IPlain
        {
            public TechnologyDataManager() : base()
            {
            }

            public axosimple.TechnologySharedDataExchange Shared { get; set; } = new axosimple.TechnologySharedDataExchange();
            public axosimple.MyUnit.TechnologyDataExchange Data { get; set; } = new axosimple.MyUnit.TechnologyDataExchange();
        }
    }
}
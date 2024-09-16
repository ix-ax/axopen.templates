using System;

namespace Pocos
{
    namespace axosimple.Cu10
    {
        public partial class TechnologyDataManager : AXOpen.Data.AxoDataFragmentExchange, AXSharp.Connector.IPlain
        {
            public TechnologyDataManager() : base()
            {
            }

            public axosimple.TechnologySharedDataExchange Shared { get; set; } = new axosimple.TechnologySharedDataExchange();
            public axosimple.Cu10.TechnologyDataExchange Data { get; set; } = new axosimple.Cu10.TechnologyDataExchange();
        }
    }
}
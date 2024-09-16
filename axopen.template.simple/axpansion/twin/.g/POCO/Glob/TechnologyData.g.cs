using System;

namespace Pocos
{
    namespace axosimple
    {
        public partial class TechnologyData : AXOpen.Data.AxoDataFragmentExchange, AXSharp.Connector.IPlain
        {
            public TechnologyData() : base()
            {
            }

            public axosimple.TechnologySharedDataExchange Common { get; set; } = new axosimple.TechnologySharedDataExchange();
        }
    }
}
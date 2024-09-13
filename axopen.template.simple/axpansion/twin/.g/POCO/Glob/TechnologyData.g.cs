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
            public axosimple.MyUnit.TechnologyDataExchange MyUnit { get; set; } = new axosimple.MyUnit.TechnologyDataExchange();
        }
    }
}
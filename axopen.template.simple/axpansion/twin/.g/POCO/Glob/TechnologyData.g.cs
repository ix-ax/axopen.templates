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
            public axosimple.Cu10.TechnologyDataExchange Cu10 { get; set; } = new axosimple.Cu10.TechnologyDataExchange();
        }
    }
}
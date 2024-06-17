using System;

namespace Pocos
{
    namespace axosimple
    {
        public partial class TechnologyCommonDataManager : AXOpen.Data.AxoDataExchange, AXSharp.Connector.IPlain
        {
            public TechnologyCommonDataManager() : base()
            {
            }

            public axosimple.TechnologyCommonData Entity { get; set; } = new axosimple.TechnologyCommonData();
        }
    }
}
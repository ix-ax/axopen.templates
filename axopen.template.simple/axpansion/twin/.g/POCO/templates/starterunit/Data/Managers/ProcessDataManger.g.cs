using System;

namespace Pocos
{
    namespace axosimple.StarterUnitTemplate
    {
        public partial class ProcessDataManager : AXOpen.Data.AxoDataFragmentExchange, AXSharp.Connector.IPlain
        {
            public ProcessDataManager() : base()
            {
            }

            public axosimple.SharedDataExchange Shared { get; set; } = new axosimple.SharedDataExchange();
            public axosimple.StarterUnitTemplate.ProcessDataExchange Data { get; set; } = new axosimple.StarterUnitTemplate.ProcessDataExchange();
        }
    }
}
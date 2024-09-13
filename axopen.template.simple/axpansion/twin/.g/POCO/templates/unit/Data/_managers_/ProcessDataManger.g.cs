using System;

namespace Pocos
{
    namespace axosimple.UnitTemplate
    {
        public partial class ProcessDataManager : AXOpen.Data.AxoDataFragmentExchange, AXSharp.Connector.IPlain
        {
            public ProcessDataManager() : base()
            {
            }

            public axosimple.SharedDataExchange Shared { get; set; } = new axosimple.SharedDataExchange();
            public axosimple.UnitTemplate.ProcessDataExchange Data { get; set; } = new axosimple.UnitTemplate.ProcessDataExchange();
        }
    }
}
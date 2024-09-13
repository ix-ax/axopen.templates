using System;

namespace Pocos
{
    namespace axosimple.MyUnit
    {
        public partial class ProcessDataManager : AXOpen.Data.AxoDataFragmentExchange, AXSharp.Connector.IPlain
        {
            public ProcessDataManager() : base()
            {
            }

            public axosimple.SharedDataExchange Shared { get; set; } = new axosimple.SharedDataExchange();
            public axosimple.MyUnit.ProcessDataExchange Data { get; set; } = new axosimple.MyUnit.ProcessDataExchange();
        }
    }
}
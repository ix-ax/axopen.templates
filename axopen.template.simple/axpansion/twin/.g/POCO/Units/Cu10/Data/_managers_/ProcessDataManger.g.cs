using System;

namespace Pocos
{
    namespace axosimple.Cu10
    {
        public partial class ProcessDataManager : AXOpen.Data.AxoDataFragmentExchange, AXSharp.Connector.IPlain
        {
            public ProcessDataManager() : base()
            {
            }

            public axosimple.SharedDataExchange Shared { get; set; } = new axosimple.SharedDataExchange();
            public axosimple.Cu10.ProcessDataExchange Data { get; set; } = new axosimple.Cu10.ProcessDataExchange();
        }
    }
}
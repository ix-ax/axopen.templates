using System;

namespace Pocos
{
    namespace axosimple
    {
        public partial class ProcessData : AXOpen.Data.AxoDataFragmentExchange, AXSharp.Connector.IPlain
        {
            public ProcessData() : base()
            {
            }

            public axosimple.SharedDataExchange Entity { get; set; } = new axosimple.SharedDataExchange();
            public axosimple.MyUnit.ProcessDataExchange MyUnit { get; set; } = new axosimple.MyUnit.ProcessDataExchange();
        }
    }
}
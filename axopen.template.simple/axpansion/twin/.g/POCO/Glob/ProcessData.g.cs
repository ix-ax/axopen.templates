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
            public axosimple.Cu10.ProcessDataExchange Cu10 { get; set; } = new axosimple.Cu10.ProcessDataExchange();
        }
    }
}
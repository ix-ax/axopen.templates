using System;

namespace Pocos
{
    namespace axosimple.UnitTemplate
    {
        public partial class FragmentProcessDataManger : AXOpen.Data.AxoDataExchange, AXSharp.Connector.IPlain
        {
            public axosimple.UnitTemplate.ProcessData Payload { get; set; } = new axosimple.UnitTemplate.ProcessData();
        }
    }
}
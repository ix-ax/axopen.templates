using System;

namespace Pocos
{
    namespace axosimple.StarterUnitTemplate
    {
        public partial class FragmentProcessDataManger : AXOpen.Data.AxoDataExchange, AXSharp.Connector.IPlain
        {
            public axosimple.StarterUnitTemplate.ProcessData Payload { get; set; } = new axosimple.StarterUnitTemplate.ProcessData();
        }
    }
}
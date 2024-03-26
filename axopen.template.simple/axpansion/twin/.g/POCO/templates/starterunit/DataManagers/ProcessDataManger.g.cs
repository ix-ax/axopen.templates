using System;

namespace Pocos
{
    namespace axosimple.StarterUnitTemplate
    {
        public partial class ProcessDataManager : AXOpen.Data.AxoDataFragmentExchange, AXSharp.Connector.IPlain
        {
            public axosimple.EntityHeaderDataManager Shared { get; set; } = new axosimple.EntityHeaderDataManager();
            public axosimple.StarterUnitTemplate.FragmentProcessDataManger DataManger { get; set; } = new axosimple.StarterUnitTemplate.FragmentProcessDataManger();
        }
    }
}
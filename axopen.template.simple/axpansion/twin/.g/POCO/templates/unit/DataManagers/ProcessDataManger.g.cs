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

            public axosimple.EntityHeaderDataManager Shared { get; set; } = new axosimple.EntityHeaderDataManager();
            public axosimple.UnitTemplate.FragmentProcessDataManger DataManger { get; set; } = new axosimple.UnitTemplate.FragmentProcessDataManger();
        }
    }
}
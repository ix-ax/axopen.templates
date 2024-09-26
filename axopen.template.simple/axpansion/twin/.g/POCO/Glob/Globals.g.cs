using System;

namespace Pocos
{
    namespace axosimple
    {
        public partial class GlobalContextObjects : AXSharp.Connector.IPlain
        {
            public GlobalContextObjects()
            {
            }

            public string LastTechnologySettings { get; set; } = string.Empty;
            public AXOpen.Data.AxoDataPersistentExchange Persits { get; set; } = new AXOpen.Data.AxoDataPersistentExchange();
            public axosimple.ProcessData PS { get; set; } = new axosimple.ProcessData();
            public axosimple.TechnologyData TS { get; set; } = new axosimple.TechnologyData();
            public axosimple.ProcessData PD { get; set; } = new axosimple.ProcessData();
        }
    }
}
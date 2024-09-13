using System;
using Pocos.AXOpen.Core;
using Pocos.AXOpen.Data;

namespace Pocos
{
    namespace axosimple
    {
        public partial class Context : AXOpen.Core.AxoContext, AXSharp.Connector.IPlain
        {
            public Context() : base()
            {
            }

            public axosimple.GlobalContextObjects Glob { get; set; } = new axosimple.GlobalContextObjects();
            public axosimple.TechnologySafety Safety { get; set; } = new axosimple.TechnologySafety();
            public axosimple.UnitTemplate.Unit UnitTemplate { get; set; } = new axosimple.UnitTemplate.Unit();
        }

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

        public partial class ProcessData : AXOpen.Data.AxoDataFragmentExchange, AXSharp.Connector.IPlain
        {
            public ProcessData() : base()
            {
            }

            public axosimple.SharedDataExchange Entity { get; set; } = new axosimple.SharedDataExchange();
            public axosimple.UnitTemplate.ProcessDataExchange UnitTemplate { get; set; } = new axosimple.UnitTemplate.ProcessDataExchange();
        }

        public partial class TechnologyData : AXOpen.Data.AxoDataFragmentExchange, AXSharp.Connector.IPlain
        {
            public TechnologyData() : base()
            {
            }

            public axosimple.TechnologySharedDataExchange Common { get; set; } = new axosimple.TechnologySharedDataExchange();
            public axosimple.UnitTemplate.TechnologyDataExchange UnitTemplate { get; set; } = new axosimple.UnitTemplate.TechnologyDataExchange();
        }
    }
}
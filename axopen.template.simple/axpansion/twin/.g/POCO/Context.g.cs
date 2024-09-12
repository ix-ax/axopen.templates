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

            public axosimple.TechnologyData TechnologySettings { get; set; } = new axosimple.TechnologyData();
            public axosimple.ProcessData ProcessSettings { get; set; } = new axosimple.ProcessData();
            public axosimple.ProcessData ProcessData { get; set; } = new axosimple.ProcessData();
            public AXOpen.Data.AxoDataPersistentExchange PersistentData { get; set; } = new AXOpen.Data.AxoDataPersistentExchange();
            public axosimple.GlobalContextObjects GlobalObjects { get; set; } = new axosimple.GlobalContextObjects();
            public axosimple.TechnologySafety Safety { get; set; } = new axosimple.TechnologySafety();
            public axosimple.StarterUnitTemplate.Unit StarterUnitTemplate { get; set; } = new axosimple.StarterUnitTemplate.Unit();
            public axosimple.UnitTemplate.Unit UnitTemplate { get; set; } = new axosimple.UnitTemplate.Unit();
        }

        public partial class GlobalContextObjects : AXSharp.Connector.IPlain
        {
            public GlobalContextObjects()
            {
            }

            public string LastTechnologySettings { get; set; } = string.Empty;
        }

        public partial class ProcessData : AXOpen.Data.AxoDataFragmentExchange, AXSharp.Connector.IPlain
        {
            public ProcessData() : base()
            {
            }

            public axosimple.SharedDataExchange Entity { get; set; } = new axosimple.SharedDataExchange();
            public axosimple.UnitTemplate.FragmentProcessDataManger UnitTemplate { get; set; } = new axosimple.UnitTemplate.FragmentProcessDataManger();
            public axosimple.StarterUnitTemplate.ProcessDataExchange StarterUnitTemplate { get; set; } = new axosimple.StarterUnitTemplate.ProcessDataExchange();
        }

        public partial class TechnologyData : AXOpen.Data.AxoDataFragmentExchange, AXSharp.Connector.IPlain
        {
            public TechnologyData() : base()
            {
            }

            public axosimple.TechnologySharedDataExchange Common { get; set; } = new axosimple.TechnologySharedDataExchange();
            public axosimple.UnitTemplate.FragmentTechnologyDataManger UnitTemplate { get; set; } = new axosimple.UnitTemplate.FragmentTechnologyDataManger();
            public axosimple.StarterUnitTemplate.TechnologyDataExchange StarterUnitTemplate { get; set; } = new axosimple.StarterUnitTemplate.TechnologyDataExchange();
        }
    }
}
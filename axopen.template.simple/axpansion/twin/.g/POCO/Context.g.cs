using System;

namespace Pocos
{
    using AXOpen.Core;
    using AXOpen.Data;

    namespace axosimple
    {
        public partial class Context : AXOpen.Core.AxoContext, AXSharp.Connector.IPlain
        {
            public axosimple.TechnologyData TechnologySettings { get; set; } = new axosimple.TechnologyData();
            public axosimple.ProcessData ProcessSettings { get; set; } = new axosimple.ProcessData();
            public axosimple.ProcessData ProcessData { get; set; } = new axosimple.ProcessData();
            public AXOpen.Data.AxoDataPersistentExchange PersistentData { get; set; } = new AXOpen.Data.AxoDataPersistentExchange();
            public axosimple.GlobalContextObjects GlobalObjects { get; set; } = new axosimple.GlobalContextObjects();
            public axosimple.TechnologySafety Safety { get; set; } = new axosimple.TechnologySafety();
            public axosimple.StarterUnitTemplate.Unit StarterUnitTemplate { get; set; } = new axosimple.StarterUnitTemplate.Unit();
            public axosimple.StarterUnitTemplate.Components StarterUnitTemplateComponents { get; set; } = new axosimple.StarterUnitTemplate.Components();
            public axosimple.StarterUnitTemplate.ProcessDataManager StarterUnitTemplateProcessData { get; set; } = new axosimple.StarterUnitTemplate.ProcessDataManager();
            public axosimple.StarterUnitTemplate.TechnologyDataManager StarterUnitTemplateTechnologySettings { get; set; } = new axosimple.StarterUnitTemplate.TechnologyDataManager();
            public axosimple.UnitTemplate.Unit UnitTemplate { get; set; } = new axosimple.UnitTemplate.Unit();
            public axosimple.UnitTemplate.Components UnitTemplateComponents { get; set; } = new axosimple.UnitTemplate.Components();
            public axosimple.UnitTemplate.ProcessDataManager UnitTemplateProcessData { get; set; } = new axosimple.UnitTemplate.ProcessDataManager();
            public axosimple.UnitTemplate.TechnologyDataManager UnitTemplateTechnologySettings { get; set; } = new axosimple.UnitTemplate.TechnologyDataManager();
        }

        public partial class GlobalContextObjects : AXSharp.Connector.IPlain
        {
            public string LastTechnologySettings { get; set; } = string.Empty;
        }

        public partial class ProcessData : AXOpen.Data.AxoDataFragmentExchange, AXSharp.Connector.IPlain
        {
            public axosimple.EntityHeaderDataManager Entity { get; set; } = new axosimple.EntityHeaderDataManager();
            public axosimple.UnitTemplate.FragmentProcessDataManger UnitTemplate { get; set; } = new axosimple.UnitTemplate.FragmentProcessDataManger();
            public axosimple.StarterUnitTemplate.FragmentProcessDataManger StarterUnitTemplate { get; set; } = new axosimple.StarterUnitTemplate.FragmentProcessDataManger();
        }

        public partial class TechnologyData : AXOpen.Data.AxoDataFragmentExchange, AXSharp.Connector.IPlain
        {
            public axosimple.TechnologyCommonDataManager Common { get; set; } = new axosimple.TechnologyCommonDataManager();
            public axosimple.UnitTemplate.FragmentTechnologyDataManger UnitTemplate { get; set; } = new axosimple.UnitTemplate.FragmentTechnologyDataManger();
            public axosimple.StarterUnitTemplate.FragmentTechnologyDataManger StarterUnitTemplate { get; set; } = new axosimple.StarterUnitTemplate.FragmentTechnologyDataManger();
        }
    }
}
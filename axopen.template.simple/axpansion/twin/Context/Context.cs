using System;
using AXOpen.Base.Data;
using AXOpen.Data;
using AXOpen.Data.MongoDb;
using axosimple.server.Units;

namespace axosimple
{
    public class ContextService
    {
        
        private static readonly Lazy<ContextService> lazy = new(() => new ContextService());

        public static ContextService Instance => lazy.Value;
        
        private ContextService()
        {
            SetContextData();
            Entry.Plc.Context.Glob.Persits.InitializeRemoteDataExchange(Entry.Plc.Context, Repository.Factory<AXOpen.Data.PersistentRecord>(new MongoDbRepositorySettings<PersistentRecord>(DataBaseConnectionString, DataBaseName, "Persistent_Data")));
        }

        private axosimple.Context Context { get; } = Entry.Plc.Context;
        
        public axosimple.ProcessData ProcessData { get; } = Entry.Plc.Context.Glob.PD.CreateDataFragments<axosimple.ProcessData>();
        public axosimple.ProcessData ProcessSettings { get; } = Entry.Plc.Context.Glob.PS.CreateDataFragments<axosimple.ProcessData>();
        public axosimple.TechnologyData TechnologySettings { get; } = Entry.Plc.Context.Glob.TS.CreateDataFragments<axosimple.TechnologyData>();

        public static string DataBaseConnectionString { get; } = "mongodb://localhost:27017";
        public static string DataBaseName { get; } = "axosimple";


        /// <summary>
        /// repository - settings connected with specific recepie
        /// </summary>
        public IRepository<Pocos.axosimple.TechnologySharedDataPayload> TechnologyCommonRepository { get; } 
            = new MongoDbRepositorySettings<Pocos.axosimple.TechnologySharedDataPayload>(DataBaseConnectionString, DataBaseName, 
                "TechnologyCommon_Settings")
                .Factory<Pocos.axosimple.TechnologySharedDataPayload>();

        /// <summary>
        /// repository - settings connected with specific recepie
        /// </summary>
        public IRepository<Pocos.axosimple.SharedDataPayload> EntitySettingsRepository { get; } 
            = new MongoDbRepositorySettings<Pocos.axosimple.SharedDataPayload>(DataBaseConnectionString, DataBaseName, 
                "Entity_Settings")
                .Factory<Pocos.axosimple.SharedDataPayload>();

        /// <summary>
        /// repository - data connected with specific part or piece in production/technology
        /// </summary>
        public IRepository<Pocos.axosimple.SharedDataPayload> EntityDataRepository { get; } =
            new MongoDbRepositorySettings<Pocos.axosimple.SharedDataPayload>(DataBaseConnectionString, DataBaseName, 
                "Entity_Data")
                .Factory();

        public ContextService SetContextData()
        {
           
            ProcessSettings.Entity.InitializeRemoteDataExchange(this.EntitySettingsRepository);
            ProcessSettings.InitializeRemoteDataExchange();

           
            ProcessData.Entity.InitializeRemoteDataExchange(this.EntityDataRepository);
            ProcessData.InitializeRemoteDataExchange();

           
            TechnologySettings.Common.InitializeRemoteDataExchange(this.TechnologyCommonRepository);
            TechnologySettings.InitializeRemoteDataExchange();

            return this;
        }
    }
}
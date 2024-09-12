using System.Runtime.CompilerServices;
using AXOpen.Base.Data;
using AXOpen.Data;
using AXOpen.Data.MongoDb;
using AXOpen.Messaging.Static;
using axosimple.BaseUnit;
using axosimple.server.Units;
using AXSharp.Connector;


namespace axosimple.StarterUnitTemplate
{
    public partial class Unit 
    {
        ///<inheritdoc/>
        public override AxoDataEntity? Data => this.X.PD.Data.Payload;
        
        ///<inheritdoc/>
        public override AxoDataEntity? DataHeader => this.X.PD.Shared.Payload;
        
        ///<inheritdoc/>
        public override AxoDataEntity? TechnologySettings => this.X.TD.Shared.Payload;

        ///<inheritdoc/>
        public override AxoDataEntity? SharedTechnologySettings => this.X.TD.Data.Payload;

        ///<inheritdoc/>
        public override AxoObject? UnitComponents => this.X.C;

        public override ITwinObject[] Associates => new ITwinObject[]
        {
            Entry.Plc.Context.StarterUnitTemplate,
            Entry.Plc.Context.Safety.Zone_1,
            Entry.Plc.Context.Safety.Zone_2
        };

        private AxoMessageProvider _messageProvider;
        private UnitServices _services;

        public override AxoTask AutomatTask => this.Auto;
        
        public override AxoTask GroundTask => this.Ground;
        
        public override AxoTask ServiceTask => this.Service;
        
        public override AxoMessageProvider MessageProvider
        {
            get
            {
                if (_messageProvider == null)
                {
                    _messageProvider = AxoMessageProvider.Create(Associates);
                }

                return _messageProvider;
            }
        }
    }
    
    public class UnitServices : IUnitServices
    {
        internal UnitServices(ContextService contextService)
        {
            _contextService = contextService;
        }
        
        public UnitBase Unit { get; } = Entry.Plc.Context.StarterUnitTemplate;
        
        /// <summary>
        /// Gets context service.
        /// </summary>
        private ContextService _contextService { get; }

        /// <summary>
        /// Gets repository for technology settings.
        /// </summary>
        public IRepository<Pocos.axosimple.StarterUnitTemplate.TechnologyDataPayload> TechnologySettingsRepository { get; } 
            = new MongoDbRepositorySettings<Pocos.axosimple.StarterUnitTemplate.TechnologyDataPayload>(
                ContextService.DataBaseConnectionString, ContextService.DataBaseName, 
                "StarterUnitTemplate_TechnologySettings").Factory();

        /// <summary>
        /// Gets repository for process settings.
        /// </summary>
        public IRepository<Pocos.axosimple.StarterUnitTemplate.ProcessDataPayload> ProcessSettingsRepository { get; } 
            = new MongoDbRepositorySettings<Pocos.axosimple.StarterUnitTemplate.ProcessDataPayload>(
                ContextService.DataBaseConnectionString, ContextService.DataBaseName, 
                "StarterUnitTemplate_ProcessSettings").Factory();

        /// <summary>
        /// Gets repository for process/production data.
        /// </summary>
        public IRepository<Pocos.axosimple.StarterUnitTemplate.ProcessDataPayload> ProcessDataRepository { get; } 
            = new MongoDbRepositorySettings<Pocos.axosimple.StarterUnitTemplate.ProcessDataPayload>(
                ContextService.DataBaseConnectionString, ContextService.DataBaseName,
                "StarterUnitTemplate_ProcessData").Factory();


        public static UnitServices Create(ContextService contextService)
        {
            var retVal = new UnitServices(contextService);
            retVal.Unit.Services = retVal;
            retVal.InitializeDataExchange();
            return retVal;
        }

        private void InitializeDataExchange()
        {
            // initialize partial repositories in global context
            _contextService.TechnologySettings.StarterUnitTemplate.InitializeRemoteDataExchange(TechnologySettingsRepository);
            _contextService.ProcessSettings.StarterUnitTemplate.InitializeRemoteDataExchange(ProcessSettingsRepository);
            _contextService.ProcessData.StarterUnitTemplate.InitializeRemoteDataExchange(ProcessDataRepository);

            // initialize unit process data manager
            var processDataManager = Entry.Plc.Context.StarterUnitTemplate.X.PD.CreateDataFragments<ProcessDataManager>()!;
            processDataManager.Shared.InitializeRemoteDataExchange(_contextService.EntityDataRepository);
            processDataManager.Data.InitializeRemoteDataExchange(ProcessDataRepository);
            processDataManager.InitializeRemoteDataExchange();
            
            // initialize unit technology data manager
            
            var technologyDataManager = Entry.Plc.Context.StarterUnitTemplate.X.TD.CreateDataFragments<TechnologyDataManager>();
            technologyDataManager.Shared.InitializeRemoteDataExchange(_contextService.TechnologyCommonRepository);
            technologyDataManager.Data.InitializeRemoteDataExchange(TechnologySettingsRepository);
            technologyDataManager.InitializeRemoteDataExchange();
        }
    }
}

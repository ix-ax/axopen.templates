using System.Runtime.CompilerServices;
using AXOpen.Base.Data;
using AXOpen.Data;
using AXOpen.Data.MongoDb;
using AXOpen.Messaging.Static;
using axosimple.BaseUnit;
using axosimple.server.Units;
using AXSharp.Connector;


namespace axosimple.UnitTemplate
{
    public partial class Unit 
    {
        ///<inheritdoc/>
        public override AxoDataEntity? Data => this.X.PD.Data.Payload;
        
        ///<inheritdoc/>
        public override AxoDataEntity? DataHeader => this.X.PD.Shared.Payload;
        
        ///<inheritdoc/>
        public override AxoDataEntity? TechnologySettings => this.X.TD.Data.Payload;

        ///<inheritdoc/>
        public override AxoDataEntity? SharedTechnologySettings => this.X.TD.Shared.Payload;

        ///<inheritdoc/>
        public override AxoObject? UnitComponents => this.X.C;

        public override ITwinObject[] Associates => new ITwinObject[]
        {
            Entry.Plc.Context.UnitTemplate,
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
        
        public UnitBase Unit { get; } = Entry.Plc.Context.UnitTemplate;
        
        /// <summary>
        /// Gets context service.
        /// </summary>
        private ContextService _contextService { get; }

        /// <summary>
        /// Gets repository for technology settings.
        /// </summary>
        public IRepository<Pocos.axosimple.UnitTemplate.TechnologyDataPayload> TechnologySettingsRepository { get; } 
            = new MongoDbRepositorySettings<Pocos.axosimple.UnitTemplate.TechnologyDataPayload>(
                ContextService.DataBaseConnectionString, ContextService.DataBaseName, 
                "UnitTemplate_TechnologySettings").Factory();

        /// <summary>
        /// Gets repository for process settings.
        /// </summary>
        public IRepository<Pocos.axosimple.UnitTemplate.ProcessDataPayload> ProcessSettingsRepository { get; } 
            = new MongoDbRepositorySettings<Pocos.axosimple.UnitTemplate.ProcessDataPayload>(
                ContextService.DataBaseConnectionString, ContextService.DataBaseName, 
                "UnitTemplate_ProcessSettings").Factory();

        /// <summary>
        /// Gets repository for process/production data.
        /// </summary>
        public IRepository<Pocos.axosimple.UnitTemplate.ProcessDataPayload> ProcessDataRepository { get; } 
            = new MongoDbRepositorySettings<Pocos.axosimple.UnitTemplate.ProcessDataPayload>(
                ContextService.DataBaseConnectionString, ContextService.DataBaseName,
                "UnitTemplate_ProcessData").Factory();


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
            _contextService.TechnologySettings.UnitTemplate.InitializeRemoteDataExchange(TechnologySettingsRepository);
            _contextService.ProcessSettings.UnitTemplate.InitializeRemoteDataExchange(ProcessSettingsRepository);
            _contextService.ProcessData.UnitTemplate.InitializeRemoteDataExchange(ProcessDataRepository);

            // initialize unit process data manager
            var processDataManager = Entry.Plc.Context.UnitTemplate.X.PD.CreateDataFragments<ProcessDataManager>()!;
            processDataManager.Shared.InitializeRemoteDataExchange(_contextService.EntityDataRepository);
            processDataManager.Data.InitializeRemoteDataExchange(ProcessDataRepository);
            processDataManager.InitializeRemoteDataExchange();
            
            // initialize unit technology data manager
            
            var technologyDataManager = Entry.Plc.Context.UnitTemplate.X.TD.CreateDataFragments<TechnologyDataManager>();
            technologyDataManager.Shared.InitializeRemoteDataExchange(_contextService.TechnologyCommonRepository);
            technologyDataManager.Data.InitializeRemoteDataExchange(TechnologySettingsRepository);
            technologyDataManager.InitializeRemoteDataExchange();
        }

        public string Link => @"/Context/UnitTemplate";
        public string ImageLink => "logo-header.svg";
        
    }
}

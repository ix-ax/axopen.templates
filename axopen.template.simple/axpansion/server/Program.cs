using AxOpen.Security;
using AxOpen.Security.Entities;
using AxOpen.Security.Services;
using AXOpen;
using AXOpen.Base.Data;
using AXOpen.Core;
using AXOpen.Core.Blazor.AxoDialogs.Hubs;
using AXOpen.Data;
using AXOpen.Logging;
using axosimple;
using AXOpen.Data.MongoDb;
using axosimple.server.Units;
using AXSharp.Connector;
using AXSharp.Presentation.Blazor.Services;
using Serilog;
using System.Reflection;
using AXOpen.VisualComposer;
using Microsoft.Extensions.Options;
using MongoDB.Bson.Serialization;
using System.Diagnostics;
using System.Runtime.InteropServices.JavaScript;
using AXOpen.VisualComposer;
using axosimple.BaseUnit;
using System.Net;
using AXOpen.VisualComposer.Types;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigureAxBlazorSecurity(SetUpUserRepositories(), Roles.CreateRoles(),true);
builder.Services.AddLocalization();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddIxBlazorServices();
builder.Services.AddAxoCoreServices();
builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();

builder.Services.AddVisualComposerService();

#region AxoApplication

Entry.Plc.Connector.SubscriptionMode = ReadSubscriptionMode.Polling;
Entry.Plc.Connector.BuildAndStart().ReadWriteCycleDelay = 50;
Entry.Plc.Connector.ConcurrentRequestMaxCount = 3;
Entry.Plc.Connector.ConcurrentRequestDelay = 25;
Entry.Plc.Connector.ExceptionBehaviour = CommExceptionBehaviour.Ignore;


Entry.Plc.Connector.SetLoggerConfiguration(new LoggerConfiguration()
    .WriteTo
    .Console()
    .WriteTo
    .File($"connector.log",
        outputTemplate: "{Timestamp:yyyy-MMM-dd HH:mm:ss} [{Level}] {Message}{NewLine}{Exception}",
        fileSizeLimitBytes: 100000)
    .MinimumLevel.Information()
    .CreateLogger());

await Entry.Plc.Connector.IdentityProvider.ConstructIdentitiesAsync();

AxoApplication.CreateBuilder().ConfigureLogger(new SerilogLogger(new LoggerConfiguration()
    .WriteTo.Console().MinimumLevel.Information()
    .CreateLogger()));

//Entry.Plc.ContextLogger.StartDequeuing(AxoApplication.Current.Logger, 250);

// Register the unit services
CreateUnitServices();

// Clean Temp directory
IAxoDataExchange.CleanUp();

#endregion AxoApplication


await Entry.Plc.Context.TimeSynch.SetAsync(DateTime.UtcNow);
await Entry.Plc.Context.DoSynchronize.SetAsync(true);


var app = builder.Build();

builder.WebHost.UseUrls("http://*:5262;https://*:7292");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // use response compression only in production mode
    app.UseResponseCompression();
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

var supportedCultures = new[] { "en-US", "sk-SK", "es-ES" };
var localizationOptions = new RequestLocalizationOptions()
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

app.UseRequestLocalization(localizationOptions);

app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapHub<SignalRDialogHub>("/dialoghub");
app.MapFallbackToPage("/_Host");

app.Run();

static void CreateUnitServices()
{
    var contextService = ContextService.Instance;
    // axosimple.UnitTemplate.UnitServices.Create(ContextService.Instance); 

    Assembly? assembly = Assembly.GetAssembly(typeof(axosimpleTwinController));


    if (contextService != null && assembly != null)
    {
        IEnumerable<Type> unitServices = assembly.GetTypes().Where(t => typeof(IUnitServices).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract);

        foreach (Type unitService in unitServices)
        {
            if (unitService.FullName != null)
            {
                Type classType = assembly.GetType(unitService.FullName);
                if (classType != null)
                {
                    MethodInfo? createMethod = classType.GetMethod("Create", BindingFlags.Public | BindingFlags.Static);
                    if (createMethod != null)
                    {
                        createMethod.Invoke(null, new object[] { contextService });
                    }
                }
            }
        }
    }
}

static async void CreateDefaultUnitsView()
{
    List<ITwinObject> CUs = Entry.Plc.Context.GetChildren().Where(o => o is UnitContainerBase).ToList();
    if (CUs != null && CUs.Count() > 0)
    {
        VisualComposerContainer VisualComposerContainer = new VisualComposerContainer();
        VisualComposerContainer.Id = "ContextView";
        VisualComposerContainer.FileName = "_generated";
        VisualComposerContainer.CurrentView = "_generated";
        VisualComposerContainer.BackgroundWidth = 100;
        VisualComposerContainer.BackgroundHeight = 200;
        VisualComposerContainer.ImgSrc = null;
        VisualComposerContainer.BackgroundColor = "#027dfb";
        VisualComposerContainer.BackgroundSVGInput = "";
        double left = 1;
        double top = 1;
        TransformType transform = TransformType.TopLeft;

        foreach (ITwinObject CU in CUs)
        {
            VisualComposerContainer.AddChildren(CU as ITwinElement, left, top, TransformType.TopLeft, "Spot", -1, -1, 10, 1, "", null, true, "#FFFFFF");
            left = left + 25;
            if (left > 76)
            {
                left = 1;
                top = top + 13;
            }

        }
        await VisualComposerContainer.SaveAsync();
    }
}


static (IRepository<User>, IRepository<Group>) SetUpUserRepositories()
{
    var MongoConnectionString = "mongodb://localhost:27017";
    var MongoDatabaseName = "axosimple";
    
    IRepository<User> userRepo      = Repository.Factory<User>(new MongoDbRepositorySettings<User>(MongoConnectionString, MongoDatabaseName, "Users", idExpression: t => t.Id));
    IRepository<Group> groupRepo    = Repository.Factory<Group>(new MongoDbRepositorySettings<Group>(MongoConnectionString, MongoDatabaseName, "Groups"));
    return (userRepo, groupRepo);
}

public static class Roles
{
    public static List<Role> CreateRoles()
    {
        var roles = new List<Role>
        {
            new Role(process_settings_access),
            new Role(process_traceability_access),
            new Role(can_run_ground_mode),
            new Role(can_run_automat_mode),
            new Role(can_run_service_mode),
            new Role(can_skip_steps_in_sequence),
            new Role(can_access_menu),
            new Role(can_access_process_settings),
            new Role(can_access_technological_settings),
            new Role(can_access_process_data)
        };

        return roles;
    }

    public const string can_run_ground_mode = nameof(can_run_ground_mode);
    public const string can_run_automat_mode = nameof(can_run_automat_mode);
    public const string can_run_service_mode = nameof(can_run_service_mode);
    public const string process_settings_access = nameof(process_settings_access);
    public const string process_traceability_access = nameof(process_traceability_access);
    public const string can_skip_steps_in_sequence = nameof(can_skip_steps_in_sequence);
    public const string can_access_menu = nameof(can_access_menu);
    public const string can_access_process_settings = nameof(can_access_process_settings);
    public const string can_access_technological_settings = nameof(can_access_technological_settings);
    public const string can_access_process_data =  nameof(can_access_process_data);
}
using BlueWhatsapp.Api.Extensions;
using BlueWhatsapp.Api.Hubs;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Utils;

var builder = WebApplication.CreateBuilder(args);
const string myAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myAllowSpecificOrigins, policy =>
    {
        policy
            .AllowAnyHeader()
            .AllowAnyOrigin()
            .AllowAnyMethod();
    });
});

builder.Services.AddMvc();
builder.Services.AddSignalR()
    .AddJsonProtocol(options =>
    {
        options.PayloadSerializerOptions.PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase;
    });

builder.Services.AddControllers();

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
    options.Cookie.Name = ".BlueWhatsapp.Session";
    options.Cookie.SecurePolicy = CookieSecurePolicy.None;
    options.Cookie.SameSite = SameSiteMode.Lax;
});

builder.ConfigureCronSchedulerJobs();
builder.ConfigureStateMachineNodes();
builder.ConfigurePersistenceServices();
builder.ConfigureSingletonServices();
builder.ConfigureSwaggerServices();
builder.ConfigureDomainServices();

WebApplication app = builder.Build();

// Initialize the ServiceLocator BEFORE any request is processed
// IMPORTANT: Use the root service provider to get the IServiceScopeFactory
// This ensures the IServiceScopeFactory won't be disposed
var logger = app.Services.GetRequiredService<IAppLogger>();
var serviceScopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
ServiceLocator.Initialize(serviceScopeFactory, logger);

using (IServiceScope? serviceScope = app.Services.CreateScope())
{
    IServiceProvider? services = serviceScope.ServiceProvider;
    IAppLogger appLogger = services.GetRequiredService<IAppLogger>();
    app.ConfigureExceptionHandler(appLogger);
}

app.MigrateDatabase();
app.UseStaticFiles();
app.ConfigureSwaggerUIOnDevelopment();
app.UseHttpsRedirection();
app.UseCors(myAllowSpecificOrigins);
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseSession();
app.MapControllerRoute(name: "default", pattern: "{controller}/{action=Index}/{id?}");
app.MapHubs();

app.Run();

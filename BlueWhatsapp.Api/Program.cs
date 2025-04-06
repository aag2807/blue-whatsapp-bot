using BlueWhatsapp.Api.Extensions;
using BlueWhatsapp.Api.Hubs;
using BlueWhatsapp.Core.Logger;

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

// builder.ConfigureAutoMapperProfiles();
builder.Services.AddMvc();
builder.Services.AddSignalR();

// builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.ConfigureCronSchedulerJobs();
builder.ConfigurePersistenceServices();
builder.ConfigureSingletonServices();
builder.ConfigureSwaggerServices();
builder.ConfigureDomainServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    // app.MapOpenApi();
}

using (IServiceScope? serviceScope = app.Services.CreateScope())
{
    IServiceProvider? services = serviceScope.ServiceProvider;
    IAppLogger appLogger = services.GetRequiredService<IAppLogger>();
    app.ConfigureExceptionHandler(appLogger);
}

app.UseStaticFiles();
app.ConfigureSwaggerUIOnDevelopment();
app.UseHttpsRedirection();
app.UseCors(myAllowSpecificOrigins);
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(name: "default", pattern: "{controller}/{action=Index}/{id?}");
app.MapHub<MessagesHub>("/messages");

app.Run();

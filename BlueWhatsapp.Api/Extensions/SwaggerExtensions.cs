using Microsoft.OpenApi.Models;

namespace BlueWhatsapp.Api.Extensions;

internal static class SwaggerExtensions
{
        internal static void ConfigureSwaggerServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Whatsapp API",
                    Version = "v1",
                    Description = "API para conectarse con whatsapp",
                    Contact = new OpenApiContact
                    {
                        Name = "Equipo de Gestion",
                        Email = "aagn2807@gmail.com"
                    }
                });
                c.AddServer(new OpenApiServer { Url = "/" });
            });
        }
    
        internal static void ConfigureSwaggerUIOnDevelopment(this WebApplication app)
        {
            app.UseSwagger(c =>
            {
                c.SerializeAsV2 = false;
            });
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Whatsapp API V1");
                c.RoutePrefix = string.Empty;
            });
        }
}
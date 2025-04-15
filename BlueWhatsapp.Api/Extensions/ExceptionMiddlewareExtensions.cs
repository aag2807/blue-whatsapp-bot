using System.Net;
using BlueWhatsapp.Core.Logger;
using Microsoft.AspNetCore.Diagnostics;

namespace BlueWhatsapp.Api.Extensions;

internal static class ExceptionMiddlewareExtensions
{
    private const string DefaultErrorMessage = "Ocurrió un error procesando la información, Favor contactar con su administrador.";
    private const string ContentType = "application/json";

    internal static void ConfigureExceptionHandler(this IApplicationBuilder app, IAppLogger appLogger)
    {
        app.UseExceptionHandler(appError =>
        {
            appError.Run(async context =>
            {
                context.Response.ContentType = ContentType;
                var contextFeature = context.Features.Get<IExceptionHandlerFeature>();

                if (contextFeature == null)
                {
                    await BuildResponse(context, (int)HttpStatusCode.InternalServerError, DefaultErrorMessage,
                        appLogger).ConfigureAwait(false);
                    return;
                }

                (int statusCode, string message) = contextFeature.Error switch
                {
                    ArgumentOutOfRangeException argumentOutOfRangeException => (400,
                        argumentOutOfRangeException.Message),
                    ArgumentException argumentException => (400, argumentException.Message),
                    InvalidOperationException invalidOperationException => (400, invalidOperationException.Message),
                    FormatException formatException => (400, formatException.Message),
                    _ => (500, DefaultErrorMessage)
                };

                appLogger.LogError(new { Message = contextFeature.Error.Message });
                appLogger.LogError( contextFeature.Error );
                appLogger.LogError( contextFeature.Error.StackTrace );
                appLogger.LogError( contextFeature.Error.Message );
                await BuildResponse(context, statusCode, message, appLogger).ConfigureAwait(false);
            });
        });
    }

    private static async Task BuildResponse(HttpContext context, int statusCode, string message, IAppLogger appLogger)
    {
        context.Response.StatusCode = (int)HttpStatusCode.OK;
        await context.Response.WriteAsync("EVENT_RECEIVED");
        appLogger.LogError(new { Message = message, StatusCode = statusCode, Type = "Response" });
    }
}
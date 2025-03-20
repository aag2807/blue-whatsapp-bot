using System.Text;
using BlueWhatsapp.Core.Logger;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BlueWhatsapp.Api.Utils;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
public class LogActionAttribute : Attribute, IAsyncActionFilter
{
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        var logger = context.HttpContext.RequestServices.GetRequiredService<IAppLogger>();

        string? ipAddress = context.HttpContext.Connection.RemoteIpAddress?.ToString();

        string route = context.HttpContext.Request.Path;

        string httpMethod = context.HttpContext.Request.Method;

        logger.LogInfo(new
        {
            Message = "Request received",
            Route = route,
            HttpMethod = httpMethod,
            IPAddress = ipAddress
        });

        if (context.HttpContext.Request.Body.CanRead)
        {
            context.HttpContext.Request.EnableBuffering();
            using var reader = new StreamReader(context.HttpContext.Request.Body, Encoding.UTF8, true, 1024, true);
            var body = await reader.ReadToEndAsync();
            context.HttpContext.Request.Body.Position = 0;

            if (!string.IsNullOrEmpty(body))
            {
                logger.LogInfo(new
                {
                    Message = "Request body",
                    Body = body
                });
            }
        }

        var resultContext = await next();

        if (resultContext.Result is ObjectResult objectResult)
        {
            logger.LogInfo(new
            {
                Message = "Response sent",
                Response = objectResult.Value
            });
        }
    }
}
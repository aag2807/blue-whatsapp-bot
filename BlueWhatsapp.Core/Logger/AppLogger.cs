using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlueWhatsapp.Core.Logger;

/// <summary>
/// The logger for the application
/// </summary>
public class AppLogger : IAppLogger
{
    private readonly string _logDirectory;

    public AppLogger(string rootDirectory)
    {
        _logDirectory = Path.Combine(rootDirectory, "logs");
        if (!Directory.Exists(_logDirectory))
        {
            Directory.CreateDirectory(_logDirectory);
        }
    }

    private string GetLogFilePath(string logType)
    {
        string dateSubdirectory = DateTime.Now.ToString("dd-MM-yy");
        string logSubdirectory = Path.Combine(_logDirectory, dateSubdirectory);

        if (!Directory.Exists(logSubdirectory))
        {
            Directory.CreateDirectory(logSubdirectory);
        }

        return Path.Combine(logSubdirectory, $"{logType}.txt");
    }

    private void WriteLog<T>(string logType, T data)
    {
        try
        {
            string logFilePath = GetLogFilePath(logType);
            string logMessage;

            // Special handling for exceptions
            if (data is Exception exception)
            {
                var exceptionData = new
                {
                    ExceptionType = exception.GetType().Name,
                    Message = exception.Message,
                    StackTrace = exception.StackTrace,
                    Source = exception.Source,
                    InnerException = exception.InnerException?.Message
                };

                string jsonData = JsonSerializer.Serialize(exceptionData, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                logMessage = $"[{DateTime.Now}] {jsonData}{Environment.NewLine} {Environment.NewLine}";
            }
            else
            {
                string jsonData = JsonSerializer.Serialize(data, new JsonSerializerOptions
                {
                    WriteIndented = true,
                    ReferenceHandler = ReferenceHandler.IgnoreCycles,
                    IgnoreReadOnlyProperties = true
                });

                logMessage = $"[{DateTime.Now}] {jsonData}{Environment.NewLine} {Environment.NewLine}";
            }

            File.AppendAllText(logFilePath, logMessage);
        }
        catch (Exception ex)
        {
            // Avoid recursion by using a simple file write for logger errors
            try
            {
                string emergencyLogPath = Path.Combine(_logDirectory, "logger_emergency.txt");
                string errorMessage = $"[{DateTime.Now}] Logger failed: {ex.GetType().Name} - {ex.Message}\nWhen logging: {data?.GetType().Name}\n\n";
                File.AppendAllText(emergencyLogPath, errorMessage);
            }
            catch
            {
                // At this point we can't do much more
            }
        }
    }

    /// <inheritdoc />
    void IAppLogger.LogInfo<T>(T data)
    {
        WriteLog("info", data);
    }

    /// <inheritdoc />
    void IAppLogger.LogError<T>(T data)
    {
        WriteLog("error", data);
    }

    /// <inheritdoc />
    void IAppLogger.LogRoutes<T>(T data)
    {
        WriteLog("routes", data);
    }

    /// <inheritdoc />
    public void LogSteps<T>(T data)
    {
        WriteLog("steps", data);
    }
}
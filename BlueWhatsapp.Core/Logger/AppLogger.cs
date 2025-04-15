using System.Text.Json;

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
        string logFilePath = GetLogFilePath(logType);

        string jsonData = JsonSerializer.Serialize(data, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        string logMessage = $"[{DateTime.Now}] {jsonData}{Environment.NewLine} {Environment.NewLine}";

        File.AppendAllText(logFilePath, logMessage);
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
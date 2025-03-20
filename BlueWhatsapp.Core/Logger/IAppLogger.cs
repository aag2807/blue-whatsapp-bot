namespace BlueWhatsapp.Core.Logger;

/// <summary>
/// The internal logger that handles logs inside the 3 corresponding files
/// </summary>
public interface IAppLogger
{
    /// <summary>
    /// Logs into the info.txt file
    /// </summary>
    void LogInfo<T>(T data);
    
    /// <summary>
    /// Logs into the error.txt file
    /// </summary>
    void LogError<T>(T data);
    
    /// <summary>
    /// Logs into the routing.txt file
    /// </summary>
    void LogRoutes<T>(T data);
}
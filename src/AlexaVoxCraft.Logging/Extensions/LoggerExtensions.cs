using Microsoft.Extensions.Logging;

namespace AlexaVoxCraft.Logging.Extensions;

public static class LoggerExtensions
{
    #region Debug Methods

    public static void Debug(this ILogger logger, string? message)
    {
        logger.LogMessage(LogLevel.Debug, null, message);
    }

    public static void Debug<T>(this ILogger logger, string? message, T? propertyValue)
    {
        logger.LogMessage<T>(LogLevel.Debug, null, message, propertyValue);
    }

    public static void Debug<T0, T1>(this ILogger logger, string? message, T0? propertyValue0, T1? propertyValue1)
    {
        logger.LogMessage<T0, T1>(LogLevel.Debug, null, message, propertyValue0, propertyValue1);
    }

    public static void Debug<T0, T1, T2>(this ILogger logger, string? message, T0? propertyValue0, T1? propertyValue1,
        T2? propertyValue2)
    {
        logger.LogMessage<T0, T1, T2>(LogLevel.Debug, null, message, propertyValue0, propertyValue1, propertyValue2);
    }

    public static void Debug(this ILogger logger, Exception? exception, string? message)
    {
        logger.LogMessage(LogLevel.Debug, exception, message);
    }

    public static void Debug<T>(this ILogger logger, Exception? exception, string? message, T? propertyValue)
    {
        logger.LogMessage<T>(LogLevel.Debug, exception, message, propertyValue);
    }

    public static void Debug<T0, T1>(this ILogger logger, Exception? exception, string? message, T0? propertyValue0, T1? propertyValue1)
    {
        logger.LogMessage<T0, T1>(LogLevel.Debug, exception, message, propertyValue0, propertyValue1);
    }

    public static void Debug<T0, T1, T2>(this ILogger logger, Exception? exception, string? message, T0? propertyValue0, T1? propertyValue1,
        T2? propertyValue2)
    {
        logger.LogMessage<T0, T1, T2>(LogLevel.Debug, exception, message, propertyValue0, propertyValue1, propertyValue2);
    }

    #endregion

    #region Verbose Methods

    public static void Verbose(this ILogger logger, string? message)
    {
        logger.LogMessage(LogLevel.Trace, null, message);
    }

    public static void Verbose<T>(this ILogger logger, string? message, T? propertyValue)
    {
        logger.LogMessage<T>(LogLevel.Trace, null, message, propertyValue);
    }

    public static void Verbose<T0, T1>(this ILogger logger, string? message, T0? propertyValue0, T1? propertyValue1)
    {
        logger.LogMessage<T0, T1>(LogLevel.Trace, null, message, propertyValue0, propertyValue1);
    }

    public static void Verbose<T0, T1, T2>(this ILogger logger, string? message, T0? propertyValue0, T1? propertyValue1,
        T2? propertyValue2)
    {
        logger.LogMessage<T0, T1, T2>(LogLevel.Trace, null, message, propertyValue0, propertyValue1, propertyValue2);
    }

    public static void Verbose(this ILogger logger, Exception? exception, string? message)
    {
        logger.LogMessage(LogLevel.Trace, exception, message);
    }

    public static void Verbose<T>(this ILogger logger, Exception? exception, string? message, T? propertyValue)
    {
        logger.LogMessage<T>(LogLevel.Trace, exception, message, propertyValue);
    }

    public static void Verbose<T0, T1>(this ILogger logger, Exception? exception, string? message, T0? propertyValue0, T1? propertyValue1)
    {
        logger.LogMessage<T0, T1>(LogLevel.Trace, exception, message, propertyValue0, propertyValue1);
    }

    public static void Verbose<T0, T1, T2>(this ILogger logger, Exception? exception, string? message, T0? propertyValue0, T1? propertyValue1,
        T2? propertyValue2)
    {
        logger.LogMessage<T0, T1, T2>(LogLevel.Trace, exception, message, propertyValue0, propertyValue1, propertyValue2);
    }

    #endregion
    
    #region Information Methods

    public static void Information(this ILogger logger, string? message)
    {
        logger.LogMessage(LogLevel.Information, null, message);
    }

    public static void Information<T>(this ILogger logger, string? message, T? propertyValue)
    {
        logger.LogMessage<T>(LogLevel.Information, null, message, propertyValue);
    }

    public static void Information<T0, T1>(this ILogger logger, string? message, T0? propertyValue0, T1? propertyValue1)
    {
        logger.LogMessage<T0, T1>(LogLevel.Information, null, message, propertyValue0, propertyValue1);
    }

    public static void Information<T0, T1, T2>(this ILogger logger, string? message, T0? propertyValue0, T1? propertyValue1,
        T2? propertyValue2)
    {
        logger.LogMessage<T0, T1, T2>(LogLevel.Information, null, message, propertyValue0, propertyValue1, propertyValue2);
    }

    public static void Information(this ILogger logger, Exception? exception, string? message)
    {
        logger.LogMessage(LogLevel.Information, exception, message);
    }

    public static void Information<T>(this ILogger logger, Exception? exception, string? message, T? propertyValue)
    {
        logger.LogMessage<T>(LogLevel.Information, exception, message, propertyValue);
    }

    public static void Information<T0, T1>(this ILogger logger, Exception? exception, string? message, T0? propertyValue0, T1? propertyValue1)
    {
        logger.LogMessage<T0, T1>(LogLevel.Information, exception, message, propertyValue0, propertyValue1);
    }

    public static void Information<T0, T1, T2>(this ILogger logger, Exception? exception, string? message, T0? propertyValue0, T1? propertyValue1,
        T2? propertyValue2)
    {
        logger.LogMessage<T0, T1, T2>(LogLevel.Information, exception, message, propertyValue0, propertyValue1, propertyValue2);
    }

    #endregion

    #region Warning Methods

    public static void Warning(this ILogger logger, string? message)
    {
        logger.LogMessage(LogLevel.Warning, null, message);
    }

    public static void Warning<T>(this ILogger logger, string? message, T? propertyValue)
    {
        logger.LogMessage<T>(LogLevel.Warning, null, message, propertyValue);
    }

    public static void Warning<T0, T1>(this ILogger logger, string? message, T0? propertyValue0, T1? propertyValue1)
    {
        logger.LogMessage<T0, T1>(LogLevel.Warning, null, message, propertyValue0, propertyValue1);
    }

    public static void Warning<T0, T1, T2>(this ILogger logger, string? message, T0? propertyValue0, T1? propertyValue1,
        T2? propertyValue2)
    {
        logger.LogMessage<T0, T1, T2>(LogLevel.Warning, null, message, propertyValue0, propertyValue1, propertyValue2);
    }

    public static void Warning(this ILogger logger, Exception? exception, string? message)
    {
        logger.LogMessage(LogLevel.Warning, exception, message);
    }

    public static void Warning<T>(this ILogger logger, Exception? exception, string? message, T? propertyValue)
    {
        logger.LogMessage<T>(LogLevel.Warning, exception, message, propertyValue);
    }

    public static void Warning<T0, T1>(this ILogger logger, Exception? exception, string? message, T0? propertyValue0, T1? propertyValue1)
    {
        logger.LogMessage<T0, T1>(LogLevel.Warning, exception, message, propertyValue0, propertyValue1);
    }

    public static void Warning<T0, T1, T2>(this ILogger logger, Exception? exception, string? message, T0? propertyValue0, T1? propertyValue1,
        T2? propertyValue2)
    {
        logger.LogMessage<T0, T1, T2>(LogLevel.Warning, exception, message, propertyValue0, propertyValue1, propertyValue2);
    }

    #endregion

    #region Error Methods

    public static void Error(this ILogger logger, string? message)
    {
        logger.LogMessage(LogLevel.Error, null, message);
    }

    public static void Error<T>(this ILogger logger, string? message, T? propertyValue)
    {
        logger.LogMessage<T>(LogLevel.Error, null, message, propertyValue);
    }

    public static void Error<T0, T1>(this ILogger logger, string? message, T0? propertyValue0, T1? propertyValue1)
    {
        logger.LogMessage<T0, T1>(LogLevel.Error, null, message, propertyValue0, propertyValue1);
    }

    public static void Error<T0, T1, T2>(this ILogger logger, string? message, T0? propertyValue0, T1? propertyValue1,
        T2? propertyValue2)
    {
        logger.LogMessage<T0, T1, T2>(LogLevel.Error, null, message, propertyValue0, propertyValue1, propertyValue2);
    }

    public static void Error(this ILogger logger, Exception? exception, string? message)
    {
        logger.LogMessage(LogLevel.Error, exception, message);
    }

    public static void Error<T>(this ILogger logger, Exception? exception, string? message, T? propertyValue)
    {
        logger.LogMessage<T>(LogLevel.Error, exception, message, propertyValue);
    }

    public static void Error<T0, T1>(this ILogger logger, Exception? exception, string? message, T0? propertyValue0, T1? propertyValue1)
    {
        logger.LogMessage<T0, T1>(LogLevel.Error, exception, message, propertyValue0, propertyValue1);
    }

    public static void Error<T0, T1, T2>(this ILogger logger, Exception? exception, string? message, T0? propertyValue0, T1? propertyValue1,
        T2? propertyValue2)
    {
        logger.LogMessage<T0, T1, T2>(LogLevel.Error, exception, message, propertyValue0, propertyValue1, propertyValue2);
    }

    #endregion

    #region Critical Methods

    public static void Critical(this ILogger logger, string? message)
    {
        logger.LogMessage(LogLevel.Critical, null, message);
    }

    public static void Critical<T>(this ILogger logger, string? message, T? propertyValue)
    {
        logger.LogMessage<T>(LogLevel.Critical, null, message, propertyValue);
    }

    public static void Critical<T0, T1>(this ILogger logger, string? message, T0? propertyValue0, T1? propertyValue1)
    {
        logger.LogMessage<T0, T1>(LogLevel.Critical, null, message, propertyValue0, propertyValue1);
    }

    public static void Critical<T0, T1, T2>(this ILogger logger, string? message, T0? propertyValue0, T1? propertyValue1,
        T2? propertyValue2)
    {
        logger.LogMessage<T0, T1, T2>(LogLevel.Critical, null, message, propertyValue0, propertyValue1, propertyValue2);
    }

    public static void Critical(this ILogger logger, Exception? exception, string? message)
    {
        logger.LogMessage(LogLevel.Critical, exception, message);
    }

    public static void Critical<T>(this ILogger logger, Exception? exception, string? message, T? propertyValue)
    {
        logger.LogMessage<T>(LogLevel.Critical, exception, message, propertyValue);
    }

    public static void Critical<T0, T1>(this ILogger logger, Exception? exception, string? message, T0? propertyValue0, T1? propertyValue1)
    {
        logger.LogMessage<T0, T1>(LogLevel.Critical, exception, message, propertyValue0, propertyValue1);
    }

    public static void Critical<T0, T1, T2>(this ILogger logger, Exception? exception, string? message, T0? propertyValue0, T1? propertyValue1,
        T2? propertyValue2)
    {
        logger.LogMessage<T0, T1, T2>(LogLevel.Critical, exception, message, propertyValue0, propertyValue1, propertyValue2);
    }

    #endregion

    #region Private Methods

    private static void LogMessage(this ILogger logger, LogLevel logLevel, Exception? exception, string? message)
    {
        if (logger.IsEnabled(logLevel))
            logger.Log(logLevel, exception, message);
    }

    private static void LogMessage<T>(this ILogger logger, LogLevel logLevel, Exception? exception, string? message,
        T? propertyValue)
    {
        if (logger.IsEnabled(logLevel))
            logger.Log(logLevel, exception, message, new object?[] { propertyValue });
    }

    private static void LogMessage<T0, T1>(this ILogger logger, LogLevel logLevel, Exception? exception,
        string? message, T0? propertyValue0, T1? propertyValue1)
    {
        if (logger.IsEnabled(logLevel))
            logger.Log(logLevel, exception, message, new object?[] { propertyValue0, propertyValue1 });
    }

    private static void LogMessage<T0, T1, T2>(this ILogger logger, LogLevel logLevel, Exception? exception,
        string? message, T0? propertyValue0, T1? propertyValue1, T2? propertyValue2)
    {
        if (logger.IsEnabled(logLevel))
            logger.Log(logLevel, exception, message, new object?[] { propertyValue0, propertyValue1, propertyValue2 });
    }


    #endregion
}
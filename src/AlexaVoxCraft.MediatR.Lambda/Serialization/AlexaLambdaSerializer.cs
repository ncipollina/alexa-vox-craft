using System.Text.Json;
using AlexaVoxCraft.MediatR.Lambda.Extensions;
using AlexaVoxCraft.Model.Serialization;
using Amazon.Lambda.Core;
using Microsoft.Extensions.Logging;
using LogLevel = Microsoft.Extensions.Logging.LogLevel;

namespace AlexaVoxCraft.MediatR.Lambda.Serialization;

public sealed class AlexaLambdaSerializer : ILambdaSerializer
{
    private readonly ILogger<AlexaLambdaSerializer> _logger;
    private readonly JsonSerializerOptions _options;

    public AlexaLambdaSerializer(ILogger<AlexaLambdaSerializer> logger, JsonSerializerOptions? jsonSerializerOptions)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _options = jsonSerializerOptions ?? AlexaJsonOptions.DefaultOptions;
    }

    public T Deserialize<T>(Stream requestStream)
    {
        return _logger.IsEnabled(LogLevel.Debug)
            ? DeserializeWithLogging<T>(requestStream)
            : JsonSerializer.Deserialize<T>(requestStream, _options)!;
    }

    private T DeserializeWithLogging<T>(Stream requestStream)
    {
        using var reader = new StreamReader(requestStream, leaveOpen: true);
        var json = reader.ReadToEnd();
        requestStream.Position = 0;

        _logger.Debug("📥 Raw JSON Input: {Json}", json);

        return JsonSerializer.Deserialize<T>(json, _options)!;
    }

    public void Serialize<T>(T response, Stream responseStream)
    {
        if (_logger.IsEnabled(LogLevel.Debug))
        {
            SerializeWithLogging(response, responseStream);
        }
        else
        {
            JsonSerializer.Serialize(responseStream, response, _options);
        }
    }
    private void SerializeWithLogging<T>(T response, Stream responseStream)
    {
        var json = JsonSerializer.Serialize(response, _options);

        _logger.Debug("📤 Serialized JSON Output: {Json}", json);

        using var writer = new StreamWriter(responseStream, leaveOpen: true);
        writer.Write(json);
        writer.Flush();
        responseStream.Position = 0;
    }

}
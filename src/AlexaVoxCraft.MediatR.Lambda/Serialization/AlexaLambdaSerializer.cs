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

    public T? Deserialize<T>(Stream requestStream)
    {
        var obj = JsonSerializer.Deserialize<T>(requestStream, _options);
        if (_logger.IsEnabled(LogLevel.Debug))
        {
            _logger.Debug("📥 Raw JSON Input: {@RawRequest}", obj);
        }

        return obj;
    }

    public void Serialize<T>(T response, Stream responseStream)
    {
        if (_logger.IsEnabled(LogLevel.Debug))
        {
            _logger.Debug("📤 Serialized JSON Output: {@RawResponse}", response);
        }

        JsonSerializer.Serialize(responseStream, response, _options);
    }
}
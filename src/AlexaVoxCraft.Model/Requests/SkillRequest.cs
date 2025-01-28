using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Requests.Types;

namespace AlexaVoxCraft.Model.Requests;

public sealed class SkillRequest
{
    [JsonPropertyName("version")]
    public required string Version { get; set; }

    [JsonPropertyName("session")]
    public required Session Session { get; set; }

    [JsonPropertyName("context")]
    public Context? Context { get; set; }
    
    [JsonPropertyName("request")]
    public required RequestType Request { get; set; }

    public System.Type? GetRequestType()
    {
        return Request?.GetType();
    }
}
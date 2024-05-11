using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Requests.Types;

namespace AlexaVoxCraft.Model.Requests;

public sealed class SkillRequest
{
    [JsonPropertyName("version")]
    public string Version { get; set; }

    [JsonPropertyName("session")]
    public Session Session { get; set; }

    [JsonPropertyName("context")]
    public Context Context { get; set; }
    
    [JsonPropertyName("request")]
    public RequestType Request { get; set; }

    public System.Type? GetRequestType()
    {
        return Request?.GetType();
    }
}
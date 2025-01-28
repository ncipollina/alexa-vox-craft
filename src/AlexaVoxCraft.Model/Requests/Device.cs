using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests;

public class Device
{
    [JsonPropertyName("deviceId")]
    public required string DeviceId { get; set; }

    [JsonPropertyName("supportedInterfaces")]
    public Dictionary<string, object>? SupportedInterfaces { get; set; }

    public bool IsInterfaceSupported(string interfaceName)
    {
        var hasInterface = SupportedInterfaces?.ContainsKey(interfaceName);
        return (hasInterface.HasValue && hasInterface.Value); 
    }

    [JsonPropertyName("persistentEndpointId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? PersistentEndpointId { get; set; }
}
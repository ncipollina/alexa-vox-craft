using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Types.Apl;

public class Usage
{
    [JsonPropertyName("instanceId"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string InstanceId { get; set; }

    [JsonPropertyName("location"), JsonConverter(typeof(JsonStringEnumConverter))]
    public UsageLocation Location { get; set; }
}
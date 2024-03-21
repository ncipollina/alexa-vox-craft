using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Types.Apl;

public class UsagesInstalledPayload
{
    [JsonPropertyName("packageId")]
    public string PackageId { get; set; }

    [JsonPropertyName("packageVersion"),JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string PackageVersion { get; set; }

    [JsonPropertyName("usages")]
    public Usage[] Usages { get; set; }
}
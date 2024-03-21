using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Apl;

public class APLViewportConfigurationContainer
{
    [JsonPropertyName("current"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLViewportConfiguration Current { get; set; }
}
using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Extensions.Backstack;

public class BackstackSettings
{
    [JsonPropertyName("backstackId"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string BackstackId { get; set; }

}
using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Directives;

public class APLDocumentReference
{
    [JsonPropertyName("version"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string VersionString { get; set; }
}
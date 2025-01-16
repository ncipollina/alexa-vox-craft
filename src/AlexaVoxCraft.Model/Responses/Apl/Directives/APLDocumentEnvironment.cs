using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Directives;

public class APLDocumentEnvironment
{
    [JsonPropertyName("lang"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> Lang { get; set; }

    [JsonPropertyName("layoutDirection"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<LayoutDirection?> LayoutDirection { get; set; }

    [JsonPropertyName("parameters"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull),
     JsonConverter(typeof(ParameterListConverter))]
    public IList<Parameter> Parameters { get; set; }
}
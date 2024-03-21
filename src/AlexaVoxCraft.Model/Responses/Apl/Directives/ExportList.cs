using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Directives;

public class ExportList
{
    [JsonPropertyName("graphics"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(ListObjectOrStringJsonConverter<Export, IEnumerable<Export>>))]
    public IEnumerable<Export> Graphics { get; set; }

    [JsonPropertyName("layouts"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(ListObjectOrStringJsonConverter<Export, IEnumerable<Export>>))]
    public IEnumerable<Export> Layouts { get; set; }

    [JsonPropertyName("resources"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(ListObjectOrStringJsonConverter<Export, IEnumerable<Export>>))]
    public IEnumerable<Export> Resources { get; set; }

    [JsonPropertyName("styles"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(ListObjectOrStringJsonConverter<Export, IEnumerable<Export>>))]
    public IEnumerable<Export> Styles { get; set; }
}
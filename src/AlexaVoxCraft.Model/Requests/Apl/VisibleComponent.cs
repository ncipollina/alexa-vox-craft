using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Requests.Apl;

public class VisibleComponent
{
    [JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Id { get; set; }

    [JsonPropertyName("uid"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Uid { get; set; }

    [JsonPropertyName("position"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Position { get; set; }

    [JsonPropertyName("type"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault),
     JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<VisibleComponentType>))]
    public VisibleComponentType Type { get; set; }

    [JsonPropertyName("tags"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public VisibleComponentTags Tags { get; set; }

    [JsonPropertyName("children"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public VisibleComponent[] Children { get; set; }

    [JsonPropertyName("entities"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public VisibleComponentEntity[] Entities { get; set; }
}
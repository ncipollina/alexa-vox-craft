using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public class AlexaPaginatedList : ResponsiveTemplate
{
    [JsonPropertyName("primaryAction"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> PrimaryAction { get; set; }

    [JsonPropertyName("listItems"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<AlexaPaginatedListItem>> ListItems { get; set; }

    [JsonPropertyName("headerAttributionOpacity"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<double?> HeaderAttributionOpacity { get; set; }

    [JsonPropertyName("listId"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> ListId { get; set; }

    [JsonPropertyName("speechItems"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> SpeechItems { get; set; }
}
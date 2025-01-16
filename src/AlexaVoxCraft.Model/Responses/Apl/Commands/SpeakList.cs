using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Commands;

public class SpeakList : APLCommand
{
    [JsonPropertyName("align"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<ItemAlignment?> Align { get; set; }

    [JsonPropertyName("componentId")] public APLValue<string> ComponentId { get; set; }

    [JsonPropertyName("start")] public APLValue<int> Start { get; set; }

    [JsonPropertyName("count")] public APLValue<int> Count { get; set; }

    [JsonPropertyName("minimumDwellTime"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<int?> MinimumDwellTime { get; set; }

}
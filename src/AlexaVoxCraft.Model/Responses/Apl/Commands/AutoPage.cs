using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Commands;

public class AutoPage : APLCommand
{
    [JsonPropertyName("componentId"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> ComponentId { get; set; }

    [JsonPropertyName("count"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<int?> Count { get; set; }

    [JsonPropertyName("duration"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<int?> Duration { get; set; }

    [JsonPropertyName("transitionDuration"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<int?> TransitionDuration { get; set; }
}
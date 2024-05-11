using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;
using AlexaVoxCraft.Model.Responses.Apl.Gestures;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public abstract class TouchComponent : ActionableComponent
{
    [JsonPropertyName("gestures"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLGesture>> Gestures { get; set; }

    [JsonPropertyName("onCancel"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnCancel { get; set; }

    [JsonPropertyName("onDown"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnDown { get; set; }

    [JsonPropertyName("onUp"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnUp { get; set; }

    [JsonPropertyName("onMove"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnMove { get; set; }

    [JsonPropertyName("onPress"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnPress { get; set; }
}
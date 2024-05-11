using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;

namespace AlexaVoxCraft.Model.Responses.Apl.Gestures;

public class DoublePress : APLGesture
{
    [JsonPropertyName("onDoublePress"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnDoublePress { get; set; }

    [JsonPropertyName("onSinglePress"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnSinglePress { get; set; }
}
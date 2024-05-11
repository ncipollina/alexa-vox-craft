using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;

namespace AlexaVoxCraft.Model.Responses.Apl.Gestures;

public class LongPress : APLGesture
{
    [JsonPropertyName("onLongPressStart"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnLongPressStart { get; set; }

    [JsonPropertyName("onLongPressEnd"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnLongPressEnd { get; set; }
}
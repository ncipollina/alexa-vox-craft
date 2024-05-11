using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;
using AlexaVoxCraft.Model.Responses.Apl.Components;

namespace AlexaVoxCraft.Model.Responses.Apl.Gestures;

public class SwipeAway : APLGesture
{
    [JsonPropertyName("onSwipeMove"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnSwipeMove { get; set; }

    [JsonPropertyName("onSwipeDone"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnSwipeDone { get; set; }
    
    [JsonPropertyName("item"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLComponent>> Item { get; set; }

    [JsonPropertyName("action"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<SwipeAction?> Action { get; set; }
    
    [JsonPropertyName("direction")]
    public APLValue<SwipeDirection> Direction { get; set; }
}
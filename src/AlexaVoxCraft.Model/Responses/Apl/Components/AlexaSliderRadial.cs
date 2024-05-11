using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public class AlexaSliderRadial : AlexaSliderBase
{
    [JsonPropertyName("useDefaultSliderExpandTransition"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> UseDefaultSliderExpandTransition { get; set; }
}
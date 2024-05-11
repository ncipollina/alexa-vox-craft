using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public abstract class ActionableComponent : APLComponent
{
    [JsonPropertyName("onBlur"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnBlur { get; set; }
    
    [JsonPropertyName("onFocus"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> OnBlOnFocusur { get; set; }
    
    [JsonPropertyName("handleKeyDown"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLKeyboardHandler>> HandleKeyDown { get; set; }

    [JsonPropertyName("handleKeyUp"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLKeyboardHandler>> HandleKeyUp { get; set; }
}
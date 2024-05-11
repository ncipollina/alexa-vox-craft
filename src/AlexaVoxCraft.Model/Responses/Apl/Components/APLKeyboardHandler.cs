using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public class APLKeyboardHandler
{
    [JsonPropertyName("when"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> When { get; set; }

    [JsonPropertyName("propagate"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> Propagate { get; set; }

    [JsonPropertyName("commands"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<APLCommand>> Commands { get; set; }

    [JsonPropertyName("description"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> Description { get; set; }
}
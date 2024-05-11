using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Commands;

public class SetValue : APLCommand
{
    [JsonPropertyName("componentId"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> ComponentId { get; set; }

    [JsonPropertyName("property")]
    public APLValue<string> Property { get; set; }


    [JsonPropertyName("value")]
    public APLValue<object> Value { get; set; }
}
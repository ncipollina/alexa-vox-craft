using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Commands;

public class SendEvent : APLCommand
{
    [JsonPropertyName("type")]
    public override string Type => nameof(SendEvent);

    [JsonPropertyName("arguments"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<object>> Arguments { get; set; }

    [JsonPropertyName("components"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<string>> Components { get; set; }
}
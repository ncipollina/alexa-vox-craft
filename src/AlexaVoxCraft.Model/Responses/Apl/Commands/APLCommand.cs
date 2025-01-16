using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Commands;

[JsonConverter(typeof(APLCommandConverter))]
public abstract class APLCommand
{
    protected APLCommand(string? type = null)
    {
        Type = !string.IsNullOrWhiteSpace(type) ? type : GetType().Name;
    }

    [JsonPropertyName("type")]
    [JsonInclude]
    public virtual string Type { get; private set; }
    
    [JsonPropertyName("when"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string When { get; set; }

    [JsonPropertyName("description"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Description { get; set; }

    [JsonPropertyName("delay"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<int?> DelayMilliseconds { get; set; }

    [JsonPropertyName("screenLock"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> ScreenLock { get; set; }

    [JsonPropertyName("sequencer"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> Sequencer { get; set; }
}
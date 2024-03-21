using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Audio;
using AlexaVoxCraft.Model.Responses.Apl.Directives;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public abstract class APLComponentBase
{
    [JsonPropertyName("type")]
    [JsonInclude]
    public string Type { get; private set; }

    [JsonPropertyName("bind"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IEnumerable<Binding> Bindings { get; set; }
    
    [JsonPropertyName("when"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?> When { get; set; }
    
    [JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Id { get; set; }

    [JsonPropertyName("description"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> Description { get; set; }

    [JsonPropertyName("duration"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public AudioDuration? Duration { get; set; }

}
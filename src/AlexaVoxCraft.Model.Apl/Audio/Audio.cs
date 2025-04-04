using System.Collections.Generic;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Apl.JsonConverter;

namespace AlexaVoxCraft.Model.Apl.Audio;

public class Audio : APLAComponent
{
    public override string Type => nameof(Audio);

    [JsonPropertyName("source")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string>? Source { get; set; }

    [JsonPropertyName("filter")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(APLAFilterListConverter))]
    public APLValue<IList<APLAFilter>>? Filters { get; set; }
}
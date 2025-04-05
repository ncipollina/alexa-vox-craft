using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Apl.Audio;
using AlexaVoxCraft.Model.Response.Converters;

namespace AlexaVoxCraft.Model.Apl;

public abstract class APLComponentBase
{
    [JsonPropertyName("type")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public abstract string? Type { get; }

    [JsonPropertyName("bind")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IList<Binding>? Bindings { get; set; }

    // TODO: Add this to the Options Modifier
    public bool ShouldSerializeBindings()
    {
        return Bindings?.Any() ?? false;
    }

    [JsonPropertyName("when")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<bool?>? When { get; set; }

    [JsonPropertyName("id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string? Id { get; set; }

    [JsonPropertyName("description")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string>? Description { get; set; }

    [JsonPropertyName("duration")]
    [JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<AudioDuration>))]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public AudioDuration? Duration { get; set; }
}
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.DataSources;

[JsonConverter(typeof(APLDataSourceConverter))]
public abstract class APLDataSource
{
    [JsonPropertyName("type")]
    [JsonInclude]
    public virtual string Type { get; private set; }
}
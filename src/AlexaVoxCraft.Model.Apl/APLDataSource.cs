using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

[JsonConverter(typeof(APLDataSourceConverter))]
public abstract class APLDataSource
{
    [JsonProperty("type")]
    public abstract string Type { get; }
}
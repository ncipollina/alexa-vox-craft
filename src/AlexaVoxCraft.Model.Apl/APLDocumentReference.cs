using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

[JsonConverter(typeof(APLDocumentConverter))]
public abstract class APLDocumentReference
{
    [JsonProperty("type")]
    public abstract string Type { get; }

    [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
    public string VersionString { get; set; }
}
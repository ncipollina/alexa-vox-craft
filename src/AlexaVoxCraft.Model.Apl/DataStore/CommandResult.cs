using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AlexaVoxCraft.Model.Apl.DataStore;

public class CommandResult
{
    [JsonProperty("deviceId")]
    public string DeviceId { get; set; }

    [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
    public string Message { get; set; }

    [JsonProperty("type")]
    [JsonConverter(typeof(StringEnumConverter))]
    public CommandResultType Type { get; set; }
}
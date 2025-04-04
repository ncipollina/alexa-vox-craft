using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

public class AlexaDisplay
{
    [JsonProperty("token")]
    public string Token { get; set; }
}
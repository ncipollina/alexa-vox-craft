using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

public class VideoSupport
{
    [JsonProperty("codecs")]
    public string[] Codecs { get; set; }
}
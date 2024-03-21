using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Apl;

public class VideoSupport
{
    [JsonPropertyName("codecs")]
    public string[] Codecs { get; set; }
}
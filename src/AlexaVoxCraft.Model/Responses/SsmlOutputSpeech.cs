using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses;

public class SsmlOutputSpeech : OutputSpeech
{
    [JsonRequired]
    [JsonPropertyName("ssml")]
    public string Ssml { get; set; }

}
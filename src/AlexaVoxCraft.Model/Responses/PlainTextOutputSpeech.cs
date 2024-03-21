using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses;

public class PlainTextOutputSpeech : OutputSpeech
{
    [JsonPropertyName("text")]
    public string Text { get; set; }
}
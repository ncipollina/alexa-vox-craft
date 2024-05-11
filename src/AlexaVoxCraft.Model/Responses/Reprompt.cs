using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Ssmls;

namespace AlexaVoxCraft.Model.Responses;

public class Reprompt
{
    public Reprompt()
    {
    }

    public Reprompt(string text)
    {
        OutputSpeech = new PlainTextOutputSpeech
        {
            Text = text
        };
    }

    public Reprompt(Speech speech)
    {
        OutputSpeech = new SsmlOutputSpeech { Ssml = speech.ToXml() };
    }
    

    [JsonPropertyName("outputSpeech")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OutputSpeech OutputSpeech { get; set; }

    [JsonPropertyName("directives")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IList<Directive> Directives { get; set; } = new List<Directive>();
}
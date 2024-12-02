using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses;

public class ResponseBody
{
    [JsonPropertyName("outputSpeech")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public OutputSpeech? OutputSpeech { get; set; }
    
    [JsonPropertyName("card")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Card Card { get; set; }

    [JsonPropertyName("reprompt")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Reprompt Reprompt { get; set; }
    
    [JsonPropertyName("shouldEndSession")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool? ShouldEndSession { get; set; }

    [JsonPropertyName("directives")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IList<Directive>? Directives { get; set; }
    
    [JsonPropertyName("canFulfillIntent")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public CanFulfillIntent CanFulfillIntent { get; set; }
}
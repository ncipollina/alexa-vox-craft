using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Directives;

public class HintDirective : Directive
{
    [JsonPropertyName("hint")]
    public Hint Hint { get; set; }
}
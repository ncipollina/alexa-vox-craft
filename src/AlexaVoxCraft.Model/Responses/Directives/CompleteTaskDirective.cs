using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Directives;

public class CompleteTaskDirective : Directive
{
    [JsonPropertyName("status")]
    public ConnectionStatus Status { get; set; } 
}
using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Directives;

public class AskForPermissionsDirective : Directive
{
    [JsonPropertyName("name")] 
    public string Name { get; set; }

    [JsonPropertyName("token")]
    public string Token { get; set; }
    
    [JsonPropertyName("payload")]
    public Payload Payload { get; set; }
}
using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Directives;

public class APLRenderDocumentDirective : RenderDocumentDirective
{
    public const string DirectiveType = "Alexa.Presentation.APL.RenderDocument";
    
    [JsonPropertyName("sources"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Dictionary<string, APLDocumentReference> Sources { get; set; }
}
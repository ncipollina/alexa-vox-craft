using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Requests.Apl;

namespace AlexaVoxCraft.Model.Responses.Apl.Directives;

public class APLTRenderDocumentDirective : RenderDocumentDirective
{
    public const string DirectiveType = "Alexa.Presentation.APLT.RenderDocument";
    
    [JsonPropertyName("targetProfile"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLTProfile? TargetProfile { get; set; }
}
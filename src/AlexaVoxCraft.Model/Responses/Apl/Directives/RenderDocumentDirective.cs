using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Requests.Apl;
using AlexaVoxCraft.Model.Responses.Apl.DataSources;

namespace AlexaVoxCraft.Model.Responses.Apl.Directives;

public abstract class RenderDocumentDirective : Directive
{
    public RenderDocumentDirective(){}

    public RenderDocumentDirective(APLDocumentReference document)
    {
        Document = document;
    }
    
    [JsonPropertyName("document")]
    public APLDocumentReference Document { get; set; }
    
    [JsonPropertyName("token"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Token { get; set; }
    
    [JsonPropertyName("targetProfile"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLTProfile? TargetProfile { get; set; }

    [JsonPropertyName("datasources"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Dictionary<string, APLDataSource> DataSources { get; set; }
    
    [JsonPropertyName("sources"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Dictionary<string, APLDocumentReference> Sources { get; set; }
}
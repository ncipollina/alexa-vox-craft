using System.Collections.Generic;
using AlexaVoxCraft.Model.Response;
using AlexaVoxCraft.Model.Response.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AlexaVoxCraft.Model.Apl;

public class RenderDocumentDirective : IDirective
{
    public const string APLDirectiveType = "Alexa.Presentation.APL.RenderDocument";
    public const string APLTDirectiveType = "Alexa.Presentation.APLT.RenderDocument";
    public const string APLADirectiveType = "Alexa.Presentation.APLA.RenderDocument";

    public RenderDocumentDirective(){}

    public RenderDocumentDirective(APLDocumentReference document)
    {
        Document = document;
    }

    public static void AddSupport()
    {
        DirectiveConverter.RegisterDirectiveDerivedType<RenderDocumentDirective>(APLDirectiveType);
        DirectiveConverter.RegisterDirectiveDerivedType<RenderDocumentDirective>(APLTDirectiveType);
        DirectiveConverter.RegisterDirectiveDerivedType<RenderDocumentDirective>(APLADirectiveType);
    }

    [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
    public string Type => Document switch
    {
        APLDocument _ => APLDirectiveType,
        APLDocumentLink _ => APLDirectiveType,
        APLTDocument _ => APLTDirectiveType,
        APLADocument _ => APLADirectiveType,
        _ => string.Empty
    };

    [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
    public string Token { get; set; }

    [JsonProperty("targetProfile", NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public APLTProfile? TargetProfile { get; set; }

    [JsonProperty("document")]
    public APLDocumentReference Document { get; set; }

    [JsonProperty("datasources", NullValueHandling = NullValueHandling.Ignore)]
    public Dictionary<string, APLDataSource> DataSources { get; set; }

    [JsonProperty("sources",NullValueHandling = NullValueHandling.Ignore)]
    public Dictionary<string, APLDocumentReference> Sources { get; set; }
}
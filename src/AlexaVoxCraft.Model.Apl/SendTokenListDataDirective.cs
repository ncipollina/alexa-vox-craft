using AlexaVoxCraft.Model.Response.Converters;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

public class SendTokenListDataDirective : ListDataDirective
{
    public const string DirectiveType = "Alexa.Presentation.APL.SendTokenListData";

    public static void AddSupport()
    {
        DirectiveConverter.RegisterDirectiveDerivedType<SendTokenListDataDirective>(DirectiveType);
    }

    public override string Type => DirectiveType;

    [JsonProperty("pageToken")]
    public string PageToken { get; set; }

    [JsonProperty("nextPageToken",NullValueHandling = NullValueHandling.Ignore)]
    public string NextPageToken { get; set; }
}
using AlexaVoxCraft.Model.Response.Converters;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

public class SendIndexListDataDirective:ListDataDirective
{
    public const string DirectiveType = "Alexa.Presentation.APL.SendIndexListData";

    public static void AddSupport()
    {
        DirectiveConverter.RegisterDirectiveDerivedType<SendIndexListDataDirective>(DirectiveType);
    }

    [JsonProperty("type")]
    public override string Type => DirectiveType;

    [JsonProperty("listVersion",NullValueHandling = NullValueHandling.Ignore)]
    public int? ListVersion { get; set; }

    [JsonProperty("startIndex",NullValueHandling = NullValueHandling.Ignore)]
    public int? StartIndex { get; set; }

    [JsonProperty("minimumInclusiveIndex",NullValueHandling = NullValueHandling.Ignore)]
    public int? MinimumInclusiveIndex { get; set; }

    [JsonProperty("maximumExclusiveIndex",NullValueHandling = NullValueHandling.Ignore)]
    public int? MaximumExclusiveIndex { get; set; }

}
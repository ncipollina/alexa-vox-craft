using System.Collections.Generic;
using AlexaVoxCraft.Model.Response;
using AlexaVoxCraft.Model.Response.Converters;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

public class UpdateIndexListDataDirective:IDirective
{
    public const string DirectiveType = "Alexa.Presentation.APL.UpdateIndexListData";

    public static void AddSupport()
    {
        DirectiveConverter.RegisterDirectiveDerivedType<UpdateIndexListDataDirective>(DirectiveType);
    }

    [JsonProperty("type")] public string Type => DirectiveType;

    [JsonProperty("token",NullValueHandling = NullValueHandling.Ignore)]
    public string Token { get; set; }

    [JsonProperty("listId",NullValueHandling = NullValueHandling.Ignore)]
    public string ListId { get; set; }

    [JsonProperty("listVersion",NullValueHandling = NullValueHandling.Ignore)]
    public int? ListVersion { get; set; }

    [JsonProperty("operations",NullValueHandling = NullValueHandling.Ignore)]
    public IList<Operation.Operation> Operations { get; set; } = new List<Operation.Operation>();
}
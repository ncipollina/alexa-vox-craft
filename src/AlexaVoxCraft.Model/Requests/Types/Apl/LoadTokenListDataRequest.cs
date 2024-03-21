using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Types.Apl;

public class LoadTokenListDataRequest : RequestType
{
    public const string RequestType = "Alexa.Presentation.APL.LoadTokenListData";
    
    [JsonPropertyName("token"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Token { get; set; }

    [JsonPropertyName("correlationToken"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string CorrelationToken { get; set; }

    [JsonPropertyName("listId"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string ListId { get; set; }

    [JsonPropertyName("pageToken")]
    public string PageToken { get; set; }

}
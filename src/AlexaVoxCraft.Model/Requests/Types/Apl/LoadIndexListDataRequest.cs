using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Types.Apl;

public class LoadIndexListDataRequest : RequestType
{
    public const string RequestType = "Alexa.Presentation.APL.LoadIndexListData";
    
    [JsonPropertyName("token")]
    public string Token { get; set; }

    [JsonPropertyName("correlationToken")]
    public string CorrelationToken { get; set; }

    [JsonPropertyName("listId")]
    public string ListId { get; set; }

    [JsonPropertyName("startIndex")]
    public int StartIndex { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

}
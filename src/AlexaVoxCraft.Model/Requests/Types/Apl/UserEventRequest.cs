using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Types.Apl;

public class UserEventRequest : RequestType
{
    public const string RequestType = "Alexa.Presentation.APL.UserEvent";

    [JsonPropertyName("token"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Token { get; set; }

    [JsonPropertyName("arguments"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string[] Arguments { get; set; }

    [JsonPropertyName("source"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLCommandSource Source { get; set; }

    [JsonPropertyName("components"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Dictionary<string, object> Components { get; set; }

    [JsonPropertyName("presentationUri"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string PresentationUri { get; set; }
}
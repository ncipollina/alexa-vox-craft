using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Types.Apl;

public class RuntimeErrorRequest : RequestType
{
    public const string RequestType = "Alexa.Presentation.APL.RuntimeError";
    
    [JsonPropertyName("token"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Token { get; set; }

    [JsonPropertyName("errors")]
    public APLError[] Errors { get; set; }
}
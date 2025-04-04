using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

public class RuntimeErrorRequest : Request.Type.Request
{
    public const string RequestType = "Alexa.Presentation.APL.RuntimeError";

    [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
    public string Token { get; set; }

    [JsonProperty("errors")]
    public APLError[] Errors { get; set; }
}
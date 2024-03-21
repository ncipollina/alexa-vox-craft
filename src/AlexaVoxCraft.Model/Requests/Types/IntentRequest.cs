using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Types;

public class IntentRequest : RequestType
{
    [JsonPropertyName("dialogState")]
    public string DialogState { get; set; }

    [JsonPropertyName("intent")]
    public Intent Intent { get; set; }
}
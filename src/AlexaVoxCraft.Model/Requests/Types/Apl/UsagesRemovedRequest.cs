using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Types.Apl;

public class UsagesRemovedRequest : RequestType
{
    public const string RequestType = "Alexa.DataStore.PackageManager.UsagesRemoved";

    [JsonPropertyName("payload")]
    public UsagesInstalledPayload Payload { get; set; }

}
using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Types.Apl;

public class UsagesInstalledRequest : RequestType
{
    public const string RequestType = "Alexa.DataStore.PackageManager.UsagesInstalled";

    [JsonPropertyName("payload")]
    public UsagesInstalledPayload Payload { get; set; }
}
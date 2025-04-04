using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.DataStore.PackageManager;

public class UsagesInstalledRequest : Request.Type.Request
{
    public const string RequestType = "Alexa.DataStore.PackageManager.UsagesInstalled";

    [JsonProperty("payload")]
    public UsagesInstalledPayload Payload { get; set; }
}
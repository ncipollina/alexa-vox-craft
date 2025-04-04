using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.DataStore.PackageManager;

public class UsagesRemovedRequest : Request.Type.Request
{
    public const string RequestType = "Alexa.DataStore.PackageManager.UsagesRemoved";

    [JsonProperty("payload")]
    public UsagesInstalledPayload Payload { get; set; }
}
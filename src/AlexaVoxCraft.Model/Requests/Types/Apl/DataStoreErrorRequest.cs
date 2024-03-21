using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Types.Apl;

public class DataStoreErrorRequest : RequestType
{
    public const string RequestType = "Alexa.DataStore.Error";

    [JsonPropertyName("error")]
    public DataStoreError Error { get; set; }
}
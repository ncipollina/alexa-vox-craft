using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Types.Apl;

public class PutNamespaceDataStoreCommand : DataStoreCommand
{
    public const string DataStoreCommandType = "PUT_NAMESPACE";
    
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
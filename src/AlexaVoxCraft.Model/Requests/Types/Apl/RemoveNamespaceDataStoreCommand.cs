using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Types.Apl;

public class RemoveNamespaceDataStoreCommand : DataStoreCommand
{
    public const string DataStoreCommandType = "REMOVE_NAMESPACE";
    
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
}
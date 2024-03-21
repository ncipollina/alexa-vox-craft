using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Types.Apl;

public class RemoveObjectDataStoreCommand : DataStoreCommand
{
    public const string DataStoreCommandType = "REMOVE_OBJECT";
    
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
    
    [JsonPropertyName("key")]
    public string Key { get; set; }
}
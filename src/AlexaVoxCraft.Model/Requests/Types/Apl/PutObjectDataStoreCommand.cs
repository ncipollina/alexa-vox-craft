using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Types.Apl;

public class PutObjectDataStoreCommand : DataStoreCommand
{
    public const string DataStoreCommandType = "PUT_OBJECT";
    
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
    
    [JsonPropertyName("key")]
    public string Key { get; set; }
    
    [JsonPropertyName("content")]
    public object Content { get; set; }
}
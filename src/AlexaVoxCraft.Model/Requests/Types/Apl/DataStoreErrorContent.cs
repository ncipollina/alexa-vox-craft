using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Types.Apl;

public class DataStoreErrorContent
{
    [JsonPropertyName("deviceId")]
    public string DeviceId { get; set; }
    
    [JsonPropertyName("message"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Message { get; set; }
    
    [JsonPropertyName("commands"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IList<DataStoreCommand> Commands { get; set; }
    
    [JsonPropertyName("failedCommand"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DataStoreCommand FailedCommand { get; set; }
}
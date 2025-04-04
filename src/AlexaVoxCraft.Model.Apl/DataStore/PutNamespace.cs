using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.DataStore;

public class PutNamespace : DataStoreCommand
{
    public const string CommandType = "PUT_NAMESPACE";

    public PutNamespace() : base(CommandType){}

    [JsonProperty("namespace")]
    public string Namespace { get; set; }
}
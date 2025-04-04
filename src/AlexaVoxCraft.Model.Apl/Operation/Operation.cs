using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Operation;

[JsonConverter(typeof(OperationConverter))]
public abstract class Operation
{
    [JsonProperty("type")]
    public abstract string Type { get; }
}
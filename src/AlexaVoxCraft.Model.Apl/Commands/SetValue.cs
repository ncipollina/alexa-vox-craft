using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Commands;

public class SetValue : APLCommand
{
    [JsonProperty("type")]
    public override string Type => nameof(SetValue);

    [JsonProperty("componentId", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> ComponentId { get; set; }

    [JsonProperty("property")]
    public APLValue<string> Property { get; set; }


    [JsonProperty("value")]
    public APLValue<object> Value { get; set; }
}
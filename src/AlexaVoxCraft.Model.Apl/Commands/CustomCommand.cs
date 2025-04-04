using System.Collections.Generic;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Commands;

public class CustomCommand:APLCommand
{
    public CustomCommand() { }

    [JsonConstructor]
    public CustomCommand(string type)
    {
        Type = type;
    }

    [JsonProperty("type")]
    public override string Type { get; }

    [JsonExtensionData]
    public Dictionary<string, object> ParameterValues { get; set; }
}
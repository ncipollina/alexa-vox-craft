using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Commands;

public class CustomCommand : APLCommand
{
    public CustomCommand(string type) : base(type)
    {
    }

    [JsonExtensionData, JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Dictionary<string, object> ParameterValues { get; set; }
}
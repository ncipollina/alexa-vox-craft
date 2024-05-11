using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;

namespace AlexaVoxCraft.Model.Responses.Apl.Extensions.SmartMotion;

public class StopMotionCommand : APLCommand
{
    private string _extensionName;

    public static StopMotionCommand For(SmartMotionExtension extension)
    {
        return new StopMotionCommand(extension.Name);
    }

    public StopMotionCommand(string extensionName)
    {
        _extensionName = extensionName;
    }

    [JsonPropertyName("type")]
    [JsonInclude]
    public override string Type => $"{_extensionName}:StopMotion";
}
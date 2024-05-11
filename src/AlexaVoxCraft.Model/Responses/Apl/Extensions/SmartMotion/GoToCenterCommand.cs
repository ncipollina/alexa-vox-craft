using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;

namespace AlexaVoxCraft.Model.Responses.Apl.Extensions.SmartMotion;

public class GoToCenterCommand : APLCommand
{
    private string _extensionName;

    public static GoToCenterCommand For(SmartMotionExtension extension)
    {
        return new GoToCenterCommand(extension.Name);
    }

    public GoToCenterCommand(string extensionName)
    {
        _extensionName = extensionName;
    }

    [JsonPropertyName("type")]
    [JsonInclude]
    public override string Type => $"{_extensionName}:GoToCenter";
}
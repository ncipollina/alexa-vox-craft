using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;

namespace AlexaVoxCraft.Model.Responses.Apl.Extensions.SmartMotion;

public class TurnToPrimaryUserCommand : APLCommand
{
    private string _extensionName;

    public static TurnToPrimaryUserCommand For(SmartMotionExtension extension)
    {
        return new TurnToPrimaryUserCommand(extension.Name);
    }

    public TurnToPrimaryUserCommand(string extensionName)
    {
        _extensionName = extensionName;
    }

    [JsonPropertyName("type")]
    [JsonInclude]
    public override string Type => $"{_extensionName}:TurnToPrimaryUser";
}
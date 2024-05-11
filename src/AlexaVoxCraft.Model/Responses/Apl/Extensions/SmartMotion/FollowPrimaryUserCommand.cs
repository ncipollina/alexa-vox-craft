using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;

namespace AlexaVoxCraft.Model.Responses.Apl.Extensions.SmartMotion;

public class FollowPrimaryUserCommand : APLCommand
{
    private string _extensionName;

    public static FollowPrimaryUserCommand For(SmartMotionExtension extension)
    {
        return new FollowPrimaryUserCommand(extension.Name);
    }

    public FollowPrimaryUserCommand(string extensionName)
    {
        _extensionName = extensionName;
    }

    [JsonPropertyName("type")]
    [JsonInclude]
    public override string Type => $"{_extensionName}:FollowPrimaryUser";
}
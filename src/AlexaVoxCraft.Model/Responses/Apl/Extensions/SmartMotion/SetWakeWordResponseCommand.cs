using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;

namespace AlexaVoxCraft.Model.Responses.Apl.Extensions.SmartMotion;

public class SetWakeWordResponseCommand : APLCommand
{
    private string _extensionName;

    public static SetWakeWordResponseCommand For(SmartMotionExtension extension)
    {
        return new SetWakeWordResponseCommand(extension.Name);
    }

    public SetWakeWordResponseCommand(string extensionName)
    {
        _extensionName = extensionName;
    }

    [JsonPropertyName("type")]
    [JsonInclude]
    public override string Type => $"{_extensionName}:SetWakeWordResponse";

    [JsonPropertyName("wakeWordResponse"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public WakeWordResponse? WakeWordResponse { get; set; }
}
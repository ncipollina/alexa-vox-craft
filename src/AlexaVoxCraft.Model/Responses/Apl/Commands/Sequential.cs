using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Commands;

public class Sequential : APLCommand
{
    public Sequential()
    {
    }

    public Sequential(IEnumerable<APLCommand> commands)
    {
        Commands = commands.ToList();
    }

    public Sequential(params APLCommand[] commands) : this((IEnumerable<APLCommand>)commands)
    {
    }

    [JsonPropertyName("finally"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IList<APLCommand>> Finally { get; set; }

    [JsonPropertyName("catch"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IList<APLCommand>> Catch { get; set; }

    [JsonPropertyName("commands")] public APLValue<IList<APLCommand>> Commands { get; set; }

    [JsonPropertyName("repeatCount"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<int?> RepeatCount { get; set; }

    [JsonPropertyName("data"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IList<object>> Data { get; set; }
}
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Commands;

public class ClearFocus : APLCommand
{
    [JsonProperty("type")]
    public override string Type => nameof(ClearFocus);

}
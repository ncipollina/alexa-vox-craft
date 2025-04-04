using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Components;

public class TimeText:TextBase
{
    public override string Type => nameof(TimeText);

    [JsonProperty("direction",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<TimeTextDirection?> Direction { get; set; }

    [JsonProperty("format",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> Format { get; set; }

    [JsonProperty("start",NullValueHandling = NullValueHandling.Ignore)]
    public new APLValue<int?> Start { get; set; }
}
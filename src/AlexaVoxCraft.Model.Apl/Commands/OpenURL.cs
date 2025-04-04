using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Commands;

public class OpenURL:APLCommand
{
    [JsonProperty("type")] public override string Type => nameof(OpenURL);

    [JsonProperty("source")]
    public APLValue<string> Source { get; set; }

    [JsonProperty("onFail",NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(APLCommandListConverter))]
    public APLValue<IList<APLCommand>> OnFail { get; set; }
}
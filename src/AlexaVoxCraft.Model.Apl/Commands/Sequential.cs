using System.Collections.Generic;
using System.Linq;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Commands;

public class Sequential:APLCommand
{
    public Sequential() { }
    public Sequential(IEnumerable<APLCommand> commands)
    {
        Commands = commands.ToList();
    }

    public Sequential(params APLCommand[] commands) : this((IEnumerable<APLCommand>)commands) { }

    public override string Type => nameof(Sequential);

    [JsonProperty("finally", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(APLCommandListConverter))]
    public APLValue<IList<APLCommand>> Finally { get; set; }

    [JsonProperty("catch",NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(APLCommandListConverter))]
    public APLValue<IList<APLCommand>> Catch { get; set; }

    [JsonProperty("commands"),
     JsonConverter(typeof(APLCommandListConverter))]
    public APLValue<IList<APLCommand>> Commands { get; set; }

    [JsonProperty("repeatCount",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<int?> RepeatCount { get; set; }

    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(GenericLegacySingleOrListConverter<object>))]
    public APLValue<IList<object>> Data { get; set; }
}
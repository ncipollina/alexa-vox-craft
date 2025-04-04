using System.Collections.Generic;
using System.Linq;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Commands;

public class Parallel:APLCommand
{
    public Parallel() { }

    public Parallel(IEnumerable<APLCommand> commands)
    {
        Commands = commands.ToList();
    }

    public Parallel(params APLCommand[] commands) : this((IEnumerable<APLCommand>)commands) { }

    public override string Type => nameof(Parallel);

    [JsonProperty("commands", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(APLCommandListConverter))]
    public APLValue<IList<APLCommand>> Commands { get; set; }

    [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(GenericLegacySingleOrListConverter<object>))]
    public APLValue<IList<object>> Data { get; set; }
}
using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.Components;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Commands;

public class PlayMedia:APLCommand
{
    public override string Type => "PlayMedia";

    [JsonProperty("audioTrack", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> AudioTrack { get; set; } = "foreground";

    [JsonProperty("componentId", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> ComponentId { get; set; }

    [JsonProperty("source"),
     JsonConverter(typeof(GenericLegacySingleOrListConverter<VideoSource>))]
    public APLValue<IList<VideoSource>> Value { get; set; }

}
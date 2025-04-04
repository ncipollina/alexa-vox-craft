using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Components;

public class Video:APLComponent{
 public override string Type => "Video";

 [JsonProperty("audioTrack", NullValueHandling = NullValueHandling.Ignore)]
 public APLValue<string> AudioTrack { get; set; }

 [JsonProperty("autoplay", NullValueHandling = NullValueHandling.Ignore)]
 public APLValue<bool?> Autoplay { get; set; }

 [JsonProperty("muted",NullValueHandling = NullValueHandling.Ignore)]
 public APLValue<bool?> Muted { get; set; }

 [JsonProperty("scale", NullValueHandling = NullValueHandling.Ignore)]
 public APLValue<Scale> Scale { get; set; }

 [JsonProperty("align", NullValueHandling = NullValueHandling.Ignore)]
 public APLValue<string> Align { get; set; }

 [JsonProperty("onEnd", NullValueHandling = NullValueHandling.Ignore)]
 public APLValue<List<APLCommand>> OnEnd { get; set; }

 [JsonProperty("source",NullValueHandling = NullValueHandling.Ignore),
  JsonConverter(typeof(GenericLegacySingleOrListConverter<VideoSource>),true)]
 public APLValue<IList<VideoSource>> Source { get; set; }

 [JsonProperty("onPause", NullValueHandling = NullValueHandling.Ignore),
  JsonConverter(typeof(APLCommandListConverter))]
 public APLValue<IList<APLCommand>> OnPause { get; set; }

 [JsonProperty("onPlay", NullValueHandling = NullValueHandling.Ignore),
  JsonConverter(typeof(APLCommandListConverter))]
 public APLValue<IList<APLCommand>> OnPlay { get; set; }

 [JsonProperty("onTrackUpdate", NullValueHandling = NullValueHandling.Ignore),
  JsonConverter(typeof(APLCommandListConverter))]
 public APLValue<IList<APLCommand>> OnTrackUpdate { get; set; }

 [JsonProperty("onTrackReady", NullValueHandling = NullValueHandling.Ignore),
  JsonConverter(typeof(APLCommandListConverter), true)]
 public APLValue<IList<APLCommand>> OnTrackReady { get; set; }

 [JsonProperty("onTrackFail", NullValueHandling = NullValueHandling.Ignore),
  JsonConverter(typeof(APLCommandListConverter), true)]
 public APLValue<IList<APLCommand>> OnTrackFail { get; set; }
}
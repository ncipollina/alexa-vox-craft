using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Components;

public abstract class TouchComponent : ActionableComponent
{
 [JsonProperty("gestures", NullValueHandling = NullValueHandling.Ignore),
  JsonConverter(typeof(APLGestureListConverter))]
 public APLValue<IList<APLGesture>> Gestures { get; set; }

 [JsonProperty("onCancel",NullValueHandling = NullValueHandling.Ignore),
  JsonConverter(typeof(APLCommandListConverter))]
 public APLValue<IList<APLCommand>> OnCancel { get; set; }

 [JsonProperty("onDown", NullValueHandling = NullValueHandling.Ignore),
  JsonConverter(typeof(APLCommandListConverter))]
 public APLValue<IList<APLCommand>> OnDown { get; set; }

 [JsonProperty("onUp", NullValueHandling = NullValueHandling.Ignore),
  JsonConverter(typeof(APLCommandListConverter))]
 public APLValue<IList<APLCommand>> OnUp { get; set; }

 [JsonProperty("onMove", NullValueHandling = NullValueHandling.Ignore),
  JsonConverter(typeof(APLCommandListConverter))]
 public APLValue<IList<APLCommand>> OnMove { get; set; }

 [JsonProperty("onPress", NullValueHandling = NullValueHandling.Ignore),
  JsonConverter(typeof(APLCommandListConverter))]
 public APLValue<IList<APLCommand>> OnPress { get; set; }
}
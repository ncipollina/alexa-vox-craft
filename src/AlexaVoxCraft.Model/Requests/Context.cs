using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Requests.Apl;

namespace AlexaVoxCraft.Model.Requests;

public class Context
{
    // [JsonPropertyName("Advertising")]
    // public Advertising Advertising { get; set; }
    //
    // [JsonPropertyName("Alexa.Presentation.APL"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    // public AplVisualContext AplVisualContext { get; set; }

    [JsonPropertyName("System")]
    public required AlexaSystem System { get; set; }
   
    [JsonPropertyName("AudioPlayer")]
    public PlaybackState? AudioPlayer { get; set; }
    
    [JsonPropertyName("Geolocation")]
    public Geolocation? Geolocation { get; set; }
  
    // [JsonPropertyName("Viewport"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    // public AlexaViewport Viewport { get; set; }
    //
    // [JsonPropertyName("Viewports"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    // public ViewPort[] Viewports { get; set; }
    //
    // [JsonPropertyName("Alexa.DataStore.PackageManager"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    // public PackageManagerContext PackageManagerContext { get; set; }
}
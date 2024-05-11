using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Apl;

public class APLViewport : ViewPort
{
    [JsonPropertyName("shape")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public ViewportShape Shape { get; set; }

    [JsonPropertyName("dpi")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int DPI { get; set; }

    [JsonPropertyName("presentationType")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public ViewPortPresentationType PresentationType { get; set; }

    [JsonPropertyName("canRotate")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public bool CanRotate { get; set; }

    [JsonPropertyName("configuration")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLViewportConfigurationContainer Configuration { get; set; }
}
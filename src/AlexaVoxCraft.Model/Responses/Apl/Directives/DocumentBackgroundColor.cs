using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Directives;

[JsonConverter(typeof(DocumentBackgroundColorConverter))]
public class DocumentBackgroundColor
{
    public string Color { get; set; }
    
    public APLGradient Gradient { get; set; }

    public DocumentBackgroundColor(string color) => Color = color;

    public DocumentBackgroundColor(APLGradient gradient) => Gradient = gradient;

    public static implicit operator DocumentBackgroundColor(string color) => new(color);

    public static implicit operator DocumentBackgroundColor(APLGradient gradient) => new(gradient);
}
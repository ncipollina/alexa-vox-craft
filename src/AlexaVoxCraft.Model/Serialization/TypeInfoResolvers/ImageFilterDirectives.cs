using System.Text.Json.Serialization.Metadata;
using AlexaVoxCraft.Model.Responses.Apl.Filters;

namespace AlexaVoxCraft.Model.Serialization.TypeInfoResolvers;

public partial class PolymorphicTypeResolver
{
    public static IList<JsonDerivedType> ImageFilterDirectives = new List<JsonDerivedType>()
    {
        new(typeof(Blur), nameof(Blur)),
        new(typeof(Blend), nameof(Blend)),
        new(typeof(Color), nameof(Color)),
        new(typeof(Gradient), nameof(Gradient)),
        new(typeof(Grayscale), nameof(Grayscale)),
        new(typeof(Noise), nameof(Noise)),
        new (typeof(Saturate), nameof(Saturate))
    };
}
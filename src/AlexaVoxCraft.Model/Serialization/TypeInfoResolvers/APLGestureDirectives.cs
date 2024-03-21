using System.Text.Json.Serialization.Metadata;
using AlexaVoxCraft.Model.Responses.Apl.Gestures;

namespace AlexaVoxCraft.Model.Serialization.TypeInfoResolvers;

public partial class PolymorphicTypeResolver
{
    public static IList<JsonDerivedType> APLGestureDirectives = new List<JsonDerivedType>()
    {
        new(typeof(Tap), nameof(Tap)),
        new(typeof(DoublePress), nameof(DoublePress)),
        new(typeof(LongPress), nameof(LongPress)),
        new(typeof(SwipeAway), nameof(SwipeAway))
    };
}
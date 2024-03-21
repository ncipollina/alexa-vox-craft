using System.Text.Json;
using AlexaVoxCraft.Model.Serialization.TypeInfoResolvers;

namespace AlexaVoxCraft.Model.Serialization;

public static class AlexaJsonOptions
{
    public static JsonSerializerOptions DefaultOptions => new()
    {
        TypeInfoResolver = new PolymorphicTypeResolver
        {
            Modifiers = { APLComponentModifiers.NormalizePropertyNames }
        }
    };
}
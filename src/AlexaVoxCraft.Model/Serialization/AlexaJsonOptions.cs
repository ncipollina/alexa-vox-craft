using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace AlexaVoxCraft.Model.Serialization;

public static class AlexaJsonOptions
{
    // This allows external packages to register their own JsonTypeInfo modifiers
    private static readonly List<Action<JsonTypeInfo>> AdditionalModifiers = [];

    public static JsonSerializerOptions DefaultOptions
    {
        get
        {
            var resolver = new AlexaTypeResolver();

            resolver.Modifiers.Add(Modifiers.SetNumberHandlingModifier);

            foreach (var modifier in AdditionalModifiers)
            {
                resolver.Modifiers.Add(modifier);
            }

            return new JsonSerializerOptions
            {
                TypeInfoResolver = resolver
            };
        }
    }
    
    public static void RegisterTypeModifier<T>(Action<JsonTypeInfo> modifier)
    {
        AdditionalModifiers.Add(ti => {
            if (ti.Type == typeof(T))
            {
                modifier(ti);
            }
        });
    }
}
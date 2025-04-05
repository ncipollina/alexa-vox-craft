using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Response.Converters;

public sealed class JsonStringEnumConverterWithEnumMemberAttrSupport<
    [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] TEnum> : JsonStringEnumConverter<TEnum>
    where TEnum : struct, Enum
{
    public JsonStringEnumConverterWithEnumMemberAttrSupport() : base(namingPolicy: ResolveNamingPolicy())
    {
    }

    private static JsonNamingPolicy? ResolveNamingPolicy()
    {
        var map = typeof(TEnum).GetFields(BindingFlags.Public | BindingFlags.Static)
            .Select(f => (f.Name, AttributeName: f.GetCustomAttribute<EnumMemberAttribute>()?.Value))
            .Where(pair => pair.AttributeName != null)
            .ToDictionary();

        return map.Count > 0 ? new EnumMemberNamingPolicy(map!) : null;
    }
    
    private sealed class EnumMemberNamingPolicy(Dictionary<string, string> map) : JsonNamingPolicy
    {
        public override string ConvertName(string name)
            => map.TryGetValue(name, out string? newName) ? newName : name;
    }
    
    public static string ToEnumString(TEnum value)
    {
        var name = Enum.GetName(typeof(TEnum), value);
        var enumMember = typeof(TEnum).GetField(name!)
            ?.GetCustomAttribute<EnumMemberAttribute>();
        return enumMember?.Value ?? name!;
    }
}
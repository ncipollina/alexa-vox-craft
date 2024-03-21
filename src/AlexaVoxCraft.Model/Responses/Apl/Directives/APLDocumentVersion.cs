using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Apl.Directives;

[JsonConverter(typeof(UnknownDocumentVersionConverter))]
public enum APLDocumentVersion
{
    [EnumMember(Value = "Unknown")]
    Unknown,
    [EnumMember(Value = "1.0")]
    V1,
    [EnumMember(Value = "1.1")]
    V1_1,
    [EnumMember(Value = "1.2")]
    V1_2,
    [EnumMember(Value = "1.3")]
    V1_3,
    [EnumMember(Value = "1.4")]
    V1_4,
    [EnumMember(Value = "1.5")]
    V1_5,
    [EnumMember(Value = "1.6")]
    V1_6,
    [EnumMember(Value = "1.7")]
    V1_7,
    [EnumMember(Value = "1.8")]
    V1_8,
    [EnumMember(Value = "1.9")]
    V1_9,
    [EnumMember(Value = "2022.1")]
    V2022_1,
    [EnumMember(Value = "2022.2")]
    V2022_2,
    [EnumMember(Value = "2023.1")]
    V2023_1,
    [EnumMember(Value = "2023.2")]
    V2023_2
}


public static class APLDocumentVersionExtensions
{
    internal static IDictionary<string, string> StringStringMaps = typeof(APLDocumentVersion)
        .GetFields(BindingFlags.Public | BindingFlags.Static)
        .Select(f => (f.Name, AttributeName: f.GetCustomAttribute<EnumMemberAttribute>()?.Value))
        .Where(pair => pair.AttributeName != null)
        .ToDictionary();

    internal static IDictionary<string, APLDocumentVersion> StringEnumMaps = typeof(APLDocumentVersion)
        .GetFields(BindingFlags.Public | BindingFlags.Static)
        .Select(f => (AttributeName: f.GetCustomAttribute<EnumMemberAttribute>()?.Value,
            (APLDocumentVersion)f.GetValue(null)))
        .Where(pair => pair.AttributeName != null)
        .ToDictionary();

    internal static IDictionary<APLDocumentVersion, string> EnumStringMaps = typeof(APLDocumentVersion)
        .GetFields(BindingFlags.Public | BindingFlags.Static)
        .Select(f => ((APLDocumentVersion)f.GetValue(null),
            f.GetCustomAttribute<EnumMemberAttribute>()?.Value ?? ((APLDocumentVersion)f.GetValue(null)).ToString()))
        .ToDictionary();

    public static string ToEnumString(this APLDocumentVersion aplDocumentVersion) =>
        EnumStringMaps.TryGetValue(aplDocumentVersion, out var output) ? output : APLDocumentVersion.Unknown.ToString();
    
    public static APLDocumentVersion ToEnum(this string str) => StringEnumMaps.TryGetValue(str, out var aplDocumentVersion)
        ? aplDocumentVersion
        : APLDocumentVersion.Unknown;

    public static string ToEnumString(this string str) => StringStringMaps.TryGetValue(str, out var outputString)
        ? outputString
        : APLDocumentVersion.Unknown.ToString();
}
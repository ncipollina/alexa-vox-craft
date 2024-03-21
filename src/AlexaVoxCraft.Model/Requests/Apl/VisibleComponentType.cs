using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Requests.Apl;

public enum VisibleComponentType
{
    [EnumMember(Value = "graphic")]
    Graphic,
    [EnumMember(Value = "text")]
    Text,
    [EnumMember(Value = "mixed")]
    Mixed,
    [EnumMember(Value = "video")]
    Video,
    [EnumMember(Value = "empty")]
    Empty
}
using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Apl.Audio;

public enum APLADocumentVersion
{
    Unknown,
    [EnumMember(Value="0.8")]
    V0_8,
    [EnumMember(Value = "0.9")]
    V0_9
}
using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Apl.Audio;

public enum AudioDuration
{
    [EnumMember(Value="auto")]
    Auto,
    [EnumMember(Value="trimToParent")]
    TrimToParent
}
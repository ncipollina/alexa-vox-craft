using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Apl;

public enum ScrollableTagDirection
{
    [EnumMember(Value="horizontal")]
    Horizontal,
    [EnumMember(Value="vertical")]
    Vertical
}
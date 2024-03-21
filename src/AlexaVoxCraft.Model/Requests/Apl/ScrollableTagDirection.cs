using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Requests.Apl;

public enum ScrollableTagDirection
{
    [EnumMember(Value="horizontal")]
    Horizontal,
    [EnumMember(Value="vertical")]
    Vertical
}
using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Commands;

public enum SetPagePosition
{
    [EnumMember(Value="absolute")]
    Absolute,
    [EnumMember(Value="relative")]
    Relative
}
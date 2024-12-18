using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Commands;

public enum HighlightMode
{
    [EnumMember(Value="line")]
    Line,
    [EnumMember(Value = "block")]
    Block
}
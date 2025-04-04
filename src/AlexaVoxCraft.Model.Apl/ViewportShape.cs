using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Apl;

public enum ViewportShape
{
    [EnumMember(Value="SQUARE")]
    Square,
    [EnumMember(Value = "RECTANGLE")]
    Rectangle,
    [EnumMember(Value = "ROUND")]
    Round
}
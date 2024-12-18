using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Commands;

public enum ItemAlignment
{
    [EnumMember(Value="first")]
    First,
    [EnumMember(Value = "center")]
    Center,
    [EnumMember(Value = "last")]
    Last,
    [EnumMember(Value = "visible")]
    Visible
}
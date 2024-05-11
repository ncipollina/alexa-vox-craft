using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Responses.Directives;

public enum UpdateBehavior
{
    [EnumMember(Value = "REPLACE")]
    Replace,
    [EnumMember(Value = "CLEAR")]
    Clear
}
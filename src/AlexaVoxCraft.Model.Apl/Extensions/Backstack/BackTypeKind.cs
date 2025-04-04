using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Apl.Extensions.Backstack;

public enum BackTypeKind
{
    [EnumMember(Value="count")]
    Count,
    [EnumMember(Value = "index")]
    Index,
    [EnumMember(Value = "id")]
    Id
}
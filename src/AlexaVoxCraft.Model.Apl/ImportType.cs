using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Apl;

public enum ImportType
{
    [EnumMember(Value="package")]
    Package,
    [EnumMember(Value = "oneOf")]
    OneOf,
    [EnumMember(Value = "allOf")]
    AllOf,
}
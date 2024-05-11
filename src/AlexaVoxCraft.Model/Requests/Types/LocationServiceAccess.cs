using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Requests.Types;

public enum LocationServiceAccess
{
    [EnumMember(Value = "ENABLED")]
    Enabled,
    [EnumMember(Value = "DISABLED")]
    Disabled
}
using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Apl.DataStore;

public enum TargetType
{
    [EnumMember(Value="DEVICES")]
    Devices,
    [EnumMember(Value="USER")]
    User
}
using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Requests.Types;

public enum LocationServiceStatus
{
    [EnumMember(Value = "RUNNING")]
    Running,
    [EnumMember(Value = "STOPPED")]
    Stopped
}
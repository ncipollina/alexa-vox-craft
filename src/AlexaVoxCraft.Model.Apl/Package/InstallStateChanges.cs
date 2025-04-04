using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Apl.Package;

public enum InstallStateChanges
{
    [EnumMember(Value="AUTOMATIC")]
    Automatic,
    [EnumMember(Value="INFORM")]
    Inform
}
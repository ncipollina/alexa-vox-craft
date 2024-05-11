using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Requests.Apl;

public enum MediaTagState
{
    [EnumMember(Value="idle")]
    Idle,
    [EnumMember(Value="paused")]
    Paused,
    [EnumMember(Value="playing")]
    Playing
}
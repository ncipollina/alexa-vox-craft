using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Apl.Extensions.SmartMotion;

public enum WakeWordResponse
{
    [EnumMember(Value="doNotMoveOnWakeWord")]
    DoNotMoveOnWakeWord,
    [EnumMember(Value="followOnWakeWord")]
    FollowOnWakeWord,
    [EnumMember(Value="turnToWakeWord")]
    TurnToWakeWord
}
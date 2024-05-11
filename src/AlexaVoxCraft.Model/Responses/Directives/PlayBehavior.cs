using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Responses.Directives;

public enum PlayBehavior
{
    [EnumMember(Value = "REPLACE_ALL")]
    ReplaceAll,
    [EnumMember(Value = "ENQUEUE")]
    Enqueue,
    [EnumMember(Value = "REPLACE_ENQUEUED")]
    ReplaceEnqueued
}
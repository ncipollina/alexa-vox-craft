using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Responses.Directives;

public enum ClearBehavior
{
    [EnumMember(Value = "CLEAR_ENQUEUED")]
    ClearEnqueued,
    [EnumMember(Value = "CLEAR_ALL")]
    ClearAll
}
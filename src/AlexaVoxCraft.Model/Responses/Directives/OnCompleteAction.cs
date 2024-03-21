using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Responses.Directives;

public enum OnCompleteAction
{
    [EnumMember(Value="RESUME_SESSION")]
    ResumeSession,
    [EnumMember(Value="SEND_ERRORS_ONLY")]
    SendErrorsOnly
}
using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Responses.Directives;

public enum ConsentLevel
{
    [EnumMember(Value = "ACCOUNT")]
    Account,
    [EnumMember(Value = "PERSON")]
    Person
}
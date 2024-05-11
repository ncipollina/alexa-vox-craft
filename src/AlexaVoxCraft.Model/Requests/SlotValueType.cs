using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Requests;

public enum SlotValueType
{
    [EnumMember(Value="Simple")]
    Simple,
    [EnumMember(Value="List")]
    List
}
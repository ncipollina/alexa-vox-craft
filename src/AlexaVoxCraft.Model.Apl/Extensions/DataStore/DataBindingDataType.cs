using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Apl.Extensions.DataStore;

public enum DataBindingDataType
{
    [EnumMember(Value="OBJECT")]
    Object,
    [EnumMember(Value="ARRAY")]
    Array
}
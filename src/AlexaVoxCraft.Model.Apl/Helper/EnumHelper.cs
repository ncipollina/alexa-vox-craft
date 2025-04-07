using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace AlexaVoxCraft.Model.Apl.Helper;

public static class EnumHelper
{
    public static bool TryParseEnumWithEnumMemberSupport(Type enumType, string? value, out object? result)
    {
        result = null;
        if (string.IsNullOrWhiteSpace(value) || !enumType.IsEnum)
            return false;

        foreach (var field in enumType.GetFields(BindingFlags.Public | BindingFlags.Static))
        {
            var attr = field.GetCustomAttribute<EnumMemberAttribute>();
            if ((attr?.Value ?? field.Name) == value)
            {
                result = Enum.Parse(enumType, field.Name);
                return true;
            }
        }

        return false;
    }

    // Optional generic wrapper
    public static bool TryParseEnumWithEnumMemberSupport<TEnum>(string? value, out TEnum result)
        where TEnum : struct, Enum
    {
        if (TryParseEnumWithEnumMemberSupport(typeof(TEnum), value, out var boxed))
        {
            result = (TEnum)boxed!;
            return true;
        }

        result = default;
        return false;
    }
}
﻿using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl;

namespace AlexaVoxCraft.Model.Serialization.Converters;

public class APLValueConverter<T> : JsonConverter<APLValue<T>>
{
    private static IList<JsonValueKind> _simpleTypes =
        [JsonValueKind.String, JsonValueKind.Number, JsonValueKind.False, JsonValueKind.True];
    public override APLValue<T>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null && (reader.TokenType != JsonTokenType.StartArray &&
                                                       reader.TokenType != JsonTokenType.StartObject))
        {
            return null;
        }

        var returnValue = new APLValue<T>();
        
        var genericType = typeToConvert.GetGenericArguments().First();

        genericType = Nullable.GetUnderlyingType(genericType) ?? genericType;

        using var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;

        if (_simpleTypes.Contains(root.ValueKind) && !TypeMatches(root.ValueKind, genericType))
        {
            returnValue.Expression = root.GetRawText();
        }
        else if (genericType == typeof(object))
        {
            returnValue.Value = (T)new ObjectConverter().Read(ref reader, typeToConvert, options);
        }
        else
        {
            returnValue.Value = (T)document.Deserialize(genericType, options);
        }

        return returnValue;
    }

    public override void Write(Utf8JsonWriter writer, APLValue<T> value, JsonSerializerOptions options)
    {
        var obj = !string.IsNullOrWhiteSpace(value.Expression) ? value.Expression : value.GetValue();
        JsonSerializer.Serialize(writer, obj, options);
    }

    private bool TypeMatches(JsonValueKind jsonValueKind, Type t)
    {
        return jsonValueKind switch
        {
            JsonValueKind.String when t.IsString() => true,
            JsonValueKind.False or JsonValueKind.True when typeof(bool) == t => true,
            JsonValueKind.Number when t.IsNumber() => true,
            _ => false
        };
    }

}

internal static partial class TypeExtensions
{
    internal static IList<Type> _numberTypes =
        [typeof(int), typeof(short), typeof(long), typeof(float), typeof(decimal)];
    internal static bool IsString(this Type type) => type == typeof(string) || type.IsEnum;

    internal static bool IsNumber(this Type type) => _numberTypes.Contains(type);
}

public class APLEnumerableValueConverter<TValue, TList> : JsonConverter<APLValue<TList>> where TList : IEnumerable<TValue>
{
    public override APLValue<TList>? Read(ref Utf8JsonReader reader, Type typeToConvert,
        JsonSerializerOptions options)
    {
        var returnValue = new APLValue<TList>();

        using var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;
        if (root.ValueKind == JsonValueKind.Object)
        {
            returnValue.Value = (TList)new List<TValue> { root.Deserialize<TValue>(options) }.AsEnumerable();
            returnValue.IsSingle = true;
        }
        else if (root.ValueKind == JsonValueKind.Array)
        {
            returnValue.Value = (TList)root.EnumerateArray()
                .Select(element => JsonSerializer.Deserialize<TValue>(element.GetRawText(), options))
                // The ToList() is required here to iterate the array as the JsonDcoument above will be disposed
                .ToList()
                .AsEnumerable();
        }
        else if (root.ValueKind == JsonValueKind.String)
        {
            returnValue.Expression = root.GetString();
        }
        else
        {
            throw new JsonException("Invalid JSON for Enumeration");
        }

        return returnValue;
    }

    public override void Write(Utf8JsonWriter writer, APLValue<TList> value, JsonSerializerOptions options)
    {
        if (value.IsSingle)
        {
            JsonSerializer.Serialize(writer, value.Value.First(), options);
        }
        else
        {
            JsonSerializer.Serialize(writer, value.Value, options);
        }
    }
}

public class APLDimensionValueConverter : JsonConverter<APLDimensionValue>
{
    public override APLDimensionValue? Read(ref Utf8JsonReader reader, Type typeToConvert,
        JsonSerializerOptions options)
    {
        return reader.TokenType == JsonTokenType.Number
            ? new APLDimensionValue(reader.GetInt32().ToString())
            : new APLDimensionValue(reader.GetString());
    }

    public override void Write(Utf8JsonWriter writer, APLDimensionValue value, JsonSerializerOptions options)
    {
        var obj = !string.IsNullOrWhiteSpace(value.Expression) ? value.Expression : value.GetValue();
        JsonSerializer.Serialize(writer, obj, options);

    }
}

public class APLAbsoluteDimensionValueConverter : JsonConverter<APLAbsoluteDimensionValue>
{
    public override APLAbsoluteDimensionValue? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.TokenType == JsonTokenType.Number
            ? new APLAbsoluteDimensionValue(reader.GetInt32().ToString())
            : new APLAbsoluteDimensionValue(reader.GetString());
    }

    public override void Write(Utf8JsonWriter writer, APLAbsoluteDimensionValue value, JsonSerializerOptions options)
    {
        var obj = !string.IsNullOrWhiteSpace(value.Expression) ? value.Expression : value.GetValue();
        JsonSerializer.Serialize(writer, obj, options);

    }
}

public class APLValueConverter : JsonConverterFactory
{
    private static Type _aplDimensionType = typeof(APLDimensionValue);
    private static Type _aplAbsoluteDimensionType = typeof(APLAbsoluteDimensionValue);
    private static Type _aplObjectType = typeof(APLValue<object>);
    private static List<Type> _dimensionTypes = [_aplDimensionType, _aplAbsoluteDimensionType, _aplObjectType];

    public override bool CanConvert(Type typeToConvert)
    {
        if (_dimensionTypes.Contains(typeToConvert))
            return true;

        if (!typeToConvert.IsGenericType)
            return false;

        if (typeToConvert.GetGenericTypeDefinition() != typeof(APLValue<>))
            return false;

        return true;
    }

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        if (_dimensionTypes.Contains(typeToConvert))
        {
            return typeToConvert switch
            {
                var t when t == _aplDimensionType => new APLDimensionValueConverter(),
                var t when t == _aplAbsoluteDimensionType => new APLAbsoluteDimensionValueConverter(),
                var t when t == _aplObjectType => new APLObjectConverter(),
                _ => throw new JsonException("Should never happen!")
            };
        }

        var typeArguments = typeToConvert.GetGenericArguments();
        var valueType = typeArguments[0];

        if (valueType.IsGenericType && valueType.IsEnumerableOfType())
        {
            var innerValueType = valueType.GetGenericArguments().First();
            return (JsonConverter)Activator.CreateInstance(
                typeof(APLEnumerableValueConverter<,>).MakeGenericType(innerValueType, valueType),
                BindingFlags.Instance | BindingFlags.Public,
                binder: null,
                args: null,
                culture: null);

        }

        var converter = (JsonConverter)Activator.CreateInstance(
            typeof(APLValueConverter<>).MakeGenericType(valueType), BindingFlags.Instance | BindingFlags.Public,
            binder: null,
            args: null,
            culture: null);

        return converter;
    }
}

internal static partial class TypeExtensions
{
    internal static bool IsEnumerableOfType(this Type type) =>
        type.GetGenericTypeDefinition() == typeof(IEnumerable<>) || type.GetInterfaces().Any(i =>
            i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IEnumerable<>) &&
            i.GetGenericArguments().First() == type.GetGenericArguments().First());
}
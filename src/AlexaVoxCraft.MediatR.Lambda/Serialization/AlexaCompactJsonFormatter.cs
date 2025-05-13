using System.Text;
using System.Text.Json;
using Serilog.Events;
using Serilog.Formatting;
using Serilog.Formatting.Compact;

namespace AlexaVoxCraft.MediatR.Lambda.Serialization;

public sealed class AlexaCompactJsonFormatter : ITextFormatter
{
    private static readonly CompactJsonFormatter Inner = new();

    public void Format(LogEvent logEvent, TextWriter output)
    {
        // Step 1: Render to raw UTF-8 JSON
        using var stream = new MemoryStream();
        using var intermediateWriter = new StreamWriter(stream, Encoding.UTF8, leaveOpen: true);
        Inner.Format(logEvent, intermediateWriter);
        intermediateWriter.Flush();

        // Step 2: Parse and rewrite using Utf8JsonReader
        stream.Position = 0;
        var reader = new Utf8JsonReader(stream.ToArray(), isFinalBlock: true, new JsonReaderState());

        using var rewrittenStream = new MemoryStream();
        using var jsonWriter = new Utf8JsonWriter(rewrittenStream, new JsonWriterOptions
        {
            Indented = false,
            SkipValidation = true
        });

        RewriteKeys(ref reader, jsonWriter);
        jsonWriter.Flush();

        // Step 3: Write the rewritten result to the original TextWriter
        rewrittenStream.Position = 0;
        using var finalReader = new StreamReader(rewrittenStream, Encoding.UTF8);
        output.Write(finalReader.ReadToEnd());
    }

    private void RewriteKeys(ref Utf8JsonReader reader, Utf8JsonWriter writer)
    {
        while (reader.Read())
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.StartObject:
                    writer.WriteStartObject();
                    break;

                case JsonTokenType.EndObject:
                    writer.WriteEndObject();
                    break;

                case JsonTokenType.StartArray:
                    writer.WriteStartArray();
                    break;

                case JsonTokenType.EndArray:
                    writer.WriteEndArray();
                    break;

                case JsonTokenType.PropertyName:
                    var propertyName = reader.GetString();
                    if (propertyName is { } name && name.StartsWith("@"))
                    {
                        name = "_" + name[1..];
                    }
                    else
                    {
                        name = propertyName;
                    }

                    writer.WritePropertyName(name);
                    break;

                default:
                    writer.WriteTokenValue(reader);
                    break;
            }
        }
    }
}

// Extension to reduce duplication for values
internal static class Utf8JsonWriterExtensions
{
    public static void WriteTokenValue(this Utf8JsonWriter writer, Utf8JsonReader reader)
    {
        switch (reader.TokenType)
        {
            case JsonTokenType.String:
                writer.WriteStringValue(reader.GetString());
                break;
            case JsonTokenType.Number:
                if (reader.TryGetInt64(out var l))
                    writer.WriteNumberValue(l);
                else
                    writer.WriteNumberValue(reader.GetDouble());
                break;
            case JsonTokenType.True:
            case JsonTokenType.False:
                writer.WriteBooleanValue(reader.GetBoolean());
                break;
            case JsonTokenType.Null:
                writer.WriteNullValue();
                break;
            case JsonTokenType.None:
            case JsonTokenType.StartObject:
            case JsonTokenType.EndObject:
            case JsonTokenType.StartArray:
            case JsonTokenType.EndArray:
            case JsonTokenType.PropertyName:
            case JsonTokenType.Comment:
                break;
            default:
                throw new InvalidOperationException($"Unsupported token: {reader.TokenType}");
        }
    }
}
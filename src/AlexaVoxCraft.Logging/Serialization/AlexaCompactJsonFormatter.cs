using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using Serilog.Events;
using Serilog.Formatting;
using Serilog.Formatting.Compact;

namespace AlexaVoxCraft.Logging.Serialization;

public sealed class AlexaCompactJsonFormatter : ITextFormatter
{
    private readonly ITextFormatter _inner;

    public AlexaCompactJsonFormatter(ITextFormatter? inner = null)
    {
        _inner = inner ?? new CompactJsonFormatter();
    }

    public void Format(LogEvent logEvent, TextWriter output)
    {
        try
        {
            // Render original compact JSON into a byte buffer
            using var renderBuffer = new MemoryStream();
            using var renderWriter = new StreamWriter(renderBuffer, new UTF8Encoding(false), leaveOpen: true);
            _inner.Format(logEvent, renderWriter);
            renderWriter.Flush();

            var originalBytes = renderBuffer.ToArray();
            var reader = new Utf8JsonReader(originalBytes, isFinalBlock: true, new JsonReaderState());

            // Rewrite field names into a second buffer
            using var rewrittenBuffer = new MemoryStream();
            using var jsonWriter = new Utf8JsonWriter(rewrittenBuffer, new JsonWriterOptions
            {
                Indented = false,
                SkipValidation = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });

            RewriteKeys(ref reader, jsonWriter);
            jsonWriter.Flush();

            // Write the transformed UTF-8 bytes as string to the sink's TextWriter
            var rewrittenJson = Encoding.UTF8.GetString(rewrittenBuffer.ToArray());
        
            output.Write(rewrittenJson);
            output.WriteLine();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
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
                    if (propertyName.StartsWith("@"))
                        propertyName = "_" + propertyName[1..];

                    writer.WritePropertyName(propertyName);
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
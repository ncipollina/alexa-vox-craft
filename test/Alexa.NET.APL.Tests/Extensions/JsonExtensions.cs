using System.Text.Json;
using System.Text.Json.Nodes;

namespace Alexa.NET.APL.Tests.Extensions;

public static class JsonExtensions
{
    public static JsonObject AsObjectNode(this JsonElement element)
    {
        return JsonNode.Parse(element.GetRawText())!.AsObject();
    }
}
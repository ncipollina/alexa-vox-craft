using System.Text.Json;
using System.Text.Json.JsonDiffPatch;
using System.Text.Json.Nodes;
using AlexaVoxCraft.Model.Serialization;

namespace AlexaVoxCraft.Tests.Fixtures.Utilities;

public static class Utility
{
    private static readonly string ExamplesPath = "Examples";
    private static readonly string ModelPath = "Model";
    private static readonly string[] BasePath = [ModelPath, ExamplesPath];

    private static JsonSerializerOptions? Options = new(AlexaJsonOptions.DefaultOptions);

    public static bool CompareJson(object actual, params string[] filename)
    {
        var actualString = JsonSerializer.Serialize(actual, Options);
        var actualDocument = JsonNode.Parse(actualString);
        var expected = File.ReadAllText(Path.Combine(BasePath.Concat(filename).ToArray()));
        var expectedDocument = JsonNode.Parse(expected);
        return actualDocument.DeepEquals(expectedDocument);
    }

    public static bool CompareObjectJson(object? actual, object expected)
    {
        var actualDocument = JsonNode.Parse(JsonSerializer.Serialize(actual, Options));
        var expectedDocument = JsonNode.Parse(JsonSerializer.Serialize(expected, Options));
        return actualDocument.DeepEquals(expectedDocument);
    }
}
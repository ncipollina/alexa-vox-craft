using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using AlexaVoxCraft.Model.Apl;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using AlexaVoxCraft.Model.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Alexa.NET.APL.Tests;

public static class Utility
{
    private const string ExamplesPath = "Examples";

    public static bool CompareJson(object actual, string expectedFile, params string[] exclude)
    {
        var actualJObject = JObject.FromObject(actual);
        var expected = File.ReadAllText(Path.Combine(ExamplesPath, expectedFile));
        var expectedJObject = JObject.Parse(expected);

        foreach (var item in exclude)
        {
            RemoveFrom(actualJObject, item);
            RemoveFrom(expectedJObject, item);
        }

        var result = JToken.DeepEquals(expectedJObject, actualJObject);

        if (!result)
        {
            OutputTrimEqual(expectedJObject, actualJObject);
        }

        return result;
    }

    private static void OutputTrimEqual(JObject expectedJObject, JObject actualJObject, bool output = true)
    {
        if (expectedJObject == null || actualJObject == null)
        {
            if (output)
            {
                Console.WriteLine(expectedJObject?.ToString());
                Console.WriteLine(actualJObject?.ToString());
            }

            return;
        }

        foreach (var prop in actualJObject.Properties().ToArray())
        {
            if (JToken.DeepEquals(actualJObject[prop.Name], expectedJObject[prop.Name]))
            {
                actualJObject.Remove(prop.Name);
                expectedJObject.Remove(prop.Name);
            }
        }

        foreach (var prop in actualJObject.Properties().Where(p => p.Value is JObject).Select(p => new { name = p.Name, value = p.Value as JObject }).ToArray())
        {
            OutputTrimEqual(prop.value, expectedJObject[prop.name]?.Value<JObject>(), false);
        }

        if (output)
        {
            Console.WriteLine(expectedJObject.ToString());
            Console.WriteLine(actualJObject.ToString());
        }
    }

    private static void RemoveFrom(JObject exclude, string item)
    {
        if (exclude.ContainsKey(item))
        {
            exclude.Remove(item);
        }

        foreach (var prop in exclude.Properties().Where(p => p.Value is JObject).Select(p => p.Value)
                     .Cast<JObject>())
        {
            RemoveFrom(prop, item);
        }

        foreach (var prop in exclude.Properties().Where(p => p.Value is JArray).Select(p => p.Value).Cast<JArray>().SelectMany(a => a.Children())
                     .Where(c => c.Type == JTokenType.Object).Cast<JObject>())
        {
            RemoveFrom(prop, item);
        }
    }

    public static T ExampleFileContent<T>(string expectedFile)
    {
        APLSupport.Add();
        var json = ExampleFileContent(expectedFile);
        return System.Text.Json.JsonSerializer.Deserialize<T>(json, AlexaJsonOptions.DefaultOptions);
    }

    public static string ExampleFileContent(string expectedFile)
    {
        return File.ReadAllText(Path.Combine(ExamplesPath, expectedFile));
    }

    public static T AssertComponent<T>(string expectedFile) where T : APLComponent
    {
        var component = AssertSerialization<T>(expectedFile);
        if (component.Properties != null)
        {
            component.Properties.Remove("type");
            Assert.Empty(component.Properties);
        }
        else
        {
            Assert.Null(component.Properties);
        }

        return component;
    }

    public static T AssertSerialization<T>(string expectedFile)
    {
        APLComponentConverter.ThrowConversionExceptions = true;
        var obj = ExampleFileContent<T>(expectedFile);
        Assert.True(CompareJson(obj, expectedFile));
        return obj;
    }

    public static void AssertSerialization<TImplied, TExplicit>(string expectedFile)
    {
        APLComponentConverter.ThrowConversionExceptions = true;
        var obj = ExampleFileContent<TImplied>(expectedFile);
        var final = Assert.IsType<TExplicit>(obj);
        Assert.True(CompareJson(final, expectedFile));
    }
        
    public static bool JsonElementDeepEquals(this JsonElement a, JsonElement b, string path = "",
        List<string>? diffs = null)
    {
        diffs ??= [];

        if (a.ValueKind != b.ValueKind)
        {
            diffs.Add($"{path}: Type mismatch ({a.ValueKind} != {b.ValueKind})");
            return false;
        }

        switch (a.ValueKind)
        {
            case JsonValueKind.Object:
                var aProps = a.EnumerateObject().OrderBy(p => p.Name).ToList();
                var bProps = b.EnumerateObject().OrderBy(p => p.Name).ToList();
                if (aProps.Count != bProps.Count)
                {
                    diffs.Add($"{path}: Property count mismatch");
                    return false;
                }

                for (var i = 0; i < aProps.Count; i++)
                {
                    var name = aProps[i].Name;
                    var subPath = string.IsNullOrEmpty(path) ? name : $"{path}.{name}";
                    if (name != bProps[i].Name ||
                        !JsonElementDeepEquals(aProps[i].Value, bProps[i].Value, subPath, diffs))
                        return false;
                }

                return true;

            case JsonValueKind.Array:
                var aArray = a.EnumerateArray().ToList();
                var bArray = b.EnumerateArray().ToList();
                if (aArray.Count != bArray.Count)
                {
                    diffs.Add($"{path}: Array length mismatch");
                    return false;
                }

                return !aArray.Where((t, i) => !JsonElementDeepEquals(t, bArray[i], $"{path}[{i}]", diffs)).Any();

            default:
                var equal = a.ToString() == b.ToString();
                if (!equal)
                {
                    diffs.Add($"{path}: Value mismatch '{a}' != '{b}'");
                }

                return equal;
        }
    }
}
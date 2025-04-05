﻿using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization;

namespace AlexaVoxCraft.Model.Apl.DataSources;

public class DynamicIndexList : APLDataSource
{
    public DynamicIndexList()
    {
    }

    public DynamicIndexList(string listId, int startIndex = 0)
    {
        ListId = listId;
        StartIndex = startIndex;
    }

    public const string DataSourceType = "dynamicIndexList";
    public override string Type => DataSourceType;

    [JsonPropertyName("listId")] public string ListId { get; set; }

    [JsonPropertyName("startIndex")] public int StartIndex { get; set; }

    [JsonPropertyName("minimumInclusiveIndex")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int MinimumInclusiveIndex { get; set; }

    [JsonPropertyName("maximumExclusiveIndex")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int MaximumExclusiveIndex { get; set; }

    [JsonPropertyName("items")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IList<object>? Items { get; set; } = new List<object>();

    public static void AddSupport()
    {
        AlexaJsonOptions.RegisterTypeModifier<DynamicIndexList>(info =>
        {
            var prop = info.Properties.FirstOrDefault(p => p.Name == "items");
            if (prop is not null)
            {
                prop.ShouldSerialize = (obj, _) =>
                {
                    var dynamicIndexList = (DynamicIndexList)obj;
                    return dynamicIndexList.Items?.Any() ?? false;
                };
            }
        });
    }
}
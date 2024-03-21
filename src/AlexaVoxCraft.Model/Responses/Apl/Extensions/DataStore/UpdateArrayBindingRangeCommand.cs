using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;

namespace AlexaVoxCraft.Model.Responses.Apl.Extensions.DataStore;

public class UpdateArrayBindingRangeCommand : APLCommand
{
    private readonly string _extensionName;

    public static UpdateArrayBindingRangeCommand For(DataStoreExtension extension)
    {
        return new UpdateArrayBindingRangeCommand(extension.Name);
    }

    public static UpdateArrayBindingRangeCommand For(DataStoreExtension extension, APLValue<string> dataBindingName,
        APLValue<int?> startIndex, APLValue<int?> endIndex)
    {
        return new UpdateArrayBindingRangeCommand(extension.Name, dataBindingName, startIndex, endIndex);
    }

    public UpdateArrayBindingRangeCommand(string extensionName)
    {
        _extensionName = extensionName;
    }

    public UpdateArrayBindingRangeCommand(string extensionName, APLValue<string> dataBindingName,
        APLValue<int?> startIndex, APLValue<int?> endIndex) : this(extensionName)
    {
        DataBindingName = dataBindingName;
        StartIndex = startIndex;
        EndIndex = endIndex;
    }

    [JsonPropertyName("dataBindingName"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> DataBindingName { get; set; }

    [JsonPropertyName("startIndex"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<int?> StartIndex { get; set; }

    [JsonPropertyName("endIndex"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<int?> EndIndex { get; set; }

    [JsonPropertyName("type")]
    [JsonInclude]
    public override string Type => $"{_extensionName}:UpdateArrayBindingRange";
}
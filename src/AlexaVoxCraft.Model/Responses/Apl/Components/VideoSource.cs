using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Apl.Components;

public class VideoSource
{
    [JsonPropertyName("url")] public APLValue<Uri> Uri { get; set; }

    [JsonPropertyName("description"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<string> Description { get; set; }

    [JsonPropertyName("duration"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<int?> DurationMilliseconds { get; set; }

    [JsonPropertyName("repeatCount"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<int?> RepeatCount { get; set; }

    [JsonPropertyName("offset"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<int?> Offset { get; set; }

    [JsonPropertyName("textTrack"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public APLValue<IEnumerable<TextTrack>> TextTrack { get; set; }

    public static IEnumerable<VideoSource> FromUrl(string url)
    {
        return [new(url)];
    }

    public List<VideoSource> FromUrl(IEnumerable<string> urls)
    {
        return urls.Select(u => new VideoSource(u)).ToList();
    }

    public VideoSource()
    {
    }

    public VideoSource(string url)
    {
        Uri = new Uri(url);
    }
}
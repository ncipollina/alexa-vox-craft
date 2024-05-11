using AlexaVoxCraft.Model.Responses.Directives;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Responses.Directives;

public class VideoAppDirectiveTests
{
    [Fact]
    public void Create_Video_App_Directive()
    {
        var videoItem = new VideoItem
        {
            Source = "https://www.example.com/video/sample-video-1.mp4",
            Metadata = new VideoItemMetadata
            {
                Title = "Title for Sample Video",
                Subtitle = "Secondary Title for Sample Video"
            }
        };
        var actual = new VideoAppDirective { VideoItem = videoItem };

        Utility.CompareJson(actual, "VideoAppDirectiveWithMetadata.json").Should().BeTrue();

    }
    
    [Fact]
    public void Create_VideoAppDirective_FromSource()
    {
        var actual = new VideoAppDirective
            { VideoItem = new() { Source = "https://www.example.com/video/sample-video-1.mp4" } };
        Utility.CompareJson(actual, "VideoAppDirective.json").Should().BeTrue();
    }
}
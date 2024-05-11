using AlexaVoxCraft.Model.Responses;
using AlexaVoxCraft.Model.Responses.Directives;
using AlexaVoxCraft.Tests.Fixtures.Attributes;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Responses.Directives;

public class AudioPlayerDirectiveTests
{
    [Fact]
    public void AudioPlayerGeneratesCorrectJson()
    {
        var directive = new AudioPlayerPlayDirective
        {
            PlayBehavior = PlayBehavior.Enqueue,
            AudioItem = new AudioItem
            {
                Stream = new AudioItemStream
                {
                    Url = "https://url-of-the-stream-to-play",
                    Token = "opaque token representing this stream",
                    ExpectedPreviousToken = "opaque token representing the previous stream"
                }
            }
        };
        Utility.CompareJson(directive, "AudioPlayerWithoutMetadata.json").Should().BeTrue();
    }

    [Fact]
    public void AudioPlayerWithMetadataGeneratesCorrectJson()
    {
        var directive = new AudioPlayerPlayDirective
        {
            PlayBehavior = PlayBehavior.Enqueue,
            AudioItem = new AudioItem
            {
                Stream = new AudioItemStream
                {
                    Url = "https://url-of-the-stream-to-play",
                    Token = "opaque token representing this stream",
                    ExpectedPreviousToken = "opaque token representing the previous stream"
                },
                Metadata = new AudioItemMetadata
                {
                    Title = "title of the track to display",
                    Subtitle = "subtitle of the track to display",
                    Art = new AudioItemSources
                    {
                        Sources = new[] { new AudioItemSource { Url = "https://url-of-the-album-art-image.png" } }
                            .ToList()
                    },
                    BackgroundImage = new AudioItemSources
                    {
                        Sources = new[] { new AudioItemSource { Url = "https://url-of-the-background-image.png" } }
                            .ToList()
                    }
                }
            }
        };
        Utility.CompareJson(directive, "AudioPlayerWithMetadata.json").Should().BeTrue();
    }

    [Theory, ModelAutoData(typeof(Directive), "AudioPlayerWithMetadata.json")]
    public void AudioPlayerWithMetadataDeserializesCorrectly(Directive directive)
    {
        var audioPlayer = directive.Should().NotBeNull().And.BeOfType<AudioPlayerPlayDirective>().Subject;
        audioPlayer.AudioItem.Metadata.Title.Should().Be("title of the track to display");
        audioPlayer.AudioItem.Metadata.Subtitle.Should().Be("subtitle of the track to display");
        audioPlayer.AudioItem.Metadata.Art.Sources.Should().ContainSingle();
        audioPlayer.AudioItem.Metadata.BackgroundImage.Sources.Should().ContainSingle();
        audioPlayer.AudioItem.Metadata.Art.Sources.First().Url.Should().Be("https://url-of-the-album-art-image.png");
        audioPlayer.AudioItem.Metadata.BackgroundImage.Sources.First().Url.Should()
            .Be("https://url-of-the-background-image.png");
        audioPlayer.AudioItem.Stream.Url.Should().Be("https://url-of-the-stream-to-play");
        audioPlayer.AudioItem.Stream.Token.Should().Be("opaque token representing this stream");
        audioPlayer.AudioItem.Stream.ExpectedPreviousToken.Should().Be("opaque token representing the previous stream");
        audioPlayer.AudioItem.Stream.OffsetInMilliseconds.Should().Be(0);
    }

    [Theory, ModelAutoData(typeof(Directive), "AudioPlayerWithoutMetadata.json")]
    public void AudioPlayerIgnoresMetadataWhenNull(Directive directive)
    {
        var audioPlayer = directive.Should().NotBeNull().And.BeOfType<AudioPlayerPlayDirective>().Subject;
        audioPlayer.AudioItem.Metadata.Should().BeNull();
        audioPlayer.AudioItem.Stream.Url.Should().Be("https://url-of-the-stream-to-play");
    }

}
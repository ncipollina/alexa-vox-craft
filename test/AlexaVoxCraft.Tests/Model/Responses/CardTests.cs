using AlexaVoxCraft.Model.Responses;
using AlexaVoxCraft.Tests.Fixtures.Attributes;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Responses;

public class CardTests
{
    private const string ExampleTitle = "Example Title";
    private const string ExampleBodyText = "Example Body Text";

    [Fact]
    public void Create_Valid_SimpleCard()
    {
        var actual = new SimpleCard
        {
            Title = ExampleTitle,
            Content = ExampleBodyText
        };

        Utility.CompareJson(actual, "SimpleCard.json").Should().BeTrue();
    }
    
    [Fact]
    public void Creates_Valid_StandardCard()
    {
        var cardImages = new CardImage { SmallImageUrl = "https://example.com/smallImage.png", LargeImageUrl = "https://example.com/largeImage.png" };
        var actual = new StandardCard{ Title = ExampleTitle, Content = ExampleBodyText,Image=cardImages };

        Utility.CompareJson(actual, "StandardCard.json").Should().BeTrue();
    }
    
    [Fact]
    public void Creates_Valid_AskForPermissionConsent()
    {
        var actual = new AskForPermissionsConsentCard();
        actual.Permissions.Add(RequestedPermission.ReadHouseholdList);
        actual.Permissions.Add(RequestedPermission.WriteHouseholdList);

        Utility.CompareJson(actual, "AskForPermissionsConsent.json").Should().BeTrue();
    }

    [Theory, ModelAutoData(typeof(Card), "SimpleCard.json")]
    public void Can_Deserialize_SimpleCard_Json(Card card)
    {
        var simpleCard = card.Should().NotBeNull().And.BeOfType<SimpleCard>().Subject;

        simpleCard.Title.Should().Be(ExampleTitle);
        simpleCard.Content.Should().Be(ExampleBodyText);
    }

    [Theory, ModelAutoData(typeof(Card), "StandardCard.json")]
    public void Can_Deserialize_StandardCard_Json(Card card)
    {
        var standardCard = card.Should().NotBeNull().And.BeOfType<StandardCard>().Subject;

        standardCard.Title.Should().Be(ExampleTitle);
        standardCard.Content.Should().Be(ExampleBodyText);
        standardCard.Image.SmallImageUrl.Should().Be("https://example.com/smallImage.png");
        standardCard.Image.LargeImageUrl.Should().Be("https://example.com/largeImage.png");
    }

    [Theory, ModelAutoData(typeof(Card), "LinkAccountCard.json")]
    public void Can_Deserialize_LinkAccountCard_Json(Card card)
    {
        card.Should().NotBeNull().And.BeOfType<LinkAccountCard>();
    }
    
    [Theory, ModelAutoData(typeof(Card), "AskForPermissionsConsent.json")]
    public void Can_Deserialize_AskForPermissionCard_Json(Card card)
    {
        var askForPermissionCard = card.Should().NotBeNull().And.BeOfType<AskForPermissionsConsentCard>().Subject;

        askForPermissionCard.Permissions.Should().HaveCount(2);
        askForPermissionCard.Permissions.First().Should().NotBe(RequestedPermission.FullAddress);
        askForPermissionCard.Permissions.First().Should().Be(RequestedPermission.ReadHouseholdList);
        askForPermissionCard.Permissions.Last().Should().Be(RequestedPermission.WriteHouseholdList);
    }
}
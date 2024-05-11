using AlexaVoxCraft.Model.Requests;
using AlexaVoxCraft.Model.Responses;
using AlexaVoxCraft.Model.Responses.Directives;
using AlexaVoxCraft.Tests.Fixtures.Attributes;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Responses.Directives;

public class DialogDirectiveTests
{
    [Fact]
    public void Create_Valid_DialogDelegateDirective()
    {
        var actual = new DialogDelegate { UpdatedIntent = GetUpdatedIntent() };

        Utility.CompareJson(actual, "DialogDelegate.json").Should().BeTrue();
    }

    [Fact]
    public void Create_Valid_DialogElicitSlotDirective()
    {
        var actual = new DialogElicitSlot()
        {
            SlotName = "ZodiacSign",
            UpdatedIntent = GetUpdatedIntent()
        };

        Utility.CompareJson(actual, "DialogElicitSlot.json").Should().BeTrue();
    }

    [Fact]
    public void Create_Valid_DialogConfirmSlotDirective()
    {
        var actual = new DialogConfirmSlot()
        {
            SlotName = "Date",
            UpdatedIntent = GetUpdatedIntent()
        };

        Utility.CompareJson(actual, "DialogConfirmSlot.json").Should().BeTrue();
    }

    [Fact]
    public void Create_Valid_DialogConfirmIntentDirective()
    {
        var actual = new DialogConfirmIntent { UpdatedIntent = GetUpdatedIntent() };
        actual.UpdatedIntent.Slots["ZodiacSign"].ConfirmationStatus = ConfirmationStatus.Confirmed;

        Utility.CompareJson(actual, "DialogConfirmIntent.json").Should().BeTrue();
    }

    [Fact]
    public void Create_Valid_DialogDynamicEntityDirective()
    {
        var actual = new DialogUpdateDynamicEntities { UpdateBehavior = UpdateBehavior.Replace };
        var airportSlotType = new SlotType
        {
            Name = "AirportSlotType",
            Values =
            [
                new SlotTypeValue
                {
                    Id = "BOS",
                    Name = new SlotTypeValueName
                    {
                        Value = "Logan International Airport",
                        Synonyms = ["Boston Logan"]
                    }
                },
                new SlotTypeValue
                {
                    Id = "LGA",
                    Name = new SlotTypeValueName
                    {
                        Value = "LaGuardia Airport",
                        Synonyms = ["New York"]
                    }
                }
            ]
        };
        actual.Types.Add(airportSlotType);
        Utility.CompareJson(actual, "DialogDynamicEntity.json").Should().BeTrue();
    }

    [Theory, ModelAutoData(typeof(Directive), "DialogConfirmIntent.json")]
    public void Can_Deserialize_DialogConfirmIntent_Json(Directive directive)
    {
        var dialogConfirmIntent = directive.Should().NotBeNull().And.BeOfType<DialogConfirmIntent>().Subject;

        dialogConfirmIntent.UpdatedIntent.Name.Should().Be("GetZodiacHoroscopeIntent");
        dialogConfirmIntent.UpdatedIntent.ConfirmationStatus.Should().Be(ConfirmationStatus.None);

        var slot1 = dialogConfirmIntent.UpdatedIntent.Slots.Should().Contain(s => s.Key == "ZodiacSign").Subject.Value;
        slot1.Name.Should().Be("ZodiacSign");
        slot1.Value.Should().Be("virgo");
        slot1.ConfirmationStatus.Should().Be(ConfirmationStatus.Confirmed);
        
        var slot2 = dialogConfirmIntent.UpdatedIntent.Slots.Should().Contain(s => s.Key == "Date").Subject.Value;
        slot2.Name.Should().Be("Date");
        slot2.Value.Should().Be("2015-11-25");
        slot2.ConfirmationStatus.Should().Be(ConfirmationStatus.Confirmed);
    }

    [Theory, ModelAutoData(typeof(Directive), "DialogConfirmSlot.json")]
    public void Can_Deserialize_DialogConfirmSlot_Json(Directive directive)
    {
        var dialogConfirmSlot = directive.Should().NotBeNull().And.BeOfType<DialogConfirmSlot>().Subject;

        dialogConfirmSlot.SlotName.Should().Be("Date");
        dialogConfirmSlot.UpdatedIntent.Name.Should().Be("GetZodiacHoroscopeIntent");

        var slot1 = dialogConfirmSlot.UpdatedIntent.Slots.Should().Contain(s => s.Key == "ZodiacSign").Subject.Value;
        slot1.Name.Should().Be("ZodiacSign");
        slot1.Value.Should().Be("virgo");
        
        var slot2 = dialogConfirmSlot.UpdatedIntent.Slots.Should().Contain(s => s.Key == "Date").Subject.Value;
        slot2.Name.Should().Be("Date");
        slot2.Value.Should().Be("2015-11-25");
        slot2.ConfirmationStatus.Should().Be(ConfirmationStatus.Confirmed);
    }

    [Theory, ModelAutoData(typeof(Directive), "DialogDelegate.json")]
    public void Can_Deserialize_DialogDelegate_Json(Directive directive)
    {
        var dialogDelegate = directive.Should().NotBeNull().And.BeOfType<DialogDelegate>().Subject;

        dialogDelegate.UpdatedIntent.Name.Should().Be("GetZodiacHoroscopeIntent");
        dialogDelegate.UpdatedIntent.ConfirmationStatus.Should().Be(ConfirmationStatus.None);

        var slot1 = dialogDelegate.UpdatedIntent.Slots.Should().Contain(s => s.Key == "ZodiacSign").Subject.Value;
        slot1.Name.Should().Be("ZodiacSign");
        slot1.Value.Should().Be("virgo");
        
        var slot2 = dialogDelegate.UpdatedIntent.Slots.Should().Contain(s => s.Key == "Date").Subject.Value;
        slot2.Name.Should().Be("Date");
        slot2.Value.Should().Be("2015-11-25");
        slot2.ConfirmationStatus.Should().Be(ConfirmationStatus.Confirmed);
    }

    [Theory, ModelAutoData(typeof(Directive), "DialogElicitSlot.json")]
    public void Can_Deserialize_DialogElicitSlot_Json(Directive directive)
    {
        var dialogElicitSlot = directive.Should().NotBeNull().And.BeOfType<DialogElicitSlot>().Subject;

        dialogElicitSlot.SlotName.Should().Be("ZodiacSign");
        dialogElicitSlot.UpdatedIntent.Name.Should().Be("GetZodiacHoroscopeIntent");
        dialogElicitSlot.UpdatedIntent.ConfirmationStatus.Should().Be(ConfirmationStatus.None);

        var slot1 = dialogElicitSlot.UpdatedIntent.Slots.Should().Contain(s => s.Key == "ZodiacSign").Subject.Value;
        slot1.Name.Should().Be("ZodiacSign");
        slot1.Value.Should().Be("virgo");
        
        var slot2 = dialogElicitSlot.UpdatedIntent.Slots.Should().Contain(s => s.Key == "Date").Subject.Value;
        slot2.Name.Should().Be("Date");
        slot2.Value.Should().Be("2015-11-25");
        slot2.ConfirmationStatus.Should().Be(ConfirmationStatus.Confirmed);
    }

    private Intent GetUpdatedIntent()
    {
        return new Intent
        {
            Name = "GetZodiacHoroscopeIntent",
            ConfirmationStatus = ConfirmationStatus.None,
            Slots = new Dictionary<string, Slot>
            {
                { "ZodiacSign", new Slot { Name = "ZodiacSign", Value = "virgo" } },
                {
                    "Date",
                    new Slot { Name = "Date", Value = "2015-11-25", ConfirmationStatus = ConfirmationStatus.Confirmed }
                }
            }
        };
    }
}
using AlexaVoxCraft.Model.Requests;

namespace AlexaVoxCraft.Tests.Model.Requests;

public class IntentTests
{
	[Fact]
	public void Intent_action_set_string()
	{
		var expected = "CancelIntent";
		IntentSignature name = expected;

		expected.Should().Be(name.Action);
	}

	[Fact]
	public void Namespace_and_action_set_string()
	{
		IntentSignature name = "AMAZON.CancelIntent";

		name.Namespace.Should().Be("AMAZON");
		name.Action.Should().Be("CancelIntent");
	}

	[Fact]
	public void Complex_intent_single_property()
	{
		const string complexIntentSingleProperty = "AMAZON.SearchAction<object@WeatherForecast>";
		IntentSignature name = complexIntentSingleProperty;

		name.Namespace.Should().Be("AMAZON");
		name.Action.Should().Be("SearchAction");
		name.Properties.Should().ContainSingle();
		name.Properties.Should().ContainKey("object").WhoseValue.Entity.Should().Be("WeatherForecast");
	}

	[Fact]
	public void Complex_intent_two_properties()
	{
		const string complexIntentTwoProperties = "AMAZON.AddAction<object@Book,targetCollection@ReadingList>";

		IntentSignature name = complexIntentTwoProperties;

		name.Namespace.Should().Be("AMAZON");
		name.Action.Should().Be("AddAction");
		name.Properties.Should().HaveCount(2);
		name.Properties.Should().ContainKey("object").WhoseValue.Entity.Should().Be("Book");
		name.Properties.Should().ContainKey("targetCollection").WhoseValue.Entity.Should().Be("ReadingList");
	}

	[Fact]
	public void Complex_with_entity_property()
	{
		const string complexIntentWithEntityProperty = "AMAZON.SearchAction<object@WeatherForecast[weatherCondition]>";

		IntentSignature name = complexIntentWithEntityProperty;

		name.Namespace.Should().Be("AMAZON");
		name.Action.Should().Be("SearchAction");
		name.Properties.Should().ContainSingle();
		name.Properties.Should().ContainKey("object").WhoseValue.Entity.Should().Be("WeatherForecast");
		name.Properties.Should().ContainKey("object").WhoseValue.Property.Should().Be("weatherCondition");
	}
}
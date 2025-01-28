using AlexaVoxCraft.Model.Requests;
using AlexaVoxCraft.Model.Requests.Apl;
using AlexaVoxCraft.Model.Requests.Types;
using AlexaVoxCraft.Tests.Fixtures.Attributes;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Requests;

public class SkillRequestTests
{
    private const string ExamplesPath = "Examples";
    private const string ModelPath = "Model";
    private const string IntentRequestFile = "IntentRequest.json";
    private const string LaunchRequestFile = "LaunchRequest.json";

    [Theory, ModelAutoData(typeof(SkillRequest), IntentRequestFile)]
    public void Can_Read_IntentRequest_Example(SkillRequest request)
    {
        request.Should().NotBeNull();
        request!.GetRequestType().Should().Be<IntentRequest>();
        Utility.CompareJson(request, IntentRequestFile).Should().BeTrue();
    }

    [Theory, ModelAutoData(typeof(SkillRequest), IntentRequestFile)]
    public void IntentRequest_Generates_Correct_Name(SkillRequest request)
    {
        var intent = request.Request.Should().BeOfType<IntentRequest>().Subject.Intent;
        intent.Name.Should().Be("GetZodiacHoroscopeIntent");
        intent.Signature.Should().Be("GetZodiacHoroscopeIntent");
        intent.Signature.Action.Should().Be("GetZodiacHoroscopeIntent");
    }

    [Theory, ModelAutoData(typeof(SkillRequest), "BuiltInIntentRequest.json")]
    public void BuiltInRequest_Generates_Correct_Signature(SkillRequest request)
    {
        var signature = request.Request.Should().BeOfType<IntentRequest>().Subject.Intent.Signature;
        signature.Action.Should().Be("AddAction");
        signature.Namespace.Should().Be("AMAZON");
        signature.Properties.Count.Should().Be(2);

        var first = signature.Properties.First();
        var second = signature.Properties.Skip(1).First();

        first.Key.Should().Be("object");
        first.Value.Entity.Should().Be("Book");
        first.Value.Property.Should().BeNullOrWhiteSpace();

        second.Key.Should().Be("targetCollection");
        second.Value.Entity.Should().Be("ReadingList");
        second.Value.Property.Should().BeNullOrWhiteSpace();
    }
    [Theory, ModelAutoData(typeof(SkillRequest), LaunchRequestFile)]
    public void Can_Read_LaunchRequest_Example(SkillRequest request)
    {
        request.Should().NotBeNull();
        request!.GetRequestType().Should().Be<LaunchRequest>();
    }

    [Theory, ModelAutoData(typeof(SkillRequest), "LaunchRequestWithEpochTimestamp.json")]
    public void Can_Read_LaunchRequestWithEpochTimestamp_Example(SkillRequest request)
    {
        request.Should().NotBeNull();
        request.Request.Should().BeOfType<LaunchRequest>();
    }

    [Theory, ModelAutoData(typeof(SkillRequest), "SessionEndedRequest.json")]
    public void Can_Read_SessionEndedRequest_Example(SkillRequest request)
    {
        request.Should().NotBeNull();
        var sessionEndedRequest = request.Request.Should().BeOfType<SessionEndedRequest>().Subject;
        sessionEndedRequest.Error.Type.Should().Be(ErrorType.InvalidResponse);
        sessionEndedRequest.Error.Message.Should().Be("test message");
    }
    
    [Theory, ModelAutoData(typeof(SkillRequest), "GetUtterance.json")]
    public void Can_Read_Slot_Example(SkillRequest request)
    {
        var intent = request.Request.Should().BeOfType<IntentRequest>().Subject.Intent;
        var slot = intent.Slots.Should().Contain(s => s.Key == "Utterance").Subject.Value;
        slot.Value.Should().Be("how are you");
    }
    
    [Theory, ModelAutoData(typeof(SkillRequest), IntentRequestFile)]
    public void DialogState_Appears_In_IntentRequest(SkillRequest request)
    {
        var actual = request!.Request.Should().BeOfType<IntentRequest>().Subject;
        actual.DialogState.Should().Be(DialogState.InProgress);
    }

    [Theory, ModelAutoData(typeof(SkillRequest), IntentRequestFile)]
    public void ConfirmationState_Appears_In_Intent(SkillRequest request)
    {
        var actual = request!.Request.Should().BeOfType<IntentRequest>().Subject.Intent;

        actual.ConfirmationStatus.Should().Be(ConfirmationStatus.Denied);
    }

    [Theory, ModelAutoData(typeof(SkillRequest), IntentRequestFile)]
    public void ConfirmationState_Appears_In_Slot(SkillRequest request)
    {
        var intent = request.Request.Should().BeOfType<IntentRequest>().Subject.Intent;
        var slot = intent.Slots.Should().Contain(s => s.Key == "Date").Subject.Value;

        slot.ConfirmationStatus.Should().Be(ConfirmationStatus.Confirmed);
    }

    [Theory, ModelAutoData(typeof(SkillRequest), "BuiltInIntentRequest.json")]
    public void Can_Read_Person_Information(SkillRequest request)
    {
        request.Should().NotBeNull();
        request.Context.System.Person.Should().NotBeNull();
        var person = request.Context.System.Person;
        person.PersonId.Should().Be("amzn1.ask.account.personid");
        person.AccessToken.Should().Be("Atza|BBBBBBB");
        person.AuthenticationConfidenceLevel.Level.Should().Be(300);
    }

    [Theory, ModelAutoData(typeof(SkillRequest), "SmartPropertiesIntentRequest.json")]
    public void Handle_Alexa_Smart_Properties_Support(SkillRequest request)
    {
        request.Should().NotBeNull();
        request.Context.System.Unit.Should().NotBeNull();
        request.Context.System.Unit.UnitId.Should().Be("amzn1.ask.unit.A1B2C3");
        request.Context.System.Unit.PersistentUnitId.Should().Be("amzn1.alexa.unit.did.X7Y8Z9");
        request.Context.System.Device.PersistentEndpointId.Should().Be("amzn1.alexa.endpoint.AABBCC010101010101010101");
    }

    [Theory, ModelAutoData(typeof(SkillRequest), "CanFulfillIntentRequest.json")]
    public void Can_Read_CanFulfillIntentRequest_Example(SkillRequest request)
    {
        request.Should().NotBeNull();
        var intentRequest = request.Request.Should().BeOfType<CanFulfillIntentRequest>().Subject;
        intentRequest.DialogState.Should().Be(DialogState.InProgress);
        intentRequest.Intent.Name.Should().Be("PlaySound");
        var slot = intentRequest.Intent.Slots.Should().ContainSingle().Subject;
        slot.Key.Should().Be("Sound");
        slot.Value.Name.Should().Be("Sound");
        slot.Value.Value.Should().Be("crickets");
    }

    // [Theory, ModelAutoData(typeof(SkillRequest), LaunchRequestFile)]
    // public void Viewport_Deserializes_Correctly(SkillRequest request)
    // {
    //     request.Should().NotBeNull();
    //     request.Context.Viewport.Shape.Should().Be(ViewportShape.RECTANGLE);
    //     request.Context.Viewport.DPI.Should().Be(160);
    // }
    //
    // [Theory, ModelAutoData(typeof(SkillRequest), LaunchRequestFile)]
    // public void Viewport_Array_Deserializes_Correctly(SkillRequest request)
    // {
    //     request.Context.Viewports.Length.Should().Be(2);
    //     request.Context.Viewports.Should().ContainSingle(vp => vp.GetType() == typeof(APLViewport));
    //     request.Context.Viewports.Should().ContainSingle(vp => vp.GetType() == typeof(APLTViewport));
    // }

    // [Theory, ModelAutoData(typeof(SkillRequest), LaunchRequestFile)]
    // public void APLViewport_Properties_Set_Correctly(SkillRequest request)
    // {
    //     var viewport = request.Context.Viewports.Should().ContainSingle(vp => vp.GetType() == typeof(APLViewport))
    //         .Subject.Should().BeOfType<APLViewport>().Subject;
    //     viewport.Shape.Should().Be(ViewportShape.RECTANGLE);
    //     viewport.DPI.Should().Be(160);
    //     viewport.PresentationType.Should().Be(ViewPortPresentationType.STANDARD);
    //     viewport.CanRotate.Should().BeFalse();
    //
    //     var config = viewport.Configuration.Current;
    //     config.Video.Should().NotBeNull();
    //     config.Size.Type.Should().Be("DISCRETE");
    //     config.Size.PixelWidth.Should().Be(1024);
    //     config.Size.PixelHeight.Should().Be(600);
    // }
    
    // [Theory, ModelAutoData(typeof(SkillRequest), LaunchRequestFile)]
    // public void APLTViewport_Properties_Set_Correctly(SkillRequest request)
    // {
    //     var viewport = request.Context.Viewports.Should().ContainSingle(vp => vp.GetType() == typeof(APLTViewport))
    //         .Subject.Should().BeOfType<APLTViewport>().Subject;
    //
    //     var profile = viewport.SupportedProfiles.Should().ContainSingle().Subject;
    //     profile.Should().Be(APLTProfile.FOUR_CHARACTER_CLOCK);
    //
    //     viewport.LineLength.Should().Be(4);
    //     viewport.LineCount.Should().Be(1);
    //     viewport.Format.Should().Be(APLTFormat.SEVEN_SEGMENT);
    //
    //     var segment = viewport.InterSegments.Should().ContainSingle().Subject;
    //     segment.X.Should().Be(2);
    //     segment.Y.Should().Be(0);
    //     segment.Characters.Length.Should().Be(3);
    // }

    // [Theory, ModelAutoData(typeof(SkillRequest), LaunchRequestFile)]
    // public void APLContext_Information_Set_Correctly(SkillRequest request)
    // {
    //     var info = request.Context.AplVisualContext;
    //     info.Token.Should().Be("helloworldWithButtonToken");
    //     info.Version.Should().Be("APL_WEB_RENDERER_GANDALF");
    //
    //     var component = info.ComponentsVisibleOnScreen.Should().ContainSingle().Subject;
    //     component.Uid.Should().Be(":1000");
    //     component.Type.Should().Be(VisibleComponentType.Text);
    //     component.Position.Should().Be("1024x600+0+0:0");
    //
    //     var child = component.Children.Should().ContainSingle().Subject;
    //     child.Id.Should().Be("fadeHelloTextButton");
    //     child.Uid.Should().Be(":1002");
    //     child.Tags.Clickable.Should().BeTrue();
    //     child.Tags.Focused.Should().BeFalse();
    // }
}
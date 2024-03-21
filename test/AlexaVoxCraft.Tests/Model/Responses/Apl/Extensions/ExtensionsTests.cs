using AlexaVoxCraft.Model.Responses.Apl;
using AlexaVoxCraft.Model.Responses.Apl.Commands;
using AlexaVoxCraft.Model.Responses.Apl.Directives;
using AlexaVoxCraft.Model.Responses.Apl.Extensions.Backstack;
using AlexaVoxCraft.Model.Responses.Apl.Extensions.DataStore;
using AlexaVoxCraft.Model.Responses.Apl.Extensions.EntitySensing;
using AlexaVoxCraft.Model.Responses.Apl.Extensions.SmartMotion;
using AlexaVoxCraft.Tests.Fixtures.Attributes;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Responses.Apl.Extensions;

public class ExtensionsTests
{
    [Theory, ModelAutoData(typeof(APLDocumentReference), "APL/Extensions/ExtensionBackstack.json")]
    public void BackstackExtension_Should_Be_Expected(APLDocumentReference extension)
    {
        var expected = extension.Should().NotBeNull().And.BeOfType<APLDocument>().Subject;

        var backstack = new BackstackExtension("Back");
        var doc = new APLDocument(APLDocumentVersion.V1_4);
        doc.Extensions.Value.Add(backstack);
        doc.Settings = new APLDocumentSettings();
        doc.Settings.Add(backstack.Name, new BackstackSettings { BackstackId = "myDocument" });
        Utility.CompareObjectJson(doc, expected);
    }

    [Fact]
    public void GoBackCommand_Sets_Correct_Type()
    {
        var goBack = GoBackCommand.For(new BackstackExtension("Back"));
        goBack.BackType = BackTypeKind.Id;
        goBack.BackValue = "myDocument";
        Utility.CompareJson(goBack, "APL/Extensions/GoBackCommand.json");
    }

    [Fact]
    public void ClearCommand_Sets_Correct_Type()
    {
        var goBack = ClearCommand.For(new BackstackExtension("Back"));
        goBack.Type.Should().Be("Back:Clear");
    }

    [Theory, ModelAutoData(typeof(APLDocumentReference), "APL/Extensions/ExtensionSmartMotion.json")]
    public void SmartMotionExtension_Should_Be_Expected(APLDocumentReference extension)
    {
        var expected = extension.Should().NotBeNull().And.BeOfType<APLDocument>().Subject;

        var smartMotion = new SmartMotionExtension("SmartMotion");
        var doc = new APLDocument(APLDocumentVersion.V1_4);
        doc.Extensions.Value.Add(smartMotion);
        doc.Settings = new APLDocumentSettings();
        doc.Settings.Add(smartMotion.Name, new SmartMotionSettings
        {
            DeviceStateName = "MyDeviceState",
            WakeWordResponse = WakeWordResponse.FollowOnWakeWord
        });
        Utility.CompareObjectJson(doc, expected);
    }

    [Fact]
    public void FollowPrimaryUserCommand_Sets_Correct_Type()
    {
        var followPrimaryUser = FollowPrimaryUserCommand.For(new SmartMotionExtension("SmartMotion"));
        followPrimaryUser.Type.Should().Be("SmartMotion:FollowPrimaryUser");
    }

    [Fact]
    public void GoToCenterCommand_Sets_Correct_Type()
    {
        var goToCenter = GoToCenterCommand.For(new SmartMotionExtension("SmartMotion"));
        goToCenter.Type.Should().Be("SmartMotion:GoToCenter");
    }

    [Fact]
    public void SetWakeWordResponseCommand_Sets_Correct_Type()
    {
        var setWakeWordResponse = SetWakeWordResponseCommand.For(new SmartMotionExtension("SmartMotion"));
        setWakeWordResponse.WakeWordResponse = WakeWordResponse.TurnToWakeWord;
        Utility.CompareJson(setWakeWordResponse, "APL/Extensions/SetWakeWordResponseCommand.json");
    }

    [Fact]
    public void StopMotionCommand_Sets_Correct_Type()
    {
        var stopMotion = StopMotionCommand.For(new SmartMotionExtension("SmartMotion"));
        stopMotion.Type.Should().Be("SmartMotion:StopMotion");
    }

    [Fact]
    public void TurnToPrimaryUser_Sets_Correct_Type()
    {
        var turnToPrimaryUser = TurnToPrimaryUserCommand.For(new SmartMotionExtension("SmartMotion"));
        turnToPrimaryUser.Type.Should().Be("SmartMotion:TurnToPrimaryUser");
    }

    [Fact]
    public void PlayNamedChoreo_Sets_Correct_Type()
    {
        var playNamedChoreo = PlayNamedChoreoCommand.For(new SmartMotionExtension("SmartMotion"), "ScreenImpactCenter");
        Utility.CompareJson(playNamedChoreo, "APL/Extensions/PlayNamedChoreoCommand.json");
    }

    [Theory, AlexaAutoData]
    public void DeviceStateChangedHandler_Contains_Key(APLValue<IList<APLCommand>> commands)
    {
        var doc = new APLDocument();
        var smartMotion = new SmartMotionExtension("SmartMotion");
        smartMotion.OnDeviceStateChanged(doc, commands);
        doc.Handlers.Should().ContainKey("SmartMotion:OnDeviceStateChanged");
    }

    [Fact]
    public void EntitySensing_Should_Be_Set()
    {
        var entitySensing = new EntitySensingExtension("EntitySensing");
        var doc = new APLDocument(APLDocumentVersion.V1_4);
        doc.Extensions.Value.Add(entitySensing);
        doc.Settings = new APLDocumentSettings();
        doc.Settings.Add(entitySensing.Name, new EntitySensingSettings
        {
            EntitySensingStateName = "EntitySensingState",
            PrimaryUserName = "User"
        });
        Utility.CompareJson(doc, "APL/Extensions/ExtensionEntitySensing.json");
    }

    [Theory, AlexaAutoData]
    public void EntitySensingStateChanged_Contains_Key(APLValue<IList<APLCommand>> commands)
    {
        var doc = new APLDocument();
        var entitySensing = new EntitySensingExtension("EntitySensing");
        entitySensing.OnEntitySensingStateChanged(doc, commands);
        doc.Handlers.Should().ContainKey("EntitySensing:OnEntitySensingStateChanged");
    }

    [Theory, AlexaAutoData]
    public void PrimaryUserChanged_Contains_Key(APLValue<IList<APLCommand>> commands)
    {
        var doc = new APLDocument();
        var entitySensing = new EntitySensingExtension("EntitySensing");
        entitySensing.OnPrimaryUserChanged(doc, commands);
        doc.Handlers.Should().ContainKey("EntitySensing:OnPrimaryUserChanged");
    }

    [Fact]
    public void DataStore_Should_Be_Set()
    {
        var dataStore = new DataStoreExtension("DataStore");
        var doc = new APLDocument(APLDocumentVersion.V2023_1);
        doc.Extensions.Value.Add(dataStore);
        doc.Settings = new APLDocumentSettings();
        doc.Settings.Add(dataStore.Name, new DataStoreSettings
        {
            DataBindings = new List<DataBinding>
            {
                new()
                {
                    Namespace = "LocationWeather",
                    Key = "weather",
                    DataBindingName = "DS_Weather"
                }
            }
        });
        Utility.CompareJson(doc, "APL/Extensions/DataStore_Extension.json");
    }

    [Fact]
    public void GetObjectCommand_Sets_Correct_Type()
    {
        var getObject = GetObjectCommand.For(new DataStoreExtension("DataStore"), "LocationWeather",
            "weather", "thisIsADummyToken");
        Utility.CompareJson(getObject, "APL/Extensions/GetObjectCommand.json");
    }

    [Fact]
    public void WatchObjectCommand_Sets_Correct_Type()
    {
        var watchObject = WatchObjectCommand.For(new DataStoreExtension("DataStore"), "LocationWeather", "weather");
        Utility.CompareJson(watchObject, "APL/Extensions/WatchObjectCommand.json");
    }

    [Fact]
    public void UnwatchObjectCommand_Sets_Correct_Type()
    {
        var unwatchObject = UnwatchObjectCommand.For(new DataStoreExtension("DataStore"), "LocationWeather", "weather");
        Utility.CompareJson(unwatchObject, "APL/Extensions/UnwatchObjectCommand.json");
    }

    [Fact]
    public void UpdateArrayBindingRangeCommand_Sets_Correct_Type()
    {
        var updateArrayBindingRange = UpdateArrayBindingRangeCommand.For(new DataStoreExtension("DataStore"),
            "ToDoNotes", APLValue.To<int?>("${test}"), 5);
        Utility.CompareJson(updateArrayBindingRange, "APL/Extensions/UpdateArrayBindingRangeCommand.json");
    }

    [Theory, AlexaAutoData]
    public void DataStoreOnObjectChanged_Contains_Key(APLValue<IList<APLCommand>> commands)
    {
        var doc = new APLDocument();
        var entitySensing = new DataStoreExtension("DataStore");
        entitySensing.OnObjectChanged(doc, commands);
        doc.Handlers.Should().ContainKey("DataStore:OnObjectChanged");
    }

    [Theory, AlexaAutoData]
    public void DataStoreOnObjectReceived_Contains_Key(APLValue<IList<APLCommand>> commands)
    {
        var doc = new APLDocument();
        var entitySensing = new DataStoreExtension("DataStore");
        entitySensing.OnObjectReceived(doc, commands);
        doc.Handlers.Should().ContainKey("DataStore:OnObjectReceived");
    }}
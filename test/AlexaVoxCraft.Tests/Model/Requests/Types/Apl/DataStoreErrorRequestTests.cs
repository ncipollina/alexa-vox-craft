using AlexaVoxCraft.Model.Requests.Types;
using AlexaVoxCraft.Model.Requests.Types.Apl;
using AlexaVoxCraft.Tests.Fixtures.Attributes;
using AlexaVoxCraft.Tests.Fixtures.Utilities;

namespace AlexaVoxCraft.Tests.Model.Requests.Types.Apl;

public class DataStoreErrorRequestTests
{
    [Theory, ModelAutoData(typeof(RequestType), "DataStoreError_Storage.json")]
    public void Can_Deserialize_DataStoreErrorRequest_Storage_Json(RequestType request)
    {
        var dataStoreErrorRequest = request.Should().NotBeNull().And.BeOfType<DataStoreErrorRequest>().Subject;
        Utility.CompareJson(dataStoreErrorRequest, "DataStoreError_Storage.json");

        var err = dataStoreErrorRequest.Error;
        err.Type.Should().Be(DataStoreErrorType.STORAGE_LIMIT_EXCEEDED);
        err.Content.DeviceId.Should().Be("device-id");

        var cmd = err.Content.FailedCommand.Should().NotBeNull().And.BeOfType<PutObjectDataStoreCommand>()
            .Subject;
        cmd.Namespace.Should().Be("namespace-from-the-command");
        cmd.Key.Should().Be("key-from-the-command");
    }
    
    [Theory, ModelAutoData(typeof(RequestType), "DataStoreError_Device.json")]
    public void Can_Deserialize_DataStoreErrorRequest_Device_Json(RequestType request)
    {
        var dataStoreErrorRequest = request.Should().NotBeNull().And.BeOfType<DataStoreErrorRequest>().Subject;
        Utility.CompareJson(dataStoreErrorRequest, "DataStoreError_Device.json");

        var err = dataStoreErrorRequest.Error;
        err.Type.Should().Be(DataStoreErrorType.DEVICE_UNAVAILABLE);
        err.Content.DeviceId.Should().Be("device-id");

        var cmd = err.Content.Commands.Should().ContainSingle().Subject.Should().BeOfType<PutObjectDataStoreCommand>().Subject;
        cmd.Namespace.Should().Be("namespace-from-the-command");
        cmd.Key.Should().Be("key-from-the-command");
    }
}
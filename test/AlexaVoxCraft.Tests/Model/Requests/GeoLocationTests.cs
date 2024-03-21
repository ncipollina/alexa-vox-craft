using AlexaVoxCraft.Model.Requests;
using AlexaVoxCraft.Model.Requests.Types;
using AlexaVoxCraft.Tests.Fixtures.Attributes;

namespace AlexaVoxCraft.Tests.Model.Requests;

public class GeoLocationTests
{
    [Theory, ModelAutoData(typeof(Geolocation), "Geolocation.json")]
    public void Geolocation_Data_Deserializes_Correctly(Geolocation geolocation)
    {
        geolocation.Should().NotBeNull();

        geolocation.LocationServices.Access.Should().Be(LocationServiceAccess.Enabled);
        geolocation.LocationServices.Status.Should().Be(LocationServiceStatus.Running);
        
        var expectedDate = DateTimeOffset.Parse("2018-12-14T07:05:48Z");
        geolocation.Timestamp.Should().Be(expectedDate);

        geolocation.Coordinate.Latitude.Should().Be(38.2);
        geolocation.Coordinate.Longitude.Should().Be(28.3);
        geolocation.Coordinate.Accuracy.Should().Be(12.1);

        geolocation.Altitude.Altitude.Should().Be(120.1);
        geolocation.Altitude.Accuracy.Should().Be(30.1);

        geolocation.Heading.Direction.Should().Be(180.0);
        geolocation.Heading.Accuracy.Should().Be(5.0);

        geolocation.Speed.Speed.Should().Be(10.0);
        geolocation.Speed.Accuracy.Should().Be(1.1);
    }
}
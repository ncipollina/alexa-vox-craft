using System.Text.Json;
using AlexaVoxCraft.Model.Request;
using AlexaVoxCraft.Model.Serialization;

namespace AlexaVoxCraft.Model.Apl;

public static class APLTInterface
{
    public const string InterfaceName = "Alexa.Presentation.APLT";

    public static bool APLTSupported(this SkillRequest request)
    {
        return Supported(request);
    }

    public static bool Supported(SkillRequest request)
    {
        return request.Context.System.Device.SupportedInterfaces.ContainsKey(InterfaceName);
    }

    public static APLInterfaceDetails APLTInterfaceDetails(this SkillRequest request)
    {
        var raw = GetAPLTInterfaceObject(request);
        return raw == null
            ? null
            : JsonSerializer.Deserialize<APLInterfaceDetails>(raw.ToString(),
                AlexaJsonOptions.DefaultOptions);     }

    private static object GetAPLTInterfaceObject(SkillRequest request)
    {
        var interfaces = request.Context.System.Device.SupportedInterfaces;
        return interfaces.ContainsKey(InterfaceName) ? interfaces[InterfaceName] : null;
    }
}
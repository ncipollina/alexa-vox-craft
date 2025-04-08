using System.Text.Json;
using AlexaVoxCraft.Model.Request;
using AlexaVoxCraft.Model.Serialization;

namespace AlexaVoxCraft.Model.Apl;

public static class APLInterface
{
    public const string InterfaceName = "Alexa.Presentation.APL";

    public static bool APLSupported(this SkillRequest request)
    {
        return Supported(request);
    }

    public static bool Supported(SkillRequest request)
    {
        return request.Context.System.Device.SupportedInterfaces.ContainsKey(InterfaceName);
    }

    public static APLInterfaceDetails APLInterfaceDetails(this SkillRequest request)
    {
        var raw = GetAPLInterfaceObject(request);
        return raw == null
            ? null
            : JsonSerializer.Deserialize<APLInterfaceDetails>(raw.ToString(),
                AlexaJsonOptions.DefaultOptions); 
    }

    private static object GetAPLInterfaceObject(SkillRequest request)
    {
        var interfaces = request.Context.System.Device.SupportedInterfaces;
        return interfaces.ContainsKey(InterfaceName) ? interfaces[InterfaceName] : null;
    }
}
using AlexaVoxCraft.Model.Request.Type;

namespace AlexaVoxCraft.Tests;

public class NewIntentRequestTypeResolver : IRequestTypeResolver
{
    public bool CanResolve(string requestType)
    {
        return requestType == "AlexaNet.CustomIntent";
    }

    public System.Type Resolve(string requestType)
    {
        return typeof(NewIntentRequest);
    }
}
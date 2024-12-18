using AlexaVoxCraft.MediatR.Attributes;
using AlexaVoxCraft.MediatR.Response;
using AlexaVoxCraft.Model.Requests;

namespace AlexaVoxCraft.MediatR;

public interface IHandlerInput
{
    SkillRequest RequestEnvelope { get; }
    
    IAttributesManager AttributesManager { get; }
    
    IResponseBuilder ResponseBuilder { get; }
}
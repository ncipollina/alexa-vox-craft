using AlexaVoxCraft.Model.Responses;

namespace AlexaVoxCraft.MediatR.Pipeline;

public interface IResponseInterceptor
{
    Task Process(IHandlerInput input, SkillResponse output, CancellationToken cancellationToken = default);
}
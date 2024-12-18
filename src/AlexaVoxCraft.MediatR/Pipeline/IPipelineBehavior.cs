using AlexaVoxCraft.Model.Responses;

namespace AlexaVoxCraft.MediatR.Pipeline;

public delegate Task<SkillResponse> RequestHandlerDelegate();

public interface IPipelineBehavior
{
    Task<SkillResponse> Handle(IHandlerInput input, CancellationToken cancellationToken, RequestHandlerDelegate next);
}
using AlexaVoxCraft.Model.Requests;
using AlexaVoxCraft.Model.Responses;

namespace AlexaVoxCraft.MediatR;

public interface ISkillMediator
{
    Task<SkillResponse> Send(SkillRequest request, CancellationToken cancellationToken = default);
}
using AlexaVoxCraft.MediatR;
using AlexaVoxCraft.Model.Response;

namespace Sample.Apl.Function.Handlers;

public class DefaultHandler : IDefaultRequestHandler
{
    public Task<bool> CanHandle(IHandlerInput input, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(true);
    }

    public async Task<SkillResponse> Handle(IHandlerInput input, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
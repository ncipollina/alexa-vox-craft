using System.Collections.Concurrent;
using AlexaVoxCraft.MediatR.DI;
using AlexaVoxCraft.MediatR.Wrappers;
using AlexaVoxCraft.Model.Requests;
using AlexaVoxCraft.Model.Responses;
using Microsoft.Extensions.Options;

namespace AlexaVoxCraft.MediatR;

public class SkillMediator : ISkillMediator
{
    private readonly IServiceProvider _serviceProvider;
    private readonly SkillServiceConfiguration _serviceConfiguration;
    private static readonly ConcurrentDictionary<Type, RequestHandlerWrapper> RequestHandlers = new();

    public SkillMediator(IServiceProvider serviceProvider, IOptions<SkillServiceConfiguration> serviceConfiguration)
    {
        _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        _serviceConfiguration = serviceConfiguration.Value ?? throw new ArgumentNullException(nameof(serviceConfiguration));
    }

    public Task<SkillResponse> Send(SkillRequest request, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(_serviceConfiguration.SkillId) ||
            request.Context.System.Application.ApplicationId != _serviceConfiguration.SkillId)
            throw new ArgumentException("Skill ID verification failed!");

        var requestType = request.Request.GetType();

        var handler = RequestHandlers.GetOrAdd(requestType,
            static t => (RequestHandlerWrapper)(Activator.CreateInstance(typeof(RequestHandlerWrapperImpl<>)
                .MakeGenericType(t)) ?? throw new InvalidOperationException($"Could not create wrapper type for {t}")));

        return handler.Handle(request, _serviceProvider, cancellationToken);
    }
}
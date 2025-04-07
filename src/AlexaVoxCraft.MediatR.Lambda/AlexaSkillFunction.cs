using System.Text.Json;
using AlexaVoxCraft.MediatR.Lambda.Abstractions;
using AlexaVoxCraft.MediatR.Lambda.Context;
using AlexaVoxCraft.MediatR.Lambda.Extensions;
using AlexaVoxCraft.MediatR.Lambda.Serialization;
using AlexaVoxCraft.Model.Request;
using AlexaVoxCraft.Model.Response;
using AlexaVoxCraft.Model.Serialization;
using Amazon.Lambda.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AlexaVoxCraft.MediatR.Lambda;

public abstract class AlexaSkillFunction
{
    private IServiceProvider _serviceProvider = null!;
    
    public IServiceProvider ServiceProvider => _serviceProvider;

    protected AlexaSkillFunction()
    {
        Start();
    }

    protected virtual IHostBuilder CreateHostBuilder()
    {
        var builder = Host.CreateDefaultBuilder().ConfigureLogging((_, logging) =>
        {
            logging.AddJsonConsole();
            logging.AddDebug();
        });
        Init(builder);
        return builder;
    }
    
    protected virtual void Init(IHostBuilder builder){ }

    protected void Start()
    {
        var builder = CreateHostBuilder();
        builder.ConfigureServices(services =>
        {
            services.AddSkillContextAccessor();
            services.AddSingleton(AlexaJsonOptions.DefaultOptions);
            services.AddSingleton<ILambdaSerializer, AlexaLambdaSerializer>();
        });
        var host = builder.Build();
        
        host.Start();
        _serviceProvider = host.Services;
    }

    protected void CreateContext(SkillRequest request)
    {
        var factory = _serviceProvider.GetRequiredService<ISkillContextFactory>();
        factory.Create(request);
    }
    
    public virtual async Task<SkillResponse> FunctionHandlerAsync(SkillRequest request, ILambdaContext lambdaContext)
    {
        using var serviceScope = _serviceProvider.CreateScope();
        var provider = serviceScope.ServiceProvider;
        CreateContext(request);
        var handlerAsync = provider.GetRequiredService<HandlerDelegate<SkillRequest, SkillResponse>>();

        return await handlerAsync(request, lambdaContext);
    }

}
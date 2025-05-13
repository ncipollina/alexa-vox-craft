using AlexaVoxCraft.Logging.Serialization;
using AlexaVoxCraft.MediatR.Lambda.Abstractions;
using AlexaVoxCraft.MediatR.Lambda.Context;
using AlexaVoxCraft.MediatR.Lambda.Extensions;
using AlexaVoxCraft.Model.Request;
using AlexaVoxCraft.Model.Response;
using AlexaVoxCraft.Model.Serialization;
using Amazon.Lambda.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace AlexaVoxCraft.MediatR.Lambda;

public abstract class AlexaSkillFunction<TRequest, TResponse>
    where TRequest : SkillRequest where TResponse : SkillResponse
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
        }).UseSerilog((context, services, configuration) =>
        {
            configuration.ReadFrom.Configuration(context.Configuration)
                .ReadFrom.Services(services)
                .Destructure.With(new SystemTextDestructuringPolicy())
                .Enrich.FromLogContext();
        });
        Init(builder);
        return builder;
    }

    protected virtual void Init(IHostBuilder builder)
    {
    }

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

    protected void CreateContext(TRequest request)
    {
        var factory = _serviceProvider.GetRequiredService<ISkillContextFactory>();
        factory.Create(request);
    }

    public virtual async Task<TResponse> FunctionHandlerAsync(TRequest request, ILambdaContext lambdaContext)
    {
        using var serviceScope = _serviceProvider.CreateScope();
        var provider = serviceScope.ServiceProvider;
        CreateContext(request);
        var handlerAsync = provider.GetRequiredService<HandlerDelegate<TRequest, TResponse>>();

        return await handlerAsync(request, lambdaContext);
    }
}
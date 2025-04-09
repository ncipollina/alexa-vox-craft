using AlexaVoxCraft.MediatR.DI;
using AlexaVoxCraft.MediatR.Lambda;
using AlexaVoxCraft.MediatR.Lambda.Extensions;
using AlexaVoxCraft.Model.Apl;
using AlexaVoxCraft.Model.Response;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace Sample.Apl.Function;

public class Function : AlexaSkillFunction
{
    protected override void Init(IHostBuilder builder)
    {
        builder.UseSerilog((context, services, configuration) =>
            {
                configuration.ReadFrom.Configuration(context.Configuration)
                    .ReadFrom.Services(services)
                    .Enrich.FromLogContext();
            })
            .UseHandler<LambdaHandler, APLSkillRequest, SkillResponse>()
            .ConfigureServices((context, services) =>
            {
                services.AddSkillMediator(context.Configuration,
                    cfg => { cfg.RegisterServicesFromAssemblyContaining<Program>(); });
            });
    }
}
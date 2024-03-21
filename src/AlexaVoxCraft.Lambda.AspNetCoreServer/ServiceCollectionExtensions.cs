using AlexaVoxCraft.Model.Serialization;
using Amazon.Lambda.AspNetCoreServer.Internal;
using Amazon.Lambda.Core;
using Amazon.Lambda.Serialization.SystemTextJson;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace AlexaVoxCraft.Lambda.AspNetCoreServer;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAlexaSkillLambdaHosting(this IServiceCollection services)
    {
        if (TryLambdaSetup(services))
        {
            services.TryAddSingleton<ILambdaSerializer>(new DefaultLambdaJsonSerializer(options =>
            {
                var defaultOptions = AlexaJsonOptions.DefaultOptions;
                options.TypeInfoResolver = defaultOptions.TypeInfoResolver;
            }));
        }

        return services;
    }

    private static bool TryLambdaSetup(IServiceCollection services)
    {
        if (string.IsNullOrEmpty(Environment.GetEnvironmentVariable("AWS_LAMBDA_FUNCTION_NAME")))
            return false;
        
        Utilities.EnsureLambdaServerRegistered(services, typeof(AlexaSkillLambdaRuntimeSupportServer));
        return true;
    }

}
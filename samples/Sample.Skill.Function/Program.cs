using AlexaVoxCraft.Model.Requests;
using AlexaVoxCraft.Model.Responses;
using AlexaVoxCraft.Model.Serialization;
using Amazon.Lambda.Core;
using Amazon.Lambda.RuntimeSupport;
using Amazon.Lambda.Serialization.SystemTextJson;
using Sample.Skill.Function;
using Serilog;
using Serilog.Formatting.Compact;

try
{
    Log.Logger = new LoggerConfiguration()
        .MinimumLevel.Debug()
        .Enrich.FromLogContext()
        .WriteTo.Console(new CompactJsonFormatter())
        .CreateBootstrapLogger();

    Log.Information("Starting Lambda Host");
    
    Func<SkillRequest, ILambdaContext, Task<SkillResponse>> handler = new Function().FunctionHandlerAsync;

    var serializer = new DefaultLambdaJsonSerializer(options =>
    {
        var defaultOptions = AlexaJsonOptions.DefaultOptions;
        options.TypeInfoResolver = defaultOptions.TypeInfoResolver;
    });
    
    await LambdaBootstrapBuilder.Create(handler, serializer)
        .Build()
        .RunAsync();
    return 0;
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly");
    return 1;
}
finally
{
    Log.CloseAndFlush();
}

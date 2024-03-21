using System.Globalization;
using AlexaVoxCraft.Model.Requests;
using AlexaVoxCraft.Model.Responses;
using Amazon.Lambda.AspNetCoreServer;
using Amazon.Lambda.AspNetCoreServer.Hosting.Internal;
using Amazon.Lambda.AspNetCoreServer.Internal;
using Amazon.Lambda.Core;
using Amazon.Lambda.RuntimeSupport;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AlexaVoxCraft.Lambda.AspNetCoreServer;

public class AlexaSkillLambdaRuntimeSupportServer : LambdaRuntimeSupportServer
{
    private readonly ILambdaSerializer _serializer;
    public AlexaSkillLambdaRuntimeSupportServer(IServiceProvider serviceProvider) : base(serviceProvider)
    {
        _serializer = serviceProvider.GetRequiredService<ILambdaSerializer>();
    }

    protected override HandlerWrapper CreateHandlerWrapper(IServiceProvider serviceProvider)
    {
        var handler = new AlexaSkillMinimalApi(serviceProvider).FunctionHandlerAsync;
        return HandlerWrapper.GetHandlerWrapper(handler, _serializer);
    }

    public class AlexaSkillMinimalApi : AlexaSkillFunction
    {
        public AlexaSkillMinimalApi(IServiceProvider serviceProvider) : base(serviceProvider){}
    }
}

public class AlexaSkillFunction : AbstractAspNetCoreFunction<SkillRequest, SkillResponse>
{
    private readonly ILogger _logger;
    private readonly ILambdaSerializer _serializer;
    
    public AlexaSkillFunction(IServiceProvider serviceProvider) : base(serviceProvider)
    {
        _logger = ActivatorUtilities.CreateInstance<Logger<AlexaSkillFunction>>(serviceProvider);
        _serializer = serviceProvider.GetRequiredService<ILambdaSerializer>();
        _logger.LogInformation("Serializer is type: {Type}", _serializer.GetType());
    }

    protected override void MarshallRequest(InvokeFeatures features, SkillRequest lambdaRequest, ILambdaContext lambdaContext)
    {
        var requestFeatures = (IHttpRequestFeature)features;
        requestFeatures.Scheme = "https";
        requestFeatures.Method = "POST";
        requestFeatures.RawTarget = "/";
        requestFeatures.QueryString = "";
        requestFeatures.Path = "/";
        _logger.LogDebug("Serializing lambdaRequest to a body Stream");
        var stream = new MemoryStream();
        _serializer.Serialize(lambdaRequest, stream);
        stream.Position = 0;
        _logger.LogDebug("Serialized lambdaRequest to a body Stream");
        _logger.LogDebug("Stream has length of {StreamLength}", stream.Length);
        _logger.LogDebug("Stream position is {StreamPosition}", stream.Position);
        requestFeatures.Body = stream;
        requestFeatures.Headers["Content-Length"] = requestFeatures.Body.Length.ToString(CultureInfo.InvariantCulture);
        requestFeatures.Headers["host"] = "localhost";
        requestFeatures.Headers["x-forwarded-port"] = "443";
        requestFeatures.Headers["x-forwarded-for"] = "127.0.0.1";
        requestFeatures.Headers["Content-Type"] = "application/json";
    }

    protected override SkillResponse MarshallResponse(IHttpResponseFeature responseFeatures, ILambdaContext lambdaContext,
        int statusCodeIfNotSet = 200)
    {
        var responseBodyFeature = (IHttpResponseBodyFeature)responseFeatures;

        var aspnetCoreBody = responseBodyFeature.Stream;
        aspnetCoreBody.Position = 0;
        _logger.LogDebug("Deserializing body to SkillResponse");
        var skillResponse = _serializer.Deserialize<SkillResponse>(aspnetCoreBody);
        _logger.LogDebug("SkillResponse is: {@SkillResponse}", skillResponse);
        return skillResponse;
    }
}
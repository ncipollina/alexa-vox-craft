using AlexaVoxCraft.Lambda.AspNetCoreServer;
using AlexaVoxCraft.Model.Requests;
using AlexaVoxCraft.Model.Responses;
using AlexaVoxCraft.Model.Serialization.TypeInfoResolvers;
using Microsoft.AspNetCore.Http.Json;
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

    var builder = WebApplication.CreateBuilder(args);

    builder.Host.UseSerilog((context, services, configuration) =>
    {
        configuration.ReadFrom.Configuration(context.Configuration)
            .ReadFrom.Services(services)
            .Enrich.FromLogContext();
    });

    builder.Services.Configure<JsonOptions>(options =>
    {
        options.SerializerOptions.TypeInfoResolver = new PolymorphicTypeResolver();
    });
    
    Log.Information("Adding Alex Skill Lambda Hosting");

    builder.Services.AddAlexaSkillLambdaHosting();

    var app = builder.Build();

    // app.UseHttpsRedirection();

    app.MapPost("/", async (SkillRequest request, ILogger<Program> logger) =>
    {
        logger.LogInformation("In Post method");

        logger.LogInformation("Received skill request: {@SkillRequest}", request);
        
        logger.LogInformation("Request type is {RequestType}", request.Request.GetType());

        return Results.Ok(new SkillResponse
        {
            Version = "1.0",
            Response = new(),
            SessionAttributes = new Dictionary<string, object> { { "sessionId", request.Session.SessionId } }
        });
    }).WithName("SkillRequestHandler");

    app.Run();
    
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


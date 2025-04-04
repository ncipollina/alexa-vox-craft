using System.Collections.Generic;
using System.Linq;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using AlexaVoxCraft.Model.Response;
using AlexaVoxCraft.Model.Response.Converters;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

public class ExecuteCommandsDirective:IDirective
{
    private const string DirectiveType = "Alexa.Presentation.APL.ExecuteCommands";

    public static void AddSupport()
    {
        DirectiveConverter.RegisterDirectiveDerivedType<ExecuteCommandsDirective>(DirectiveType);
    }

    public ExecuteCommandsDirective() { }

    public ExecuteCommandsDirective(string token)
    {
        Token = token;
    }

    public ExecuteCommandsDirective(string token, IEnumerable<APLCommand> commands):
        this(token)
    {
        Commands = commands.ToList();
    }

    public ExecuteCommandsDirective(string token, params APLCommand[] commands) : 
        this(token, (IEnumerable<APLCommand>)commands)
    { }

    [JsonProperty("type")]
    public string Type => DirectiveType;

    [JsonProperty("token")]
    public string Token { get; set; }

    [JsonProperty("commands"),
     JsonConverter(typeof(APLCommandListConverter),true)]
    public IList<APLCommand> Commands { get; set; }
}
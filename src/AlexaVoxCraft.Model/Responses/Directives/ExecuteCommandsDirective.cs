using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Apl.Commands;

namespace AlexaVoxCraft.Model.Responses.Directives
{
    public class ExecuteCommandsDirective : Directive
    {
        public const string DirectiveType = "Alexa.Presentation.APL.ExecuteCommands";

        public ExecuteCommandsDirective()
        {
        }

        public ExecuteCommandsDirective(string token)
        {
            Token = token;
        }

        public ExecuteCommandsDirective(string token, IEnumerable<APLCommand> commands) :
            this(token)
        {
            Commands = commands.ToList();
        }

        public ExecuteCommandsDirective(string token, params APLCommand[] commands) :
            this(token, (IEnumerable<APLCommand>)commands)
        {
        }

        [JsonPropertyName("token")] public string Token { get; set; }

        [JsonPropertyName("commands")]
        public IList<APLCommand> Commands { get; set; }
    }
}

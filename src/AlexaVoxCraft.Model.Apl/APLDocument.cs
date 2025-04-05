﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Apl.Commands;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using AlexaVoxCraft.Model.Apl.VectorGraphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AlexaVoxCraft.Model.Apl;

public class APLDocument: APLDocumentBase
{
    public const string DocumentType = "APL";
    [JsonPropertyName("type")]
    public override string Type => DocumentType;

    public APLDocument()
    {
            
    }

    public APLDocument(APLDocumentVersion version) : base(version)
    {

    }

    [JsonProperty("handleKeyDown", NullValueHandling = NullValueHandling.Ignore)]
    [Newtonsoft.Json.JsonConverter(typeof(APLKeyboardHandlerConverter))]
    public APLValue<IList<APLKeyboardHandler>> HandleKeyDown { get; set; }

    [JsonProperty("handleKeyUp", NullValueHandling = NullValueHandling.Ignore)]
    [Newtonsoft.Json.JsonConverter(typeof(APLKeyboardHandlerConverter))]
    public APLValue<IList<APLKeyboardHandler>> HandleKeyUp { get; set; }

    [JsonProperty("theme", NullValueHandling = NullValueHandling.Ignore), Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
    public ViewportTheme? Theme { get; set; }

    [JsonProperty("import", NullValueHandling = NullValueHandling.Ignore)]
    public IList<Import> Imports { get; set; }

    [JsonProperty("styles", NullValueHandling = NullValueHandling.Ignore)]
    public Dictionary<string, Style> Styles { get; set; }

    [JsonProperty("graphics",NullValueHandling = NullValueHandling.Ignore)]
    public Dictionary<string,AVG> Graphics { get; set; }

    [JsonProperty("commands",NullValueHandling = NullValueHandling.Ignore)]
    public Dictionary<string, CommandDefinition> Commands { get; set; }

    [JsonProperty("export",NullValueHandling = NullValueHandling.Ignore)]
    public ExportList Export { get; set; }

    [JsonProperty("background",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<DocumentBackgroundColor> Background { get; set; }

    [JsonProperty("onDisplayStateChange", NullValueHandling = NullValueHandling.Ignore),
     Newtonsoft.Json.JsonConverter(typeof(APLCommandListConverter), true)]
    public APLValue<IList<APLCommand>> OnDisplayStateChange { get; set; }
}
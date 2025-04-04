﻿using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.DataStore;

public class DataStoreErrorRequest: Request.Type.Request
{
    public const string RequestType = "Alexa.DataStore.DataStoreError";

    [JsonProperty("error")]
    public DataStoreError Error { get; set; }
}
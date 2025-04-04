﻿using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

public class ViewportExperience
{
    [JsonProperty("canResize")]
    public bool CanResize { get; set; }

    [JsonProperty("canRotate")]
    public bool CanRotate { get; set; }

    [JsonProperty("arcMinuteWidth")]
    public int ArcMinuteWidth { get; set; }

    [JsonProperty("arcMinuteHeight")]
    public int ArcMinuteHeight { get; set; }
}
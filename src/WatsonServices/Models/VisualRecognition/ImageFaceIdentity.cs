﻿using Newtonsoft.Json;

namespace WatsonServices.Models.VisualRecognition
{
    public class ImageFaceIdentity
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("score")]
        public double ConfidenceScore { get; set; }
    }
}

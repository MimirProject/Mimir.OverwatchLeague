using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mimir.OverwatchLeague.Models
{
    public class MapsResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public Dictionary<string, string> Name { get; set; }

        [JsonProperty("background")]
        public string Background { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("esportsApiId")]
        public string EsportsApiId { get; set; }
    }
}

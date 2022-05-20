using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TopologyJsonParser
{
    public class topology
    {
        [JsonPropertyName("id")]
        public string topologyId { get; set; }
        [JsonPropertyName("components")]
        public LinkedList<component> components { get; set; }
    }
    public class component
    {
        [JsonPropertyName("type")]
        public string type { get; set; }
        [JsonPropertyName("id")]
        public string id { get; set; }
        [JsonPropertyName("netlist")]
        public Dictionary<string, string> netList;
        public property properties;

    }
    public class property
    {
        [JsonPropertyName("default")]
        public float defaultP { get; set; }
        [JsonPropertyName("min")]
        public float min { get; set; }
        [JsonPropertyName("max")]
        public float max { get; set; }
    }
}


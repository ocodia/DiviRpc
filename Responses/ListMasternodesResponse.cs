using System.Text.Json.Serialization;

namespace DiviSharp.Responses
{
    public class ListMasternodesResponse
    {
        public string Ipv4 { get; set; }
        public string TxHash { get; set; }
        public int OutIdx { get; set; }
        public string Status { get; set; }

        [JsonPropertyName("addr")]
        public string Address { get; set; }
        public int Version { get; set; }
        public double LastSeen { get; set; }
        public int ActiveTime { get; set; }
        public double LastPaid { get; set; }
        public string Tier { get; set; }
    }
}

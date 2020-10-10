using DiviSharp.RPC.JsonConverters;
using System.Text.Json.Serialization;

namespace DiviSharp.Responses.Utilities
{
    public class GetInfoResponse
    {
        public string Version { get; set; }

        [JsonConverter(typeof(NumberToStringConverter))]
        public string ProtocolVersion { get; set; }

        [JsonConverter(typeof(NumberToStringConverter))]
        public string WalletVersion { get; set; }

        public decimal Balance { get; set; }
        public double Blocks { get; set; }
        public double TimeOffset { get; set; }
        public double Connections { get; set; }
        public string Proxy { get; set; }
        public double Difficulty { get; set; }
        public bool Testnet { get; set; }

        public decimal MoneySupply { get; set; }

        public double KeyPoolOldest { get; set; }
        public double KeyPoolSize { get; set; }

        [JsonPropertyName("unlocked_until")]
        public ulong UnlockedUntil { get; set; }

        public decimal PayTxFee { get; set; }
        public decimal RelayFee { get; set; }

        [JsonPropertyName("staking status")]
        public string StakingStatus { get; set; }

        public string Errors { get; set; }
    }
}

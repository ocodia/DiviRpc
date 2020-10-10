using DiviSharp.RPC.JsonConverters;
using System.Text.Json.Serialization;

namespace DiviSharp.Responses.Wallet
{
    public class GetWalletInfoResponse
    {
        [JsonConverter(typeof(NumberToStringConverter))]
        public string WalletVersion { get; set; }
        public decimal Balance { get; set; }

        [JsonPropertyName("unconfirmed_balance")]
        public decimal UnconfirmedBalance { get; set; }

        [JsonPropertyName("immature_balance")]
        public decimal ImmatureBalance { get; set; }

        public ulong TxCount { get; set; }
        public double KeyPoolOldest { get; set; }

        [JsonPropertyName("unlocked_until")]
        public ulong UnlockedUntil { get; set; }

        public ulong KeyPoolSize { get; set; }

        [JsonPropertyName("encryption_status")]
        public string EncryptionStatus { get; set; }
    }
}

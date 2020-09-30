using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiviSharp.Responses
{
    public class GetWalletInfoResponse
    {
        public string WalletVersion { get; set; }
        public decimal Balance { get; set; }

        [JsonProperty("unconfirmed_balance")]
        public decimal UnconfirmedBalance { get; set; }

        [JsonProperty("immature_balance")]
        public decimal ImmatureBalance { get; set; }

        public ulong TxCount { get; set; }
        public double KeyPoolOldest { get; set; }

        [JsonProperty("unlocked_until")]
        public ulong UnlockedUntil { get; set; }

        public ulong KeyPoolSize { get; set; }

        [JsonProperty("encryption_status")]
        public string EncryptionStatus { get; set; }
    }
}

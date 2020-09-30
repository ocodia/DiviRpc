using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiviSharp.Responses
{
    public class GetInfoResponse
    {
        public string Version { get; set; }
        public string ProtocolVersion { get; set; }
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

        [JsonProperty("unlocked_until")]
        public ulong UnlockedUntil { get; set; }

        public decimal PayTxFee { get; set; }
        public decimal RelayFee { get; set; }

        [JsonProperty("staking status")]
        public string StakingStatus { get; set; }
        
        public string Errors { get; set; }
    }
}

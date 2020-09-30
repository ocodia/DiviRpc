using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DiviSharp.Responses
{
    public class GetStakingStatusResponse
    {
        public bool ValidTime { get; set; }
        public bool HaveConnections { get; set; }
        public bool WalletUnlocked { get; set; }
        public bool MintableCoins { get; set; }
        public bool EnoughCoins { get; set; }
        public bool Mnsync { get; set; }

        [JsonProperty("staking status")]
        public bool StakingStatus { get; set; }
    }
}

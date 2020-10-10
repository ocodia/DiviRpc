using System.Text.Json.Serialization;

namespace DiviSharp.Responses.Wallet
{
    public class GetStakingStatusResponse
    {
        public bool ValidTime { get; set; }
        public bool HaveConnections { get; set; }
        public bool WalletUnlocked { get; set; }
        public bool MintableCoins { get; set; }
        public bool EnoughCoins { get; set; }
        public bool Mnsync { get; set; }

        [JsonPropertyName("staking status")]
        public bool StakingStatus { get; set; }
    }
}

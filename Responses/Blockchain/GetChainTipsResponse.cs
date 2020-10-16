using System.Text.Json.Serialization;

namespace DiviRpc.Responses.Blockchain
{
    public class GetChainTipsResponse
    {
        public int Height { get; set; }
        public string Hash { get; set; }

        [JsonPropertyName("branchlen")]
        public int BranchLength { get; set; }

        public string Status { get; set; }

    }
}

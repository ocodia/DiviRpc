using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DiviSharp.Responses.Blockchain
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

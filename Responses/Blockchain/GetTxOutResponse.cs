using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiviRpc.Responses.Blockchain
{
    public class GetTxOutResponse
    {
        public string BestBlock { get; set; }
        public int Confirmations { get; set; }
        public double Value { get; set; }
        public ScriptPubKey ScriptPubKey { get; set; }
        public int Version { get; set; }
        public bool Coinbase { get; set; }
    }

    public class ScriptPubKey
    {
        public string Asm { get; set; }
        public string Hex { get; set; }

        [JsonPropertyName("recSigs")]
        public int RequiredSignatures { get; set; }

        public string Type { get; set; }
        public List<string> Addresses { get; set; }
    }
}

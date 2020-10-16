using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DiviRpc.Responses.Blockchain
{
    public class GetTxOutSetInfoResponse
    {
        public int Height { get; set; }
        public string BestBlock { get; set; }
        public int Transactions { get; set; }
        public int TxOuts { get; set; }

        [JsonPropertyName("bytes_serialized")]
        public int BytesSerialized { get; set; }

        [JsonPropertyName("hash_serialized")]
        public string HashSerialized { get; set; }
        [JsonPropertyName("total_amount")]

        public double TotalAmount { get; set; }
    }
}

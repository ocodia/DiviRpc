using System.Text.Json.Serialization;

namespace DiviSharp.RPC.RequestResponse
{
    public class JsonRpcResponse<T>
    {
        [JsonPropertyName("result")]
        public T Result { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("error")]
        public JsonRpcError Error { get; set; }
    }
}

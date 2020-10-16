using DiviRpc.RPC.Specification;
using System.Text.Json.Serialization;

namespace DiviRpc.RPC.RequestResponse
{
    public class JsonRpcError
    {

        [JsonPropertyName("code")]
        public RpcErrorCode Code { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}

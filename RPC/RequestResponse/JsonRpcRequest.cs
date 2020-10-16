using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DiviRpc.RPC.RequestResponse
{
    public class JsonRpcRequest
    {
        public JsonRpcRequest(int id, string method, params object[] parameters)
        {
            Id = id;
            Method = method;
            Parameters = parameters?.ToList() ?? new List<object>();
        }

        [JsonPropertyName("method")]
        public string Method { get; set; }

        [JsonPropertyName("params")]
        public IList<object> Parameters { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        public byte[] GetBytes()
        {
            var json = JsonSerializer.Serialize(this);
            return Encoding.UTF8.GetBytes(json);
        }
    }
}

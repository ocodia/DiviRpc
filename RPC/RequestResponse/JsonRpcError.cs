using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using DiviSharp.RPC.Specification;

namespace DiviSharp.RPC.RequestResponse
{
    public class JsonRpcError
    {
        [JsonProperty(PropertyName = "code")]
        public RpcErrorCode Code { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }
}

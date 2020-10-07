using System;
using System.Collections.Generic;
using System.Text;

namespace DiviSharp.Responses
{
    public abstract class GetBlockResponseBase
    {
        public string Hash { get; set; }
        public int Confirmations { get; set; }
        public int Size { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Version { get; set; }
        public string MerkleRoot { get; set; }
        public double Difficulty { get; set; }
        public string ChainWork { get; set; }
        public string PreviousBlockHash { get; set; }
        public string NextBlockHash { get; set; }
        public string Bits { get; set; }
        public int Time { get; set; }
        public double MoneySupply { get; set; }
        public int Nonce { get; set; }
    }

    public class GetBlockResponse : GetBlockResponseBase
    {
        public GetBlockResponse()
        {
            Tx = new List<string>();
        }

        public List<string> Tx { get; set; }
    }


}


namespace DiviRpc.Responses.Blockchain
{
    public class GetBlockHeaderResponse
    {
        public int Version { get; set; }
        public string PreviousBlockHash { get; set; }
        public string Merkleroot { get; set; }
        public int Time { get; set; }
        public string Bits { get; set; }
        public int Nonce { get; set; }
    }
}

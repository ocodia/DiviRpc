using DiviRpc.Responses.Blockchain;
using DiviRpc.Responses.Masternodes;
using DiviRpc.Responses.Utilities;
using DiviRpc.Responses.Wallet;
using DiviRpc.RPC.Connector;
using DiviRpc.RPC.Specification;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiviRpc.Clients
{
    public class DiviRpcClient : IDiviRpcClient
    {

        protected readonly RpcConnector _rpcConnector;

        public DiviRpcClient(RpcConnection rpcConnection)
        {
            _rpcConnector = new RpcConnector(rpcConnection);
        }

        #region BlockChain

        public Task<string> GetBestBlockHash()
        {
            string response = _rpcConnector.MakeRequest<string>(RpcMethods.getbestblockhash);
            return Task.FromResult(response);
        }

        public Task<GetBlockResponse> GetBlock(string hash)
        {
            GetBlockResponse response = _rpcConnector.MakeRequest<GetBlockResponse>(RpcMethods.getblock, new object[] { hash, true });
            return Task.FromResult(response);
        }

        public Task<GetBlockchainInfoResponse> GetBlockchainInfo()
        {
            GetBlockchainInfoResponse response = _rpcConnector.MakeRequest<GetBlockchainInfoResponse>(RpcMethods.getblockchaininfo, new object[] { });
            return Task.FromResult(response);
        }

        public Task<int> GetBlockCount()
        {
            int response = _rpcConnector.MakeRequest<int>(RpcMethods.getblockcount);
            return Task.FromResult(response);
        }

        public Task<string> GetBlockHash(int block)
        {
            string response = _rpcConnector.MakeRequest<string>(RpcMethods.getblockhash, block);
            return Task.FromResult(response);
        }

        public Task<GetBlockHeaderResponse> GetBlockHeader(string hash)
        {
            GetBlockHeaderResponse response = _rpcConnector.MakeRequest<GetBlockHeaderResponse>(RpcMethods.getblockheader, new object[] { hash, true });
            return Task.FromResult(response);
        }

        public Task<List<GetChainTipsResponse>> GetChainTips()
        {
            var response = _rpcConnector.MakeRequest<List<GetChainTipsResponse>>(RpcMethods.getchaintips, new object[] { });
            return Task.FromResult(response);
        }

        public Task<double> GetDifficulty()
        {
            double response = _rpcConnector.MakeRequest<int>(RpcMethods.getdifficulty);
            return Task.FromResult(response);
        }

        public Task<GetTxOutResponse> GetTxOut(string tx, int vout)
        {
            var response = _rpcConnector.MakeRequest<GetTxOutResponse>(RpcMethods.gettxout, new object[] { tx, vout });
            return Task.FromResult(response);
        }

        public Task<GetTxOutSetInfoResponse> GetTxOutSetInfo()
        {
            var response = _rpcConnector.MakeRequest<GetTxOutSetInfoResponse>(RpcMethods.gettxout, new object[] { });
            return Task.FromResult(response);
        }

        public Task<bool> VerifyChain()
        {
            bool response = _rpcConnector.MakeRequest<bool>(RpcMethods.verifychain, new object[] { });
            return Task.FromResult(response);
        }

        #endregion

        #region Masternodes

        public Task<List<ListMasternodesResponse>> ListMasternodes()
        {

            var masternodes = _rpcConnector.MakeRequest<List<ListMasternodesResponse>>(RpcMethods.listmasternodes);

            return Task.FromResult(masternodes);
        }

        #endregion

        #region Utilities
        public Task<GetInfoResponse> GetInfo()
        {

            GetInfoResponse response = _rpcConnector.MakeRequest<GetInfoResponse>(RpcMethods.getinfo, null);

            return Task.FromResult(response);
        }

        #endregion

        #region Wallet
        public Task<GetWalletInfoResponse> GetWalletInfo()
        {

            GetWalletInfoResponse response = _rpcConnector.MakeRequest<GetWalletInfoResponse>(RpcMethods.getwalletinfo, null);

            return Task.FromResult(response);
        }

        public Task<Dictionary<string, decimal>> ListAccounts()
        {

            var accounts = _rpcConnector.MakeRequest<Dictionary<string, decimal>>(RpcMethods.listaccounts);

            return Task.FromResult(accounts);
        }

        public Task<List<ListTransactionsResponse>> ListTransactions(string account)
        {

            var accounts = _rpcConnector.MakeRequest<List<ListTransactionsResponse>>(RpcMethods.listtransactions, string.IsNullOrWhiteSpace(account) ? "*" : account);

            return Task.FromResult(accounts);
        }

        public Task<List<ListUnspentResponse>> ListUnspent()
        {

            var unspent = _rpcConnector.MakeRequest<List<ListUnspentResponse>>(RpcMethods.listunspent);

            return Task.FromResult(unspent);
        }

        public Task<GetStakingStatusResponse> GetStakingStatus()
        {
            var stakingstatus = _rpcConnector.MakeRequest<GetStakingStatusResponse>(RpcMethods.getstakingstatus);

            return Task.FromResult(stakingstatus);
        }

        public Task<string> GetReceivedByAccount(string account)
        {
            var stakingstatus = _rpcConnector.MakeRequest<string>(RpcMethods.getreceivedbyaccount, string.IsNullOrWhiteSpace(account) ? "" : account);

            return Task.FromResult(stakingstatus);
        }

        public Task<List<List<ListAddressGroupingsResponse>>> ListAddressGroupings()
        {
            var unstructuredResponse = _rpcConnector.MakeRequest<List<List<List<object>>>>(RpcMethods.listaddressgroupings);
            var structuredResponse = new List<List<ListAddressGroupingsResponse>>(unstructuredResponse.Count);

            for (var i = 0; i < unstructuredResponse.Count; i++)
            {
                for (var j = 0; j < unstructuredResponse[i].Count; j++)
                {
                    if (unstructuredResponse[i][j].Count > 1)
                    {
                        var response = new ListAddressGroupingsResponse
                        {
                            Address = unstructuredResponse[i][j][0].ToString()
                        };

                        decimal balance;
                        if (decimal.TryParse(unstructuredResponse[i][j][1].ToString(), out balance))
                        {
                            response.Balance = balance;
                        }

                        if (unstructuredResponse[i][j].Count > 2)
                        {
                            response.Account = unstructuredResponse[i][j][2].ToString();
                        }

                        if (structuredResponse.Count < i + 1)
                        {
                            structuredResponse.Add(new List<ListAddressGroupingsResponse>());
                        }

                        structuredResponse[i].Add(response);
                    }
                }
            }

            return Task.FromResult(structuredResponse);
        }

        #endregion
    }
}

using DiviRpc.Responses.Blockchain;
using DiviRpc.Responses.Masternodes;
using DiviRpc.Responses.Utilities;
using DiviRpc.Responses.Wallet;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiviRpc.Clients
{
    public interface IDiviRpcClient
    {
        #region BlockChain
        Task<string> GetBestBlockHash();
        Task<GetBlockResponse> GetBlock(string hash);
        Task<GetBlockchainInfoResponse> GetBlockchainInfo();
        Task<int> GetBlockCount();
        Task<string> GetBlockHash(int block);
        Task<GetBlockHeaderResponse> GetBlockHeader(string hash);
        Task<List<GetChainTipsResponse>> GetChainTips();
        Task<double> GetDifficulty();
        Task<GetTxOutResponse> GetTxOut(string tx, int vout);
        Task<GetTxOutSetInfoResponse> GetTxOutSetInfo();
        Task<bool> VerifyChain();
        #endregion

        #region Masternodes
        Task<List<ListMasternodesResponse>> ListMasternodes();
        #endregion

        #region Wallet
        Task<GetInfoResponse> GetInfo();
        #endregion

        #region Wallet
        Task<GetWalletInfoResponse> GetWalletInfo();
        Task<Dictionary<string, decimal>> ListAccounts();
        Task<List<ListTransactionsResponse>> ListTransactions(string account);
        Task<List<ListUnspentResponse>> ListUnspent();
        Task<GetStakingStatusResponse> GetStakingStatus();
        Task<string> GetReceivedByAccount(string account);
        Task<List<List<ListAddressGroupingsResponse>>> ListAddressGroupings();
        #endregion


    }
}

using DiviSharp.Responses.Blockchain;
using DiviSharp.Responses.Masternodes;
using DiviSharp.Responses.Utilities;
using DiviSharp.Responses.Wallet;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiviSharp.Clients
{
    public interface IDiviSharpClient
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

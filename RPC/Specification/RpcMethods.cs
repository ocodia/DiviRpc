namespace DiviSharp.RPC.Specification
{
    public enum RpcMethods
    {
        //== Blockchain ==

        //getbestblockhash,
        getblock,
        getblockchaininfo,
        getblockcount,
        getblockhash,
        //getblockheader,
        //getchaintips,
        //getdifficulty,
        //getmempoolinfo,
        //getrawmempool,
        //gettxout,
        //gettxoutsetinfo,
        //verifychain,

        //== Control ==

        getinfo,
        //help,
        //stop,

        //== Network ==

        //addnode,
        //getaddednodeinfo,
        //getconnectioncount,
        //getnettotals,
        //getnetworkinfo,
        //getpeerinfo,
        //ping,

        //== Masternode ==

        //allocatefunds,
        //fundmasternode,
        //startmasternode,
        //getmasternodecount,
        //getmasternodestatus,
        //getmasternodewinners,
        listmasternodes,
        //masternodeconnect,
        //mnsync
        //spork

        //== Util ==

        //createmultisig,
        //estimatefee,
        //estimatepriority,
        //estimatesmartfee,
        //estimatesmartpriority,
        //validateaddress,
        //mirroraddress,
        //verifymessage,

        //== Wallet ==

        //addmultisigaddress,
        //autocombinerewards,
        //backupwallet,
        //bip38decrypt,
        //bip38encrypt,
        //dumpprivkey,
        //dumpwallet,
        //getaccount,
        //getaccountaddress,
        //getaddressesbyaccount,        
        //getbalance,
        //getnewaddress,
        //getrawchangeaddress,
        getreceivedbyaccount,
        //getreceivedbyaddress,
        //getstakesplitthreshold,
        getstakingstatus,
        //gettransaction,
        //getunconfirmedbalance,
        getwalletinfo,
        //importaddress,
        //importprivkey,
        //importwallet,
        //keypoolrefill,
        listaccounts,
        listaddressgroupings,
        //listlockunspent,
        //listreceivedbyaccount,
        //listreceivedbyaddress,
        //listsinceblock,
        listtransactions,
        listunspent,
        //lockunspent,
        //sendfrom,
        //sendmany,
        //sendtoaddress,
        //setaccount,
        //settxfee,
        //signmessage,
        //walletlock,
        //walletpassphrase,
        //walletpassphrasechange
    }
}

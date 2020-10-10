# DiviSharp

DiviSharp is a .NET Class Library for interacting with the [Divi Project](https://diviproject.org/) RPC client.

## How to use

Create a new instance of the DiviSharpRPCService with your RPC connection details

```

DiviSharpRPCService divi = new DiviSharpRPCService(new RpcConnection()
{
    Username = "",
    Password = "",
    Url = ""
});

```

Use the DiviSharpRPCService to get info from the daemon
```
GetInfoResponse getinfo = await divi.GetInfo();
```

## Capabilities

I hope to include most of these, but only the ones with ✅ have been done so far.

### Blockchain

* getbestblockhash ✅
* getblock ✅
* getblockchaininfo	✅
* getblockcount	✅
* getblockhash	✅
* getblockheader ✅
* getchaintips ✅
* getdifficulty ✅
* getmempoolinfo
* getrawmempool
* gettxout ✅
* gettxoutsetinfo ✅
* verifychain ✅

### Control

* getinfo ✅
* help
* stop

### Network

* addnode
* getaddednodeinfo
* getconnectioncount
* getnettotals
* getnetworkinfo
* getpeerinfo
* ping

### Masternodes

* allocatefunds
* fundmasternode
* startmasternode
* getmasternodecount
* getmasternodestatus
* getmasternodewinners
* listmasternodes ✅
* masternodeconnect
* mnsync
* spork

### Utilities

* createmultisig
* estimatefee
* estimatepriority
* estimatesmartfee
* estimatesmartpriority
* validateaddress
* mirroraddress
* verifymessage

### Wallet

* addmultisigaddress
* autocombinerewards
* backupwallet
* bip38decrypt
* bip38encrypt
* dumpprivkey
* dumpwallet
* getaccount
* getaccountaddress
* getaddressesbyaccount      
* getbalance
* getnewaddress
* getrawchangeaddress
* getreceivedbyaccount ✅
* getreceivedbyaddress
* getstakesplitthreshold
* getstakingstatus ✅
* gettransaction
* getunconfirmedbalance
* getwalletinfo ✅
* importaddress
* importprivkey
* importwallet
* keypoolrefill
* listaccounts ✅
* listaddressgroupings ✅
* listlockunspent
* listreceivedbyaccount
* listreceivedbyaddress
* listsinceblock
* listtransactions ✅
* listunspent ✅
* lockunspent
* sendfrom
* sendmany
* sendtoaddress
* setaccount
* settxfee
* signmessage
* walletlock
* walletpassphrase
* walletpassphrasechange
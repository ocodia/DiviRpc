# DiviSharp

DiviSharp is a client library to connect to the [Divi Project](https://diviproject.org/) RPC in C#.

## How to use

Use the IDiviSharpClient interface to create a new DiviSharpClient with your RPC connection details:

```

IDiviSharpClient divi = new DiviSharpClient(new RpcConnection()
{
    Username = "",
    Password = "",
    Url = ""
});

```

Use the DiviSharp client to get info from the daemon
```
var getinfo = await divi.GetInfo();
Console.WriteLine(getinfo.Blocks.ToString());
```

## Methods

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
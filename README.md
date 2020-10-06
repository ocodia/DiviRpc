# DiviSharp

DiviSharp is a .NET Class Library for interacting with the [Divi Project](https://diviproject.org/) RPC client.

## How to use

Define the RPC connection details (remember to use your own RPC username, password and URL details)

```

RpcConnection rpcConnection = new RpcConnection();
rpcConnection.Username = "diviRpcUsername";
rpcConnection.Password = "diviRpcPassword";
rpcConnection.Url = "diviRpcUrl";
```

Create a new instance of the DiviSharpRPCService with those connection details

```
DiviSharpRPCService diviSharpRPCService = new DiviSharpRPCService(rpcConnection);
```

Use the DiviSharpRPCService to get info from the daemon
```
GetInfoResponse getinfo = await diviSharpService.GetInfo();
```

# ProxyConfigurationBuilder

Represents the proxy server configurations for API calls. Start building by using `new ProxyConfigurationBuilder("http://your.proxy.host")`.

## Builder Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| <code>Port(int port)</code> | Sets the port used to connect to the proxy server. Default is `8080`. | <code>Builder</code> |
| <code>Auth(string user, string pass)</code> | Sets both username and password in a single method. | <code>Builder</code> |
| <code>Tunnel(bool tunnel)</code> | Enables or disables HTTP tunneling through the proxy server. | <code>Builder</code> |

### Client Initialization with Proxy Configuration

To configure the SDK to use a proxy server, initialize the proxy configuration during client setup as shown in the Usage Example.

## Usage Example

```csharp
var client = new PaypalServerSdkClient.Builder()
    .HttpClientConfig(config => config
        .Proxy(
            new ProxyConfigurationBuilder("http://localhost")
                .Port(8080)
                .Tunnel(false)
                .Auth("user", "pass")
        )
    )
    .Build();
```


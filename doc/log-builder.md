
# LogBuilder

The builder for logging configuration. Create instance using `LogBuilder.Build()`

## Methods

| Name | Description |
|  --- | --- |
| <code>Logger(ILogger logger)</code> | Sets the implementation of Microsoft.Extensions.Logging.ILogger for logging. **The default implementation is ConsoleLogger.** |
| <code>LogLevel(LogLevel? logLevel)</code> | Sets the Microsoft.Extensions.Logging.LogLevel, which defines logging severity levels. **The default value is LogLevel.Information.** |
| <code>MaskSensitiveHeaders(bool maskSensitiveHeaders)</code> | Sets the global setting to mask sensitive HTTP headers in both requests and responses before logging, safeguarding confidential data. **The default value is True.** |
| <code>RequestConfig(Action<[`LogRequestBuilder`](../doc/log-request-builder.md)> action)</code> | Sets the request logging configuration with the provided builder action. **By default, request logging is enabled, excluding both the body and headers.** |
| <code>ResponseConfig(Action<[`LogResponseBuilder`](../doc/log-response-builder.md)> action)</code> | Sets the response logging configuration with the provided builder action. **By default, response logging is enabled, excluding both the body and headers.** |

## Usage Example

### Client Initialization with Custom Logger

To use a custom logger, you can provide any implementation of Microsoft.Extensions.Logging.ILogger directly during SDK client initialization.

```csharp
using Microsoft.Extensions.Logging;
using PaypalServerSdk.Standard;

namespace ConsoleApp;

var factory = LoggerFactory.Create(builder => { builder.AddConsole(); });
var logger = factory.CreateLogger<PaypalServerSdkClient>();

var client = new PaypalServerSdkClient.Builder()
    .LoggingConfig(config => config
        .Logger(logger)
        .LogLevel(LogLevel.Information)
        .RequestConfig(reqConfig => reqConfig.Body(true))
        .ResponseConfig(respConfig => respConfig.Headers(true))
    )
    .Build();
```


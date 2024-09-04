
# LogBuilder Class

The builder for logging configuration. Create instance using `LogBuilder.Build()`

## Methods

| Name | Description |
|  --- | --- |
| Logger(ILogger logger) | Sets the implementation of Microsoft.Extensions.Logging.ILogger for logging. **The default implementation is ConsoleLogger.** |
| LogLevel(LogLevel? logLevel) | Sets the Microsoft.Extensions.Logging.LogLevel, which defines logging severity levels. **The default value is LogLevel.Information.** |
| MaskSensitiveHeaders(bool maskSensitiveHeaders) | Sets the global setting to mask sensitive HTTP headers in both requests and responses before logging, safeguarding confidential data. **The default value is True.** |
| RequestConfig(Action<[LogRequestBuilder](log-request-builder.md)> action) | Sets the request logging configuration with the provided builder action. **By default, request logging is enabled, excluding both the body and headers.** |
| ResponseConfig(Action<[LogResponseBuilder](log-response-builder.md)> action) | Sets the response logging configuration with the provided builder action. **By default, response logging is enabled, excluding both the body and headers.** |

## Usage Example

### Client Initialization with Custom Logger

To use a custom logger, you can provide any implementation of Microsoft.Extensions.Logging.ILogger directly during SDK client initialization.

```csharp
using Microsoft.Extensions.Logging;
using PayPalRESTAPIs.Standard;

var factory = LoggerFactory.Create(builder => { builder.AddConsole(); });
var logger = factory.CreateLogger<PayPalRESTAPIsClient>();

var client = new PayPalRESTAPIsClient.Builder()
    .LoggingConfig(config => config
        .Logger(logger)
        .LogLevel(LogLevel.Information)
        .RequestConfig(reqConfig => reqConfig.Body(true))
        .ResponseConfig(respConfig => respConfig.Headers(true))
    )
    .Build();
```


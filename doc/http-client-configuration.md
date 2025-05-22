
# HttpClientConfiguration

HttpClientConfiguration represents the current state of the Http Client.

## Properties

| Name | Description | Type |
|  --- | --- | --- |
| <code>Timeout</code> | Http client timeout. | `TimeSpan` |
| <code>NumberOfRetries</code> | Number of times the request is retried. | `int` |
| <code>BackoffFactor</code> | Exponential backoff factor for duration between retry calls. | `int` |
| <code>RetryInterval</code> | The time interval between the endpoint calls. | `double` |
| <code>MaximumRetryWaitTime</code> | The maximum retry wait time. | `TimeSpan` |
| <code>StatusCodesToRetry</code> | List of Http status codes to invoke retry. | `IList<int>` |
| <code>RequestMethodsToRetry</code> | List of Http request methods to invoke retry. | `IList<HttpMethod>` |
| <code>HttpClientInstance</code> | HttpClient instance used to make the HTTP calls | `HttpClient` |
| <code>OverrideHttpClientConfiguration</code> | Boolean which allows the SDK to override http client instance's settings used for features like retries, timeouts etc. | `bool` |

## Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `ToBuilder()` | Creates an object of the HttpClientConfiguration using the values provided for the builder. | [`Builder`](../doc/http-client-configuration-builder.md) |


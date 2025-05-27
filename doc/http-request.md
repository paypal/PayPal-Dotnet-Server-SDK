
# HttpRequest

HttpRequest stores necessary information about the http request.

## Properties

| Name | Description | Type |
|  --- | --- | --- |
| <code>HttpMethod</code> | The HTTP verb to use for this request. | `HttpMethod` |
| <code>QueryUrl</code> | The query url for the http request. | `string` |
| <code>QueryParameters</code> | Query parameters collection for the current http request. | `Dictionary<string, object>` |
| <code>Headers</code> | Headers collection for the current http request. | `Dictionary<string, string>` |
| <code>FormParameters</code> | Form parameters for the current http request. | `List<KeyValuePair<string, object>>` |
| <code>Body</code> | Optional raw string to send as request body. | `object` |
| <code>Username</code> | Optional username for Basic Auth. | `string` |
| <code>Password</code> | Optional password for Basic Auth. | `string` |

## Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `AddHeaders(Dictionary<string, string> HeadersToAdd)` | Concatenate values from a Dictionary to this object. | `Dictionary<string, string>` |
| `AddQueryParameters(Dictionary<string, object> queryParameters)` | Concatenate values from a Dictionary to query parameters dictionary. | `void` |


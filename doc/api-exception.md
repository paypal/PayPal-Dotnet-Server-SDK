
# ApiException

This is the base class for all exceptions that represent an error response from the server. It inherits from [`System.Exception`](https://learn.microsoft.com/en-us/dotnet/api/system.exception).

## Properties

| Name | Description | Type |
|  --- | --- | --- |
| <code>ResponseCode</code> | Gets the HTTP response code from the API request. | `int` |
| <code>HttpContext</code> | Gets or sets the HttpContext for the request and response. | [`HttpContext`](../doc/http-context.md) |

## Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `ToString()` | Returns a human-readable string representation of the `ApiException`, including the error message and status code. | `string` |


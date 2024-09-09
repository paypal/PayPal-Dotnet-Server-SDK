
# ApiException Class

This is the base class for all exceptions that represent an error response from the server.

## Properties

| Name | Description | Type |
|  --- | --- | --- |
| ResponseCode | Gets the HTTP response code from the API request. | `int` |
| HttpContext | Gets or sets the HttpContext for the request and response. | [`HttpContext`](http-context.md) |

## Constructors

| Name | Description |
|  --- | --- |
| ApiException`(string reason,` [`HttpContext`](http-context.md) `context = null)` | Initializes a new instance of the <see cref="ApiException"/> class. |



# LogRequestBuilder Class

The builder for request logging configuration. Create instance using `LogRequestBuilder.Build()`

## Methods

| Name | Description |
|  --- | --- |
| Body(bool includeBody) | Sets the logging of the request body. **By default, the body is not logged.** |
| Headers(bool includeHeaders) | Sets the logging of the request headers. **By default, the headers are not logged.** |
| IncludeQueryInPath(bool includeQueryInPath) | Sets the inclusion of query parameters in the logged request path. **By default, query parameters aren't included in the request path.** |
| IncludeHeaders(params string[] headersToInclude) | Sets the headers that will exclusively be included in the log output of the request headers. **By default, all headers are included.** |
| ExcludeHeaders(params string[] headersToExclude) | Sets the headers that will be excluded in the log output of the request headers. **By default, no headers are excluded.** |
| UnmaskHeaders(params string[] headersToUnmask) | Sets the headers that will be unmasked in the log output of the request headers. **By default, no headers are unmasked.** |



# LogRequestBuilder

The builder for request logging configuration. Create instance using `LogRequestBuilder.Build()`

## Methods

| Name | Description |
|  --- | --- |
| <code>Body(bool includeBody)</code> | Sets the logging of the request body. **By default, the body is not logged.** |
| <code>Headers(bool includeHeaders)</code> | Sets the logging of the request headers. **By default, the headers are not logged.** |
| <code>IncludeQueryInPath(bool includeQueryInPath)</code> | Sets the inclusion of query parameters in the logged request path. **By default, query parameters aren't included in the request path.** |
| <code>IncludeHeaders(params string[] headersToInclude)</code> | Sets the headers that will exclusively be included in the log output of the request headers. **By default, all headers are included.** |
| <code>ExcludeHeaders(params string[] headersToExclude)</code> | Sets the headers that will be excluded in the log output of the request headers. **By default, no headers are excluded.** |
| <code>UnmaskHeaders(params string[] headersToUnmask)</code> | Sets the headers that will be unmasked in the log output of the request headers. **By default, no headers are unmasked.** |


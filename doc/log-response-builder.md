
# LogResponseBuilder Class

The builder for response logging configuration. Create instance using `LogResponseBuilder.Build()`

## Methods

| Name | Description |
|  --- | --- |
| Body(bool includeBody) | Sets the logging of the response body. **By default, the body is not logged.** |
| Headers(bool includeHeaders) | Sets the logging of the response headers. **By default, the headers are not logged.** |
| IncludeHeaders(params string[] headersToInclude) | Sets the headers that will exclusively be included in the log output of the response headers. **By default, all headers are included.** |
| ExcludeHeaders(params string[] headersToExclude) | Sets the headers that will be excluded in the log output of the response headers. **By default, no headers are excluded.** |
| UnmaskHeaders(params string[] headersToUnmask) | Sets the headers that will be unmasked in the log output of the response headers. **By default, no headers are unmasked.** |


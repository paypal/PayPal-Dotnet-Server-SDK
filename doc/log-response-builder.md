
# LogResponseBuilder

The builder for response logging configuration. Create instance using `LogResponseBuilder.Build()`

## Methods

| Name | Description |
|  --- | --- |
| <code>Body(bool includeBody)</code> | Sets the logging of the response body. **By default, the body is not logged.** |
| <code>Headers(bool includeHeaders)</code> | Sets the logging of the response headers. **By default, the headers are not logged.** |
| <code>IncludeHeaders(params string[] headersToInclude)</code> | Sets the headers that will exclusively be included in the log output of the response headers. **By default, all headers are included.** |
| <code>ExcludeHeaders(params string[] headersToExclude)</code> | Sets the headers that will be excluded in the log output of the response headers. **By default, no headers are excluded.** |
| <code>UnmaskHeaders(params string[] headersToUnmask)</code> | Sets the headers that will be unmasked in the log output of the response headers. **By default, no headers are unmasked.** |


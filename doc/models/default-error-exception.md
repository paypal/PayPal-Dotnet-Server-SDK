
# Default Error Exception

The error details.

## Structure

`DefaultErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The human-readable, unique name of the error. |
| `Message` | `string` | Required | The message that describes the error. |
| `DebugId` | `string` | Required | The PayPal internal ID. Used for correlation purposes. |
| `InformationLink` | `string` | Optional, Read-only | The information link, or URI, that shows detailed information about this error for the developer. |
| `Details` | [`List<TransactionSearchErrorDetails>`](../../doc/models/transaction-search-error-details.md) | Optional | An array of additional details about the error. |
| `Links` | [`List<LinkDescription>`](../../doc/models/link-description.md) | Optional, Read-only | An array of request-related [HATEOAS links](/docs/api/reference/api-responses/#hateoas-links). |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is DefaultErrorException)
    {
        // TODO: Handle DefaultErrorException
        Console.WriteLine(e.Message);
    }
}
```



# Search Error Exception

The error details.

## Structure

`SearchErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The human-readable, unique name of the error. |
| `Message` | `string` | Required | The message that describes the error. |
| `DebugId` | `string` | Required | The PayPal internal ID. Used for correlation purposes. |
| `InformationLink` | `string` | Optional, Read-only | The information link, or URI, that shows detailed information about this error for the developer. |
| `Details` | [`List<TransactionSearchErrorDetails>`](../../doc/models/transaction-search-error-details.md) | Optional | An array of additional details about the error. |
| `Links` | [`List<LinkDescription>`](../../doc/models/link-description.md) | Optional, Read-only | An array of request-related [HATEOAS links](/docs/api/reference/api-responses/#hateoas-links). |
| `TotalItems` | `int?` | Optional | The total number of transactions. Valid only for `RESULTSET_TOO_LARGE`.<br><br>**Constraints**: `>= 0`, `<= 2147483647` |
| `MaximumItems` | `int?` | Optional | The maximum number of transactions. Valid only for `RESULTSET_TOO_LARGE`.<br><br>**Constraints**: `>= 0`, `<= 2147483647` |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is SearchErrorException)
    {
        // TODO: Handle SearchErrorException
        Console.WriteLine(e.Message);
    }
}
```


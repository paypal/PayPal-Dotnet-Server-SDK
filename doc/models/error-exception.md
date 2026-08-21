
# Error Exception

The error details.

## Structure

`ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The human-readable, unique name of the error. |
| `Message` | `string` | Required | The message that describes the error. |
| `DebugId` | `string` | Required | The PayPal internal ID. Used for correlation purposes. |
| `Details` | [`List<ErrorDetails>`](../../doc/models/error-details.md) | Optional | An array of additional details about the error. |
| `Links` | [`List<LinkDescription>`](../../doc/models/link-description.md) | Optional, Read-only | An array of request-related [HATEOAS links](https://developer.paypal.com/api/rest/responses/#hateoas-links). |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is ErrorException)
    {
        // TODO: Handle ErrorException
        Console.WriteLine(e.Message);
    }
}
```


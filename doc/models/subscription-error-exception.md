
# Subscription Error Exception

The error details.

## Structure

`SubscriptionErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The human-readable, unique name of the error. |
| `Message` | `string` | Required | The message that describes the error. |
| `DebugId` | `string` | Required | The PayPal internal ID. Used for correlation purposes. |
| `InformationLink` | `string` | Optional, Read-only | The information link, or URI, that shows detailed information about this error for the developer. |
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
    if (e is SubscriptionErrorException)
    {
        // TODO: Handle SubscriptionErrorException
        Console.WriteLine(e.Message);
    }
}
```


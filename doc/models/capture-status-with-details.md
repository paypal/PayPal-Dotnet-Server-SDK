
# Capture Status with Details

The status and status details of a captured payment.

## Structure

`CaptureStatusWithDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | [`CaptureStatus?`](../../doc/models/capture-status.md) | Optional, Read-only | The status of the captured payment. |
| `StatusDetails` | [`CaptureStatusDetails`](../../doc/models/capture-status-details.md) | Optional | The details of the captured payment status. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

CaptureStatusWithDetails captureStatusWithDetails = new CaptureStatusWithDetails
{
    StatusDetails = new CaptureStatusDetails
    {
        Reason = CaptureIncompleteReason.VerificationRequired,
    },
};
```


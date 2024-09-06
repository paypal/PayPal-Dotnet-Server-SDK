
# Refund Status With Details

The refund status with details.

## Structure

`RefundStatusWithDetails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | [`RefundStatus?`](../../doc/models/refund-status.md) | Optional | The status of the refund. |
| `StatusDetails` | [`RefundStatusDetails`](../../doc/models/refund-status-details.md) | Optional | The details of the refund status. |

## Example (as JSON)

```json
{
  "status": "PENDING",
  "status_details": {
    "reason": "ECHECK"
  }
}
```


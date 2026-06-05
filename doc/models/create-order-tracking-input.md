
# Create Order Tracking Input

Input structure for the method CreateOrderTracking

## Structure

`CreateOrderTrackingInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | The ID of the order that the tracking information is associated with.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `36`, *Pattern*: `^[A-Z0-9]+$` |
| `ContentType` | `string` | Required, Constant | **Value**: `"application/json"` |
| `Body` | [`OrderTrackerRequest`](../../doc/models/order-tracker-request.md) | Required | - |
| `PaypalAuthAssertion` | `string` | Optional | An API-caller-provided JSON Web Token (JWT) assertion that identifies the merchant. For details, see PayPal-Auth-Assertion. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

CreateOrderTrackingInput createOrderTrackingInput = new CreateOrderTrackingInput
{
    Id = "id0",
    Body = new OrderTrackerRequest
    {
        CaptureId = "capture_id8",
        TrackingNumber = "tracking_number4",
        Carrier = ShipmentCarrier.Piggyship,
        CarrierNameOther = "carrier_name_other8",
        NotifyPayer = false,
        Items = new List<OrderTrackerItem>
        {
            new OrderTrackerItem
            {
                Name = "name8",
                Quantity = "quantity4",
                Sku = "sku6",
                Url = "url2",
                ImageUrl = "image_url4",
            },
            new OrderTrackerItem
            {
                Name = "name8",
                Quantity = "quantity4",
                Sku = "sku6",
                Url = "url2",
                ImageUrl = "image_url4",
            },
            new OrderTrackerItem
            {
                Name = "name8",
                Quantity = "quantity4",
                Sku = "sku6",
                Url = "url2",
                ImageUrl = "image_url4",
            },
        },
    },
    PaypalAuthAssertion = "PayPal-Auth-Assertion0",
};
```


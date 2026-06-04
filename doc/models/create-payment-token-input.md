
# Create Payment Token Input

Input structure for the method CreatePaymentToken

## Structure

`CreatePaymentTokenInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ContentType` | `string` | Required, Constant | **Value**: `"application/json"` |
| `Body` | [`PaymentTokenRequest`](../../doc/models/payment-token-request.md) | Required | Payment Token creation with a financial instrument and an optional customer_id. |
| `PaypalRequestId` | `string` | Optional | The server stores keys for 3 hours.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `108`, *Pattern*: `^.*$` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

CreatePaymentTokenInput createPaymentTokenInput = new CreatePaymentTokenInput
{
    Body = new PaymentTokenRequest
    {
        PaymentSource = new PaymentTokenRequestPaymentSource
        {
            Card = new PaymentTokenRequestCard
            {
                Name = "name6",
                Number = "number6",
                Expiry = "expiry4",
                SecurityCode = "security_code8",
                Brand = CardBrand.CbNationale,
            },
            Token = new VaultTokenRequest
            {
                Id = "id6",
                Type = VaultTokenRequestType.SetupToken,
            },
        },
        Customer = new Customer
        {
            Id = "id0",
            MerchantCustomerId = "merchant_customer_id2",
        },
    },
    PaypalRequestId = "PayPal-Request-Id6",
};
```


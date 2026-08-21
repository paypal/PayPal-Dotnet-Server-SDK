
# Subscription Payment Source Response

The payment source used to fund the payment.

## Structure

`SubscriptionPaymentSourceResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Card` | [`CardResponseWithBillingAddress`](../../doc/models/card-response-with-billing-address.md) | Optional | The payment card used to fund the payment. Card can be a credit or debit card. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

SubscriptionPaymentSourceResponse subscriptionPaymentSourceResponse = new SubscriptionPaymentSourceResponse
{
    Card = new CardResponseWithBillingAddress
    {
        Name = "name6",
        BillingAddress = new Address
        {
            CountryCode = "country_code8",
            AddressLine1 = "address_line_12",
            AddressLine2 = "address_line_28",
            AdminArea2 = "admin_area_28",
            AdminArea1 = "admin_area_14",
            PostalCode = "postal_code0",
        },
        Expiry = "expiry4",
        CurrencyCode = "currency_code2",
    },
};
```


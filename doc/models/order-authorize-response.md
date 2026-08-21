
# Order Authorize Response

The order authorize response.

## Structure

`OrderAuthorizeResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CreateTime` | `string` | Optional | The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |
| `UpdateTime` | `string` | Optional | The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |
| `Id` | `string` | Optional, Read-only | The ID of the order. |
| `PaymentSource` | [`OrderAuthorizeResponsePaymentSource`](../../doc/models/order-authorize-response-payment-source.md) | Optional | The payment source used to fund the payment. |
| `Intent` | [`CheckoutPaymentIntent?`](../../doc/models/checkout-payment-intent.md) | Optional | The intent to either capture payment immediately or authorize a payment for an order after order creation. |
| `ProcessingInstruction` | [`ProcessingInstruction?`](../../doc/models/processing-instruction.md) | Optional | The instruction to process an order. |
| `Payer` | [`Payer`](../../doc/models/payer.md) | Optional | The customer who approves and pays for the order. The customer is also known as the payer. |
| `PurchaseUnits` | [`List<PurchaseUnit>`](../../doc/models/purchase-unit.md) | Optional | An array of purchase units. Each purchase unit establishes a contract between a customer and merchant. Each purchase unit represents either a full or partial order that the customer intends to purchase from the merchant.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10` |
| `Status` | [`OrderStatus?`](../../doc/models/order-status.md) | Optional | The order status.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[0-9A-Z_]+$` |
| `Links` | [`List<LinkDescription>`](../../doc/models/link-description.md) | Optional, Read-only | An array of request-related HATEOAS links. To complete payer approval, use the `approve` link to redirect the payer. The API caller has 6 hours (default setting, this which can be changed by your account manager to 24/48/72 hours to accommodate your use case) from the time the order is created, to redirect your payer. Once redirected, the API caller has 6 hours for the payer to approve the order and either authorize or capture the order. If you are not using the PayPal JavaScript SDK to initiate PayPal Checkout (in context) ensure that you include `application_context.return_url` is specified or you will get "We're sorry, Things don't appear to be working at the moment" after the payer approves the payment. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

OrderAuthorizeResponse orderAuthorizeResponse = new OrderAuthorizeResponse
{
    CreateTime = "create_time8",
    UpdateTime = "update_time4",
    PaymentSource = new OrderAuthorizeResponsePaymentSource
    {
        Card = new CardResponse
        {
            Name = "name6",
            Brand = CardBrand.CbNationale,
            Type = CardType.Unknown,
        },
        Paypal = new PaypalWalletResponse
        {
            EmailAddress = "email_address0",
            AccountId = "account_id4",
            Name = new Name
            {
                GivenName = "given_name2",
                Surname = "surname8",
            },
            PhoneType = PhoneType.Fax,
        },
        ApplePay = new ApplePayPaymentObject
        {
            Id = "id0",
            Token = "token6",
            Name = "name0",
            EmailAddress = "email_address8",
            PhoneNumber = new PhoneNumber
            {
                NationalNumber = "national_number6",
            },
        },
        GooglePay = new GooglePayWalletResponse
        {
            Name = "name8",
            EmailAddress = "email_address6",
            PhoneNumber = new PhoneNumberWithCountryCode
            {
                CountryCode = "country_code2",
                NationalNumber = "national_number6",
            },
            Card = new GooglePayCardResponse
            {
                Name = "name6",
                Type = CardType.Unknown,
                Brand = CardBrand.CbNationale,
                BillingAddress = new Address
                {
                    CountryCode = "country_code8",
                    AddressLine1 = "address_line_12",
                    AddressLine2 = "address_line_28",
                    AdminArea2 = "admin_area_28",
                    AdminArea1 = "admin_area_14",
                    PostalCode = "postal_code0",
                },
            },
        },
        Venmo = new VenmoWalletResponse
        {
            EmailAddress = "email_address4",
            AccountId = "account_id8",
            UserName = "user_name2",
            Name = new Name
            {
                GivenName = "given_name2",
                Surname = "surname8",
            },
            PhoneNumber = new PhoneNumber
            {
                NationalNumber = "national_number6",
            },
        },
    },
    Intent = CheckoutPaymentIntent.Capture,
};
```


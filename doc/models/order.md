
# Order

The order details.

## Structure

`Order`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CreateTime` | `string` | Optional | The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |
| `UpdateTime` | `string` | Optional | The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |
| `Id` | `string` | Optional, Read-only | The ID of the order. |
| `PaymentSource` | [`PaymentSourceResponse`](../../doc/models/payment-source-response.md) | Optional | The payment source used to fund the payment. |
| `Intent` | [`CheckoutPaymentIntent?`](../../doc/models/checkout-payment-intent.md) | Optional | The intent to either capture payment immediately or authorize a payment for an order after order creation. |
| `ProcessingInstruction` | [`ProcessingInstruction?`](../../doc/models/processing-instruction.md) | Optional | The instruction to process an order. |
| `Payer` | [`Payer`](../../doc/models/payer.md) | Optional | DEPRECATED. The customer is also known as the payer. The Payer object was intended to only be used with the `payment_source.paypal` object. In order to make this design more clear, the details in the `payer` object are now available under `payment_source.paypal`. Please use `payment_source.paypal`. |
| `PurchaseUnits` | [`List<PurchaseUnit>`](../../doc/models/purchase-unit.md) | Optional | An array of purchase units. Each purchase unit establishes a contract between a customer and merchant. Each purchase unit represents either a full or partial order that the customer intends to purchase from the merchant.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10` |
| `Status` | [`OrderStatus?`](../../doc/models/order-status.md) | Optional | The order status.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[0-9A-Z_]+$` |
| `Links` | [`List<LinkDescription>`](../../doc/models/link-description.md) | Optional, Read-only | An array of request-related HATEOAS links. To complete payer approval, use the `approve` link to redirect the payer. The API caller has 6 hours (default setting, this which can be changed by your account manager to 24/48/72 hours to accommodate your use case) from the time the order is created, to redirect your payer. Once redirected, the API caller has 6 hours for the payer to approve the order and either authorize or capture the order. If you are not using the PayPal JavaScript SDK to initiate PayPal Checkout (in context) ensure that you include `application_context.return_url` is specified or you will get "We're sorry, Things don't appear to be working at the moment" after the payer approves the payment. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

Order order = new Order
{
    CreateTime = "create_time2",
    UpdateTime = "update_time8",
    PaymentSource = new PaymentSourceResponse
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
        Bancontact = new BancontactPaymentObject
        {
            Name = "name0",
            CountryCode = "country_code0",
            Bic = "bic2",
            IbanLastChars = "iban_last_chars8",
            CardLastDigits = "card_last_digits4",
        },
        Blik = new BlikPaymentObject
        {
            Name = "name2",
            CountryCode = "country_code2",
            Email = "email4",
            OneClick = new BlikOneClickPaymentObject
            {
                ConsumerReference = "consumer_reference2",
            },
        },
        Eps = new EpsPaymentObject
        {
            Name = "name6",
            CountryCode = "country_code6",
            Bic = "bic8",
        },
    },
    Intent = CheckoutPaymentIntent.Capture,
};
```


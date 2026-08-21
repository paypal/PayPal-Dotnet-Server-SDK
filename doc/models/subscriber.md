
# Subscriber

The subscriber response information.

## Structure

`Subscriber`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EmailAddress` | `string` | Optional | The internationalized email address. Note: Up to 64 characters are allowed before and 255 characters are allowed after the @ sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted @ sign exists.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `254`, *Pattern*: ``(?:[a-zA-Z0-9!#$%&'*+/=?^_`{\|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{\|}~-]+)*\|(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]\|\[\x01-\x09\x0b\x0c\x0e-\x7f])*")@(?:(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\|\[(?:(?:(2(5[0-5]\|[0-4][0-9])\|1[0-9][0-9]\|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]\|[0-4][0-9])\|1[0-9][0-9]\|[1-9]?[0-9])\|[a-zA-Z0-9-]*[a-zA-Z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]\|\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])`` |
| `PayerId` | `string` | Optional | The account identifier for a PayPal account.<br><br>**Constraints**: *Minimum Length*: `13`, *Maximum Length*: `13`, *Pattern*: `^[2-9A-HJ-NP-Z]{13}$` |
| `Name` | [`Name`](../../doc/models/name.md) | Optional | The name of the party. |
| `ShippingAddress` | [`ShippingDetails`](../../doc/models/shipping-details.md) | Optional | The shipping details. |
| `PaymentSource` | [`SubscriptionPaymentSourceResponse`](../../doc/models/subscription-payment-source-response.md) | Optional | The payment source used to fund the payment. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

Subscriber subscriber = new Subscriber
{
    EmailAddress = "email_address8",
    PayerId = "payer_id8",
    Name = new Name
    {
        GivenName = "given_name2",
        Surname = "surname8",
    },
    ShippingAddress = new ShippingDetails
    {
        Name = new ShippingName
        {
            FullName = "full_name6",
        },
        EmailAddress = "email_address8",
        PhoneNumber = new PhoneNumberWithCountryCode
        {
            CountryCode = "country_code2",
            NationalNumber = "national_number6",
        },
        Type = FulfillmentType.PickupInStore,
        Options = new List<ShippingOption>
        {
            new ShippingOption
            {
                Id = "id2",
                Label = "label2",
                Selected = false,
                Type = ShippingType.Shipping,
                Amount = new Money
                {
                    CurrencyCode = "currency_code6",
                    MValue = "value0",
                },
            },
        },
    },
    PaymentSource = new SubscriptionPaymentSourceResponse
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
    },
};
```


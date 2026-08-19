
# Create Subscription Request

The create subscription request details.

## Structure

`CreateSubscriptionRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PlanId` | `string` | Required | The ID of the plan.<br><br>**Constraints**: *Minimum Length*: `26`, *Maximum Length*: `26`, *Pattern*: `^P-[A-Z0-9]*$` |
| `StartTime` | `string` | Optional | The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional. Note: The regular expression provides guidance but does not reject all invalid dates.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |
| `Quantity` | `string` | Optional | The quantity of the product in the subscription.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `32`, *Pattern*: `^([0-9]+\|([0-9]+)?[.][0-9]+)$` |
| `ShippingAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `Subscriber` | [`SubscriberRequest`](../../doc/models/subscriber-request.md) | Optional | The subscriber request information . |
| `AutoRenewal` | `bool?` | Optional | DEPRECATED. Indicates whether the subscription auto-renews after the billing cycles complete.<br><br>**Default**: `false` |
| `ApplicationContext` | [`SubscriptionApplicationContext`](../../doc/models/subscription-application-context.md) | Optional | DEPRECATED. The application context, which customizes the payer experience during the subscription approval process with PayPal. |
| `CustomId` | `string` | Optional | The custom id for the subscription. Can be invoice id.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `127`, *Pattern*: `^[\x20-\x7E]+` |
| `Plan` | [`PlanOverride`](../../doc/models/plan-override.md) | Optional | An inline plan object to customise the subscription. You can override plan level default attributes by providing customised values for the subscription in this object. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

CreateSubscriptionRequest createSubscriptionRequest = new CreateSubscriptionRequest
{
    PlanId = "plan_id8",
    StartTime = "start_time0",
    Quantity = "quantity2",
    ShippingAmount = new Money
    {
        CurrencyCode = "currency_code0",
        MValue = "value6",
    },
    Subscriber = new SubscriberRequest
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
        PaymentSource = new SubscriptionPaymentSource
        {
            Card = new SubscriptionCardRequest
            {
                Name = "name6",
                Number = "number6",
                Expiry = "expiry4",
                SecurityCode = "security_code8",
                Type = CardType.Unknown,
            },
        },
    },
    AutoRenewal = false,
};
```



# Modify Subscription Request

The request to update the quantity of the product or service in a subscription. You can also use this method to switch the plan and update the `shipping_amount` and `shipping_address` values for the subscription. This type of update requires the buyer's consent.

## Structure

`ModifySubscriptionRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PlanId` | `string` | Optional | The unique PayPal-generated ID for the plan.<br><br>**Constraints**: *Minimum Length*: `26`, *Maximum Length*: `26`, *Pattern*: `^P-[A-Z0-9]*$` |
| `Quantity` | `string` | Optional | The quantity of the product or service in the subscription.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `32`, *Pattern*: `^([0-9]+\|([0-9]+)?[.][0-9]+)$` |
| `ShippingAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `ShippingAddress` | [`ShippingDetails`](../../doc/models/shipping-details.md) | Optional | The shipping details. |
| `ApplicationContext` | [`SubscriptionPatchApplicationContext`](../../doc/models/subscription-patch-application-context.md) | Optional | The application context, which customizes the payer experience during the subscription approval process with PayPal. |
| `Plan` | [`PlanOverride`](../../doc/models/plan-override.md) | Optional | An inline plan object to customise the subscription. You can override plan level default attributes by providing customised values for the subscription in this object. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

ModifySubscriptionRequest modifySubscriptionRequest = new ModifySubscriptionRequest
{
    PlanId = "plan_id0",
    Quantity = "quantity4",
    ShippingAmount = new Money
    {
        CurrencyCode = "currency_code0",
        MValue = "value6",
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
    ApplicationContext = new SubscriptionPatchApplicationContext
    {
        ReturnUrl = "return_url0",
        CancelUrl = "cancel_url2",
        BrandName = "brand_name8",
        Locale = "locale2",
        ShippingPreference = ExperienceContextShippingPreference.SetProvidedAddress,
        PaymentMethod = new PaymentMethod
        {
            PayeePreferred = PayeePaymentMethodPreference.Unrestricted,
        },
    },
};
```


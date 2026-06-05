
# Revise Subscription Input

Input structure for the method ReviseSubscription

## Structure

`ReviseSubscriptionInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | The ID of the subscription. |
| `ContentType` | `string` | Required, Constant | **Value**: `"application/json"` |
| `Body` | [`ModifySubscriptionRequest`](../../doc/models/modify-subscription-request.md) | Optional | - |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

ReviseSubscriptionInput reviseSubscriptionInput = new ReviseSubscriptionInput
{
    Id = "id0",
    Body = new ModifySubscriptionRequest
    {
        PlanId = "plan_id8",
        Quantity = "quantity2",
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
    },
};
```



# Modify Subscription Response

The response to a request to update the quantity of the product or service in a subscription. You can also use this method to switch the plan and update the `shipping_amount` and `shipping_address` values for the subscription. This type of update requires the buyer's consent.

## Structure

`ModifySubscriptionResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PlanId` | `string` | Optional | The unique PayPal-generated ID for the plan.<br><br>**Constraints**: *Minimum Length*: `26`, *Maximum Length*: `26`, *Pattern*: `^P-[A-Z0-9]*$` |
| `Quantity` | `string` | Optional | The quantity of the product or service in the subscription.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `32`, *Pattern*: `^([0-9]+\|([0-9]+)?[.][0-9]+)$` |
| `ShippingAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `ShippingAddress` | [`ShippingDetails`](../../doc/models/shipping-details.md) | Optional | The shipping details. |
| `Plan` | [`PlanOverride`](../../doc/models/plan-override.md) | Optional | An inline plan object to customise the subscription. You can override plan level default attributes by providing customised values for the subscription in this object. |
| `PlanOverridden` | `bool?` | Optional, Read-only | Indicates whether the subscription has overridden any plan attributes. |
| `Links` | [`List<LinkDescription>`](../../doc/models/link-description.md) | Optional, Read-only | An array of request-related [HATEOAS links](/docs/api/reference/api-responses/#hateoas-links). |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

ModifySubscriptionResponse modifySubscriptionResponse = new ModifySubscriptionResponse
{
    PlanId = "plan_id4",
    Quantity = "quantity8",
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
    Plan = new PlanOverride
    {
        BillingCycles = new List<BillingCycleOverride>
        {
            new BillingCycleOverride
            {
                Sequence = 8,
                PricingScheme = new SubscriptionPricingScheme
                {
                    FixedPrice = new Money
                    {
                        CurrencyCode = "currency_code4",
                        MValue = "value0",
                    },
                    PricingModel = SubscriptionPricingModel.Volume,
                    Tiers = new List<PricingTier>
                    {
                        new PricingTier
                        {
                            StartingQuantity = "starting_quantity8",
                            Amount = new Money
                            {
                                CurrencyCode = "currency_code6",
                                MValue = "value0",
                            },
                            EndingQuantity = "ending_quantity6",
                        },
                        new PricingTier
                        {
                            StartingQuantity = "starting_quantity8",
                            Amount = new Money
                            {
                                CurrencyCode = "currency_code6",
                                MValue = "value0",
                            },
                            EndingQuantity = "ending_quantity6",
                        },
                        new PricingTier
                        {
                            StartingQuantity = "starting_quantity8",
                            Amount = new Money
                            {
                                CurrencyCode = "currency_code6",
                                MValue = "value0",
                            },
                            EndingQuantity = "ending_quantity6",
                        },
                    },
                    CreateTime = "create_time4",
                },
                TotalCycles = 198,
            },
            new BillingCycleOverride
            {
                Sequence = 8,
                PricingScheme = new SubscriptionPricingScheme
                {
                    FixedPrice = new Money
                    {
                        CurrencyCode = "currency_code4",
                        MValue = "value0",
                    },
                    PricingModel = SubscriptionPricingModel.Volume,
                    Tiers = new List<PricingTier>
                    {
                        new PricingTier
                        {
                            StartingQuantity = "starting_quantity8",
                            Amount = new Money
                            {
                                CurrencyCode = "currency_code6",
                                MValue = "value0",
                            },
                            EndingQuantity = "ending_quantity6",
                        },
                        new PricingTier
                        {
                            StartingQuantity = "starting_quantity8",
                            Amount = new Money
                            {
                                CurrencyCode = "currency_code6",
                                MValue = "value0",
                            },
                            EndingQuantity = "ending_quantity6",
                        },
                        new PricingTier
                        {
                            StartingQuantity = "starting_quantity8",
                            Amount = new Money
                            {
                                CurrencyCode = "currency_code6",
                                MValue = "value0",
                            },
                            EndingQuantity = "ending_quantity6",
                        },
                    },
                    CreateTime = "create_time4",
                },
                TotalCycles = 198,
            },
        },
        PaymentPreferences = new PaymentPreferencesOverride
        {
            AutoBillOutstanding = false,
            SetupFee = new Money
            {
                CurrencyCode = "currency_code8",
                MValue = "value4",
            },
            SetupFeeFailureAction = SetupFeeFailureAction.Continue,
            PaymentFailureThreshold = 104,
        },
        Taxes = new TaxesOverride
        {
            Percentage = "percentage8",
            Inclusive = false,
        },
    },
};
```


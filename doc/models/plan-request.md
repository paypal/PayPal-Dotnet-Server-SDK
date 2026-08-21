
# Plan Request

The create plan request details.

## Structure

`PlanRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ProductId` | `string` | Required | The ID of the product created through Catalog Products API.<br><br>**Constraints**: *Minimum Length*: `22`, *Maximum Length*: `22`, *Pattern*: `^PROD-[A-Z0-9]*$` |
| `Name` | `string` | Required | The plan name.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `127`, *Pattern*: `^.*$` |
| `Status` | [`PlanRequestStatus?`](../../doc/models/plan-request-status.md) | Optional | The initial state of the plan. Allowed input values are CREATED and ACTIVE.<br><br>**Default**: `PlanRequestStatus.ACTIVE`<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `24`, *Pattern*: `^[A-Z_]+$` |
| `Description` | `string` | Optional | The detailed description of the plan.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `127`, *Pattern*: `^.*$` |
| `BillingCycles` | [`List<SubscriptionBillingCycle>`](../../doc/models/subscription-billing-cycle.md) | Required | An array of billing cycles for trial billing and regular billing. A plan can have at most two trial cycles and only one regular cycle.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `12` |
| `PaymentPreferences` | [`PaymentPreferences`](../../doc/models/payment-preferences.md) | Required | The payment preferences for a subscription. |
| `MerchantPreferences` | [`MerchantPreferences`](../../doc/models/merchant-preferences.md) | Optional | The merchant preferences for a subscription. |
| `Taxes` | [`Taxes`](../../doc/models/taxes.md) | Optional | The tax details. |
| `QuantitySupported` | `bool?` | Optional | Indicates whether you can subscribe to this plan by providing a quantity for the goods or service.<br><br>**Default**: `false` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

PlanRequest planRequest = new PlanRequest
{
    ProductId = "product_id4",
    Name = "name0",
    BillingCycles = new List<SubscriptionBillingCycle>
    {
        new SubscriptionBillingCycle
        {
            Frequency = new Frequency
            {
                IntervalUnit = IntervalUnit.Day,
                IntervalCount = 1,
            },
            TenureType = TenureType.Regular,
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
            TotalCycles = 1,
        },
    },
    PaymentPreferences = new PaymentPreferences
    {
        AutoBillOutstanding = true,
        SetupFee = new Money
        {
            CurrencyCode = "currency_code8",
            MValue = "value4",
        },
        SetupFeeFailureAction = SetupFeeFailureAction.Cancel,
        PaymentFailureThreshold = 0,
    },
    Status = PlanRequestStatus.Active,
    Description = "description0",
    MerchantPreferences = new MerchantPreferences
    {
        ReturnUrl = "return_url4",
        CancelUrl = "cancel_url6",
    },
    Taxes = new Taxes
    {
        Percentage = "percentage8",
        Inclusive = false,
    },
    QuantitySupported = false,
};
```


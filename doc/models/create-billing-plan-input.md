
# Create Billing Plan Input

Input structure for the method CreateBillingPlan

## Structure

`CreateBillingPlanInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ContentType` | `string` | Required, Constant | **Value**: `"application/json"` |
| `Prefer` | `string` | Optional | The preferred server response upon successful completion of the request. Value is: return=minimal. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the id, status and HATEOAS links. return=representation. The server returns a complete resource representation, including the current state of the resource.<br><br>**Default**: `"return=minimal"` |
| `PaypalRequestId` | `string` | Optional | The server stores keys for 72 hours. |
| `Body` | [`PlanRequest`](../../doc/models/plan-request.md) | Optional | - |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

CreateBillingPlanInput createBillingPlanInput = new CreateBillingPlanInput
{
    Prefer = "return=minimal",
    PaypalRequestId = "PayPal-Request-Id6",
    Body = new PlanRequest
    {
        ProductId = "product_id2",
        Name = "name6",
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
                    Version = 10,
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
        Description = "description4",
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
    },
};
```


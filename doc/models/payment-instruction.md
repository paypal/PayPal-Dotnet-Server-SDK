
# Payment Instruction

Any additional payment instructions to be consider during payment processing. This processing instruction is applicable for Capturing an order or Authorizing an Order.

## Structure

`PaymentInstruction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PlatformFees` | [`List<PlatformFee>`](../../doc/models/platform-fee.md) | Optional | An array of various fees, commissions, tips, or donations. This field is only applicable to merchants that been enabled for PayPal Complete Payments Platform for Marketplaces and Platforms capability.<br><br>**Constraints**: *Minimum Items*: `0`, *Maximum Items*: `1` |
| `DisbursementMode` | [`DisbursementMode?`](../../doc/models/disbursement-mode.md) | Optional | The funds that are held on behalf of the merchant.<br><br>**Default**: `DisbursementMode.INSTANT`<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `16`, *Pattern*: `^[A-Z_]+$` |
| `PayeePricingTierId` | `string` | Optional | This field is only enabled for selected merchants/partners to use and provides the ability to trigger a specific pricing rate/plan for a payment transaction. The list of eligible 'payee_pricing_tier_id' would be provided to you by your Account Manager. Specifying values other than the one provided to you by your account manager would result in an error.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `20`, *Pattern*: `^.*$` |
| `PayeeReceivableFxRateId` | `string` | Optional | FX identifier generated returned by PayPal to be used for payment processing in order to honor FX rate (for eligible integrations) to be used when amount is settled/received into the payee account.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `4000`, *Pattern*: `^.*$` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

PaymentInstruction paymentInstruction = new PaymentInstruction
{
    PlatformFees = new List<PlatformFee>
    {
        new PlatformFee
        {
            Amount = new Money
            {
                CurrencyCode = "currency_code6",
                MValue = "value0",
            },
            Payee = new PayeeBase
            {
                EmailAddress = "email_address4",
                MerchantId = "merchant_id6",
            },
        },
        new PlatformFee
        {
            Amount = new Money
            {
                CurrencyCode = "currency_code6",
                MValue = "value0",
            },
            Payee = new PayeeBase
            {
                EmailAddress = "email_address4",
                MerchantId = "merchant_id6",
            },
        },
        new PlatformFee
        {
            Amount = new Money
            {
                CurrencyCode = "currency_code6",
                MValue = "value0",
            },
            Payee = new PayeeBase
            {
                EmailAddress = "email_address4",
                MerchantId = "merchant_id6",
            },
        },
    },
    DisbursementMode = DisbursementMode.Instant,
    PayeePricingTierId = "payee_pricing_tier_id0",
    PayeeReceivableFxRateId = "payee_receivable_fx_rate_id2",
};
```


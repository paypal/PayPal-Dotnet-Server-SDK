
# Seller Receivable Breakdown

The detailed breakdown of the capture activity. This is not available for transactions that are in pending state.

## Structure

`SellerReceivableBreakdown`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `GrossAmount` | [`Money`](../../doc/models/money.md) | Required | The currency and amount for a financial transaction, such as a balance or payment due. |
| `PaypalFee` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `PaypalFeeInReceivableCurrency` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `NetAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `ReceivableAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `ExchangeRate` | [`ExchangeRate`](../../doc/models/exchange-rate.md) | Optional, Read-only | The exchange rate that determines the amount to convert from one currency to another currency. |
| `PlatformFees` | [`List<PlatformFee>`](../../doc/models/platform-fee.md) | Optional | An array of platform or partner fees, commissions, or brokerage fees that associated with the captured payment.<br><br>**Constraints**: *Minimum Items*: `0`, *Maximum Items*: `1` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

SellerReceivableBreakdown sellerReceivableBreakdown = new SellerReceivableBreakdown
{
    GrossAmount = new Money
    {
        CurrencyCode = "currency_code4",
        MValue = "value0",
    },
    PaypalFee = new Money
    {
        CurrencyCode = "currency_code4",
        MValue = "value2",
    },
    PaypalFeeInReceivableCurrency = new Money
    {
        CurrencyCode = "currency_code2",
        MValue = "value8",
    },
    NetAmount = new Money
    {
        CurrencyCode = "currency_code6",
        MValue = "value2",
    },
    ReceivableAmount = new Money
    {
        CurrencyCode = "currency_code2",
        MValue = "value8",
    },
};
```


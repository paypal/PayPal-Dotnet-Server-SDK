
# Seller Payable Breakdown

The breakdown of the refund.

## Structure

`SellerPayableBreakdown`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `GrossAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `PaypalFee` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `PaypalFeeInReceivableCurrency` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `NetAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `NetAmountInReceivableCurrency` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `PlatformFees` | [`List<PlatformFee>`](../../doc/models/platform-fee.md) | Optional | An array of platform or partner fees, commissions, or brokerage fees for the refund.<br><br>**Constraints**: *Minimum Items*: `0`, *Maximum Items*: `1` |
| `NetAmountBreakdown` | [`List<NetAmountBreakdownItem>`](../../doc/models/net-amount-breakdown-item.md) | Optional | An array of breakdown values for the net amount. Returned when the currency of the refund is different from the currency of the PayPal account where the payee holds their funds. |
| `TotalRefundedAmount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |

## Example (as JSON)

```json
{
  "gross_amount": {
    "currency_code": "currency_code4",
    "value": "value0"
  },
  "paypal_fee": {
    "currency_code": "currency_code4",
    "value": "value2"
  },
  "paypal_fee_in_receivable_currency": {
    "currency_code": "currency_code2",
    "value": "value8"
  },
  "net_amount": {
    "currency_code": "currency_code6",
    "value": "value2"
  },
  "net_amount_in_receivable_currency": {
    "currency_code": "currency_code8",
    "value": "value4"
  }
}
```



# Amount Breakdown

The breakdown of the amount. Breakdown provides details such as total item amount, total tax amount, shipping, handling, insurance, and discounts, if any.

## Structure

`AmountBreakdown`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ItemTotal` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `Shipping` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `Handling` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `TaxTotal` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `Insurance` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `ShippingDiscount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `Discount` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |

## Example (as JSON)

```json
{
  "item_total": {
    "currency_code": "currency_code0",
    "value": "value6"
  },
  "shipping": {
    "currency_code": "currency_code0",
    "value": "value6"
  },
  "handling": {
    "currency_code": "currency_code2",
    "value": "value8"
  },
  "tax_total": {
    "currency_code": "currency_code4",
    "value": "value0"
  },
  "insurance": {
    "currency_code": "currency_code2",
    "value": "value8"
  }
}
```


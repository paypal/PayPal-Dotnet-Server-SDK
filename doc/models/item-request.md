
# Item Request

The details for the items to be purchased.

## Structure

`ItemRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The item name or title.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `127` |
| `UnitAmount` | [`Money`](../../doc/models/money.md) | Required | The currency and amount for a financial transaction, such as a balance or payment due. |
| `Tax` | [`Money`](../../doc/models/money.md) | Optional | The currency and amount for a financial transaction, such as a balance or payment due. |
| `Quantity` | `string` | Required | The item quantity. Must be a whole number.<br><br>**Constraints**: *Maximum Length*: `10`, *Pattern*: `^[1-9][0-9]{0,9}$` |
| `Description` | `string` | Optional | This field supports up to 4000 characters, but any content beyond 2048 characters (including spaces) will be truncated. The 2048 character limit is reflected in the response representation of this field.<br><br>**Constraints**: *Maximum Length*: `4000` |
| `Sku` | `string` | Optional | The stock keeping unit (SKU) for the item.<br><br>**Constraints**: *Maximum Length*: `127` |
| `Url` | `string` | Optional | The URL to the item being purchased. Visible to buyer and used in buyer experiences.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2048` |
| `Category` | [`ItemCategory?`](../../doc/models/item-category.md) | Optional | The item category type.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `20` |
| `ImageUrl` | `string` | Optional | The URL of the item's image. File type and size restrictions apply. An image that violates these restrictions will not be honored.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `2048`, *Pattern*: `^(https:)([/\|.\|\w\|\s\|-])*\.(?:jpg\|gif\|png\|jpeg\|JPG\|GIF\|PNG\|JPEG)` |
| `Upc` | [`UniversalProductCode`](../../doc/models/universal-product-code.md) | Optional | The Universal Product Code of the item. |
| `BillingPlan` | [`OrderBillingPlan`](../../doc/models/order-billing-plan.md) | Optional | Metadata for merchant-managed recurring billing plans. Valid only during the saved payment method token or billing agreement creation. |

## Example (as JSON)

```json
{
  "name": "name0",
  "unit_amount": {
    "currency_code": "currency_code2",
    "value": "value8"
  },
  "tax": {
    "currency_code": "currency_code0",
    "value": "value6"
  },
  "quantity": "quantity6",
  "description": "description0",
  "sku": "sku6",
  "url": "url4",
  "category": "DIGITAL_GOODS"
}
```


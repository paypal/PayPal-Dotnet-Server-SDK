
# Cart Information

The cart information.

## Structure

`CartInformation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ItemDetails` | [`List<ItemDetails>`](../../doc/models/item-details.md) | Optional | An array of item details.<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `32767` |
| `TaxInclusive` | `bool?` | Optional | Indicates whether the item amount or the shipping amount already includes tax.<br><br>**Default**: `false` |
| `PaypalInvoiceId` | `string` | Optional | The ID of the invoice. Appears for only PayPal-generated invoices.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `127`, *Pattern*: `^[a-zA-Z0-9_'\-., ":;\!?]*$` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

CartInformation cartInformation = new CartInformation
{
    ItemDetails = new List<ItemDetails>
    {
        new ItemDetails
        {
            ItemCode = "item_code0",
            ItemName = "item_name8",
            ItemDescription = "item_description4",
            ItemOptions = "item_options2",
            ItemQuantity = "item_quantity2",
        },
    },
    TaxInclusive = false,
    PaypalInvoiceId = "paypal_invoice_id4",
};
```


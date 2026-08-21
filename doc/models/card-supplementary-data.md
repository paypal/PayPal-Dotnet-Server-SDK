
# Card Supplementary Data

Merchants and partners can add Level 2 and 3 data to payments to reduce risk and payment processing costs. For more information about processing payments, see checkout or multiparty checkout.

## Structure

`CardSupplementaryData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Level2` | [`Level2CardProcessingData`](../../doc/models/level-2-card-processing-data.md) | Optional | The level 2 card processing data collections. If your merchant account has been configured for Level 2 processing this field will be passed to the processor on your behalf. Please contact your PayPal Technical Account Manager to define level 2 data for your business. |
| `Level3` | [`Level3CardProcessingData`](../../doc/models/level-3-card-processing-data.md) | Optional | The level 3 card processing data collections, If your merchant account has been configured for Level 3 processing this field will be passed to the processor on your behalf. Please contact your PayPal Technical Account Manager to define level 3 data for your business. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

CardSupplementaryData cardSupplementaryData = new CardSupplementaryData
{
    Level2 = new Level2CardProcessingData
    {
        InvoiceId = "invoice_id4",
        TaxTotal = new Money
        {
            CurrencyCode = "currency_code4",
            MValue = "value0",
        },
    },
    Level3 = new Level3CardProcessingData
    {
        ShippingAmount = new Money
        {
            CurrencyCode = "currency_code0",
            MValue = "value6",
        },
        DutyAmount = new Money
        {
            CurrencyCode = "currency_code6",
            MValue = "value2",
        },
        DiscountAmount = new Money
        {
            CurrencyCode = "currency_code2",
            MValue = "value8",
        },
        ShippingAddress = new Address
        {
            CountryCode = "country_code0",
            AddressLine1 = "address_line_10",
            AddressLine2 = "address_line_20",
            AdminArea2 = "admin_area_24",
            AdminArea1 = "admin_area_16",
            PostalCode = "postal_code2",
        },
        ShipsFromPostalCode = "ships_from_postal_code4",
    },
};
```


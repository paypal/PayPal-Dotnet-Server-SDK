
# Supplementary Data

Supplementary data about a payment. This object passes information that can be used to improve risk assessments and processing costs, for example, by providing Level 2 and Level 3 payment data.

## Structure

`SupplementaryData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Card` | [`CardSupplementaryData`](../../doc/models/card-supplementary-data.md) | Optional | Merchants and partners can add Level 2 and 3 data to payments to reduce risk and payment processing costs. For more information about processing payments, see checkout or multiparty checkout. |
| `Risk` | [`RiskSupplementaryData`](../../doc/models/risk-supplementary-data.md) | Optional | Additional information necessary to evaluate the risk profile of a transaction. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

SupplementaryData supplementaryData = new SupplementaryData
{
    Card = new CardSupplementaryData
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
    },
    Risk = new RiskSupplementaryData
    {
        Customer = new ParticipantMetadata
        {
            IpAddress = "ip_address0",
        },
    },
};
```


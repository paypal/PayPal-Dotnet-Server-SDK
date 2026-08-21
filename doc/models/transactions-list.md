
# Transactions List

The list transactions for a subscription request details.

## Structure

`TransactionsList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Transactions` | [`List<SubscriptionTransactionDetails>`](../../doc/models/subscription-transaction-details.md) | Optional | An array of transactions.<br><br>**Constraints**: *Minimum Items*: `0`, *Maximum Items*: `32767` |
| `TotalItems` | `int?` | Optional | The total number of items.<br><br>**Constraints**: `>= 0`, `<= 500000000` |
| `TotalPages` | `int?` | Optional | The total number of pages.<br><br>**Constraints**: `>= 0`, `<= 100000000` |
| `Links` | [`List<LinkDescription>`](../../doc/models/link-description.md) | Optional, Read-only | An array of request-related [HATEOAS links](/docs/api/reference/api-responses/#hateoas-links).<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;
using System.Collections.Generic;

TransactionsList transactionsList = new TransactionsList
{
    Transactions = new List<SubscriptionTransactionDetails>
    {
        new SubscriptionTransactionDetails
        {
            Id = null,
            AmountWithBreakdown = new SubscriptionAmountWithBreakdown
            {
                GrossAmount = new Money
                {
                    CurrencyCode = "currency_code4",
                    MValue = "value0",
                },
                TotalItemAmount = new Money
                {
                    CurrencyCode = "currency_code8",
                    MValue = "value4",
                },
                FeeAmount = new Money
                {
                    CurrencyCode = "currency_code2",
                    MValue = "value4",
                },
                ShippingAmount = new Money
                {
                    CurrencyCode = "currency_code0",
                    MValue = "value6",
                },
                TaxAmount = new Money
                {
                    CurrencyCode = "currency_code2",
                    MValue = "value8",
                },
                NetAmount = new Money
                {
                    CurrencyCode = "currency_code6",
                    MValue = "value2",
                },
            },
            Time = "time8",
            PayerName = new SubscriptionPayerName
            {
                Prefix = "prefix8",
                GivenName = "given_name2",
                Surname = "surname8",
                MiddleName = "middle_name0",
                Suffix = "suffix0",
            },
            PayerEmail = "payer_email6",
        },
        new SubscriptionTransactionDetails
        {
            Id = null,
            AmountWithBreakdown = new SubscriptionAmountWithBreakdown
            {
                GrossAmount = new Money
                {
                    CurrencyCode = "currency_code4",
                    MValue = "value0",
                },
                TotalItemAmount = new Money
                {
                    CurrencyCode = "currency_code8",
                    MValue = "value4",
                },
                FeeAmount = new Money
                {
                    CurrencyCode = "currency_code2",
                    MValue = "value4",
                },
                ShippingAmount = new Money
                {
                    CurrencyCode = "currency_code0",
                    MValue = "value6",
                },
                TaxAmount = new Money
                {
                    CurrencyCode = "currency_code2",
                    MValue = "value8",
                },
                NetAmount = new Money
                {
                    CurrencyCode = "currency_code6",
                    MValue = "value2",
                },
            },
            Time = "time8",
            PayerName = new SubscriptionPayerName
            {
                Prefix = "prefix8",
                GivenName = "given_name2",
                Surname = "surname8",
                MiddleName = "middle_name0",
                Suffix = "suffix0",
            },
            PayerEmail = "payer_email6",
        },
    },
    TotalItems = 36,
    TotalPages = 72,
};
```


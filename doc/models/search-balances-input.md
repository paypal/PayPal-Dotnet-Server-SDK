
# Search Balances Input

Input structure for the method SearchBalances

## Structure

`SearchBalancesInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AsOfTime` | `string` | Optional | List balances in the response at the date time provided, will return the last refreshed balance in the system when not provided.<br><br>**Constraints**: *Minimum Length*: `20`, *Maximum Length*: `64`, *Pattern*: `^[0-9]{4}-(0[1-9]\|1[0-2])-(0[1-9]\|[1-2][0-9]\|3[0-1])[T,t]([0-1][0-9]\|2[0-3]):[0-5][0-9]:([0-5][0-9]\|60)([.][0-9]+)?([Zz]\|[+-][0-9]{2}:[0-9]{2})$` |
| `CurrencyCode` | `string` | Optional | Filters the transactions in the response by a [three-character ISO-4217 currency code](https://developer.paypal.com/api/rest/reference/currency-codes/) for the PayPal transaction currency.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `3` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

SearchBalancesInput searchBalancesInput = new SearchBalancesInput
{
    AsOfTime = "as_of_time0",
    CurrencyCode = "currency_code4",
};
```


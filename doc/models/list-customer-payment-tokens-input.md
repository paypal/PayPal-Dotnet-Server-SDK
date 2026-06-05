
# List Customer Payment Tokens Input

Input structure for the method ListCustomerPaymentTokens

## Structure

`ListCustomerPaymentTokensInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CustomerId` | `string` | Required | A unique identifier representing a specific customer in merchant's/partner's system or records.<br><br>**Constraints**: *Minimum Length*: `7`, *Maximum Length*: `36`, *Pattern*: `^[0-9a-zA-Z_-]+$` |
| `PageSize` | `int?` | Optional | A non-negative, non-zero integer indicating the maximum number of results to return at one time.<br><br>**Default**: `5`<br><br>**Constraints**: `>= 1`, `<= 5` |
| `Page` | `int?` | Optional | A non-negative, non-zero integer representing the page of the results.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1`, `<= 10` |
| `TotalRequired` | `bool?` | Optional | A boolean indicating total number of items (total_items) and pages (total_pages) are expected to be returned in the response.<br><br>**Default**: `false` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

ListCustomerPaymentTokensInput listCustomerPaymentTokensInput = new ListCustomerPaymentTokensInput
{
    CustomerId = "customer_id8",
    PageSize = 5,
    Page = 1,
    TotalRequired = false,
};
```


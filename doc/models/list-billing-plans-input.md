
# List Billing Plans Input

Input structure for the method ListBillingPlans

## Structure

`ListBillingPlansInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Prefer` | `string` | Optional | The preferred server response upon successful completion of the request. Value is: return=minimal. The server returns a minimal response to optimize communication between the API caller and the server. A minimal response includes the id, name, description and HATEOAS links. return=representation. The server returns a complete resource representation, including the current state of the resource.<br><br>**Default**: `"return=minimal"` |
| `ProductId` | `string` | Optional | Filters the response by a Product ID.<br><br>**Constraints**: *Minimum Length*: `6`, *Maximum Length*: `50` |
| `PageSize` | `int?` | Optional | The number of items to return in the response.<br><br>**Default**: `10`<br><br>**Constraints**: `>= 1`, `<= 20` |
| `Page` | `int?` | Optional | A non-zero integer which is the start index of the entire list of items to return in the response. The combination of `page=1` and `page_size=20` returns the first 20 items. The combination of `page=2` and `page_size=20` returns the next 20 items.<br><br>**Default**: `1`<br><br>**Constraints**: `>= 1`, `<= 100000` |
| `TotalRequired` | `bool?` | Optional | Indicates whether to show the total count in the response.<br><br>**Default**: `false` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

ListBillingPlansInput listBillingPlansInput = new ListBillingPlansInput
{
    Prefer = "return=minimal",
    ProductId = "product_id4",
    PageSize = 10,
    Page = 1,
    TotalRequired = false,
};
```


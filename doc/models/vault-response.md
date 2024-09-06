
# Vault Response

The details about a saved payment source.

## Structure

`VaultResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Optional | The PayPal-generated ID for the saved payment source.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255` |
| `Status` | [`VaultStatus?`](../../doc/models/vault-status.md) | Optional | The vault status.<br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[0-9A-Z_]+$` |
| `Customer` | [`VaultCustomer`](../../doc/models/vault-customer.md) | Optional | The details about a customer in PayPal's system of record. |
| `Links` | [`List<LinkDescription>`](../../doc/models/link-description.md) | Optional | An array of request-related HATEOAS links.<br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `10` |

## Example (as JSON)

```json
{
  "id": "id2",
  "status": "CREATED",
  "customer": {
    "id": "id0"
  },
  "links": [
    {
      "href": "href6",
      "rel": "rel0",
      "method": "HEAD"
    }
  ]
}
```


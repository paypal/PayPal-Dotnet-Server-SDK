
# Paypal Wallet Attributes

Additional attributes associated with the use of this PayPal Wallet.

## Structure

`PaypalWalletAttributes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Customer` | [`PaypalWalletCustomerRequest`](../../doc/models/paypal-wallet-customer-request.md) | Optional | - |
| `Vault` | [`PaypalWalletVaultInstruction`](../../doc/models/paypal-wallet-vault-instruction.md) | Optional | - |

## Example (as JSON)

```json
{
  "customer": {
    "id": "id0",
    "email_address": "email_address2",
    "phone": {
      "phone_type": "OTHER",
      "phone_number": {
        "national_number": "national_number6"
      }
    },
    "name": {
      "given_name": "given_name2",
      "surname": "surname8"
    },
    "merchant_customer_id": "merchant_customer_id2"
  },
  "vault": {
    "store_in_vault": "ON_SUCCESS",
    "description": "description6",
    "usage_pattern": "THRESHOLD_PREPAID",
    "usage_type": "MERCHANT",
    "customer_type": "CONSUMER",
    "permit_multiple_payment_tokens": false
  }
}
```


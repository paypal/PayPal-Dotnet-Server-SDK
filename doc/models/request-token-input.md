
# Request Token Input

Input structure for the method RequestToken

## Structure

`RequestTokenInput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `GrantType` | `string` | Required, Constant | Grant Type<br><br>**Value**: `"client_credentials"` |
| `Authorization` | `string` | Required | Authorization header in Basic auth format |
| `Scope` | `string` | Optional | Requested scopes as a space-delimited list. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

RequestTokenInput requestTokenInput = new RequestTokenInput
{
    GrantType = "client_credentials",
    Authorization = "Authorization8",
    Scope = "scope2",
};
```


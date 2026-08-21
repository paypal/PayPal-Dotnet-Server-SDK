
# O Auth Token

OAuth 2 Authorization endpoint response

## Structure

`OAuthToken`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccessToken` | `string` | Required | Access token |
| `TokenType` | `string` | Required | Type of access token |
| `ExpiresIn` | `long?` | Optional | Time in seconds before the access token expires |
| `Scope` | `string` | Optional | List of scopes granted<br>This is a space-delimited list of strings. |
| `Expiry` | `long?` | Optional | Time of token expiry as unix timestamp (UTC) |
| `RefreshToken` | `string` | Optional | Refresh token<br>Used to get a new access token when it expires. |
| `IdToken` | `string` | Optional | An ID token response type is of JSON Web Token (JWT) that contains claims about the identity of the authenticated user. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

OAuthToken oAuthToken = new OAuthToken
{
    AccessToken = "access_token2",
    TokenType = "token_type2",
    ExpiresIn = 84L,
    Scope = "scope8",
    Expiry = 78L,
    RefreshToken = "refresh_token4",
    IdToken = "id_token8",
};
```


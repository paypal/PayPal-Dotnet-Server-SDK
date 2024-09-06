
# OAuth 2 Client Credentials Grant



Documentation for accessing and setting credentials for Oauth2.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| OAuthClientId | `string` | OAuth 2 Client ID | `OAuthClientId` | `OAuthClientId` |
| OAuthClientSecret | `string` | OAuth 2 Client Secret | `OAuthClientSecret` | `OAuthClientSecret` |
| OAuthToken | `Models.OAuthToken` | Object for storing information about the OAuth token | `OAuthToken` | `OAuthToken` |
| OAuthClockSkew | `TimeSpan?` | Clock skew time in seconds applied while checking the OAuth Token expiry. | `OAuthClockSkew` | `OAuthClockSkew` |
| OAuthTokenProvider | `Func<ClientCredentialsAuthManager, OAuthToken, Task<OAuthToken>>` | Registers a callback for oAuth Token Provider used for automatic token fetching/refreshing. | `OAuthTokenProvider` | `OAuthTokenProvider` |
| OAuthOnTokenUpdate | `Action<OAuthToken>` | Registers a callback for token update event. | `OAuthOnTokenUpdate` | `OAuthOnTokenUpdate` |



**Note:** Auth credentials can be set using `ClientCredentialsAuth` in the client builder and accessed through `ClientCredentialsAuth` method in the client instance.

## Usage Example

### Client Initialization

You must initialize the client with *OAuth 2.0 Client Credentials Grant* credentials as shown in the following code snippet. This will fetch the OAuth token automatically when any of the endpoints, requiring *OAuth 2.0 Client Credentials Grant* autentication, are called.

```csharp
PayPalRESTAPIs.Standard.PayPalRESTAPIsClient client = new PayPalRESTAPIs.Standard.PayPalRESTAPIsClient.Builder()
    .ClientCredentialsAuth(
        new ClientCredentialsAuthModel.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .Build())
    .Build();
```



Your application can also manually provide an OAuthToken using the setter `oAuthToken` in `ClientCredentialsAuthModel` object. This function takes in an instance of OAuthToken containing information for authorizing client requests and refreshing the token itself.

### Adding OAuth Token Update Callback

Whenever the OAuth Token gets updated, the provided callback implementation will be executed. For instance, you may use it to store your access token whenever it gets updated.

```csharp
PayPalRESTAPIs.Standard.PayPalRESTAPIsClient client = new PayPalRESTAPIs.Standard.PayPalRESTAPIsClient.Builder()
    .ClientCredentialsAuth(
        new ClientCredentialsAuthModel.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .oAuthOnTokenUpdate(token -> 
        {
            // It will be triggered whenever the token gets updated
            SaveTokenToDatabase(token);
        })
        .Build())
    .Build();
```

### Adding Custom OAuth Token Provider

To authorize a client using a stored access token, set up the `oAuthTokenProvider` in `ClientCredentialsAuthModel` builder along with the other auth parameters before creating the client:

```csharp
PayPalRESTAPIs.Standard.PayPalRESTAPIsClient client = new PayPalRESTAPIs.Standard.PayPalRESTAPIsClient.Builder()
    .ClientCredentialsAuth(
        new ClientCredentialsAuthModel.Builder(
            "OAuthClientId",
            "OAuthClientSecret"
        )
        .oAuthTokenProvider(async (token, credentialsManager) =>
        {
            // Add the callback handler to provide a new OAuth token
            // It will be triggered whenever the lastOAuthToken is undefined or expired
            return LoadTokenFromDatabase() ?? await FetchTokenAsync()
        })
        .Build())
    .Build();
```



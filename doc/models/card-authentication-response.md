
# Card Authentication Response

Results of Authentication such as 3D Secure.

## Structure

`CardAuthenticationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ThreeDSecure` | [`ThreeDSecureCardAuthenticationResponse`](../../doc/models/three-d-secure-card-authentication-response.md) | Optional | Results of 3D Secure Authentication. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

CardAuthenticationResponse cardAuthenticationResponse = new CardAuthenticationResponse
{
    ThreeDSecure = new ThreeDSecureCardAuthenticationResponse
    {
        AuthenticationStatus = PaResStatus.ChallengeRequired,
        EnrollmentStatus = EnrollmentStatus.Enrolled,
        AuthenticationId = "authentication_id6",
    },
};
```


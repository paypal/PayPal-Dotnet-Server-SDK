
# Authentication Response

Results of Authentication such as 3D Secure.

## Structure

`AuthenticationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LiabilityShift` | [`LiabilityShiftIndicator?`](../../doc/models/liability-shift-indicator.md) | Optional | Liability shift indicator. The outcome of the issuer's authentication.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[0-9A-Z_]+$` |
| `ThreeDSecure` | [`ThreeDSecureAuthenticationResponse`](../../doc/models/three-d-secure-authentication-response.md) | Optional | Results of 3D Secure Authentication. |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

AuthenticationResponse authenticationResponse = new AuthenticationResponse
{
    LiabilityShift = LiabilityShiftIndicator.No,
    ThreeDSecure = new ThreeDSecureAuthenticationResponse
    {
        AuthenticationStatus = PaResStatus.ChallengeRequired,
        EnrollmentStatus = EnrollmentStatus.Enrolled,
    },
};
```


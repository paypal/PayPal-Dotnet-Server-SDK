
# Three D Secure Authentication Response

Results of 3D Secure Authentication.

## Structure

`ThreeDSecureAuthenticationResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AuthenticationStatus` | [`PaResStatus?`](../../doc/models/pa-res-status.md) | Optional | Transactions status result identifier. The outcome of the issuer's authentication.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[0-9A-Z_]+$` |
| `EnrollmentStatus` | [`EnrollmentStatus?`](../../doc/models/enrollment-status.md) | Optional | Status of Authentication eligibility.<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `255`, *Pattern*: `^[0-9A-Z_]+$` |

## Example

```csharp
using PaypalServerSdk.Standard.Models;

ThreeDSecureAuthenticationResponse threeDSecureAuthenticationResponse = new ThreeDSecureAuthenticationResponse
{
    AuthenticationStatus = PaResStatus.SuccessfulAuthentication,
    EnrollmentStatus = EnrollmentStatus.Enrolled,
};
```


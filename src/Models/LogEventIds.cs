using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

public enum LogEventIds
{
    AuthorizationSuccess,

    AuthorizationFailure,

    ResourceOwnerAuthenticationSuccess,

    ResourceOwnerAuthenticationFailure,

    ClientAuthenticationSuccess,

    ClientAuthenticationFailure,

    ApiAuthenticationSuccess,

    ApiAuthenticationFailure,

    CertificateAuthenticationSuccess,

    CertificateAuthenticationFailure,

    UserLogoutSuccess,

    UserSignInFailure,

    UserSignInSuccess,

    UserAccountBlocked,

    UserAccountIpBlocked,

    UserAccountUnblocked,

    UserAccountIpUnblocked,

    UserAccountAllIpsUnblocked,

    UserAccountAllUnblocked,

    UserPasswordResetSuccess,

    UserSessionCreated,

    UserSessionRenewed,

    UserSessionRemoved,

    UserSessionExtended,

    UserSessionMetadataUpdated,

    UserSignUpSuccess,

    UserNewAuthenticatorAdded,

    UserDeleted,

    ParSuccess,

    ParFailure,

    TokenIssuedSuccess,

    TokenIssuedFailure,

    TokenRevokedSuccess,

    TokenIntrospectionSuccess,

    TokenIntrospectionFailure,

    InvalidClientConfiguration,

    ConsentGranted,

    ConsentDenied,

    GrantsRevoked,

    DeviceAuthorizationSuccess,

    DeviceAuthorizationFailure,

    PasswordlessSignInNotificationSentEvent,

    SignUpVerificationNotificationSentEvent,

    UserPasswordResetNotificationSent,

    UserBlockedNotificationSent,

    UserWelcomeNotificationSent,

    UserPasswordUpdatedNotificationSent,

    UserCreatedAuditEvent,

    UserUpdatedAuditEvent,

    UserDeletedAuditEvent,

    UserEnabledAuditEvent,

    UserDisabledAuditEvent,

    GroupCreatedAuditEvent,

    GroupUpdatedAuditEvent,

    GroupDeletedAuditEvent,

    GroupAssignedUserAuditEvent,

    GroupUnassignedUserAuditEvent,

    GroupAssignedClientAuditEvent,

    GroupUnassignedClientAuditEvent
}



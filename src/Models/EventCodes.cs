using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

public enum EventCodes
{
  /// <summary>
  /// Authentication related events
  /// </summary>
  AuthorizationFailure,

    AuthorizationSuccess,

    ParFailure,

    ParSuccess,

    ClientAuthenticationFailure,

    ClientAuthenticationSuccess,

    ApiAuthenticationFailure,

    ApiAuthenticationSuccess,

    ResourceOwnerAuthenticationFailure,

    ResourceOwnerAuthenticationSuccess,

    DeviceAuthorizationFailure,

    DeviceAuthorizationSuccess,

    CertificateAuthenticationFailure,

    CertificateAuthenticationSuccess,

    IdentifierSignInFailure,

    ExternalSignInFailure,

    UserSignInFailure,

    UserSignIn,

    UserSignUp,

    UserLogout,

  /// <summary>
  /// Token related events
  /// </summary>
  TokenIssuedFailure,

    TokenIssuedSuccess,

    TokenIntrospectionFailure,

    TokenIntrospectionSuccess,

    TokenRevoked,

    ReferenceTokensUserDeleteAll,

    RefreshTokensUserDeleteAll,

  /// <summary>
  /// Consent related events
  /// </summary>
  ConsentGranted,

    ConsentDenied,

    ConsentsUserDeletedAll,

  /// <summary>
  /// Block related events
  /// </summary>
  IdentifierIpBlocked,

    UserAccountIpBlocked,

    UserAccountBlocked,

    UserAccountUnblocked,

    UserAccountIpUnblocked,

    UserAccountAllUnblocked,

    UserAccountAllIpsUnblocked,

  /// <summary>
  /// User related events
  /// </summary>
  UserCreated,

    UserDeleted,

    UserAddedToGroup,

    UserRemovedFromGroup,

    UserPasswordResetSuccess,

    UserSessionRevoked,

    UserSessionsRevokedAll,

    UserSessionsDeletedAll,

  /// <summary>
  /// Notification related events
  /// </summary>
  SignInEmailSentEvent,

    VerificationEmailSentEvent,

    WelcomeEmailSent,

    PasswordUpdatedEmailSent,

    PasswordResetEmailSent,

    UserBlockedEmailSent,

    SignInSmsSentEvent,

    VerificationSmsSentEvent,

    PasswordResetSmsSent,

    EmailSendFailure,

    SmsSendFailure,

  /// <summary>
  /// Resources related events
  /// </summary>
  ApiResourceCreated,

    ApiResourceUpdated,

    ApiResourceDeleted,

    ApiResourceSecretCreated,

    ApiResourceSecretDeleted,

  /// <summary>
  /// Trust Store related events
  /// </summary>
  TrustStoreCertificatesUpdated,

    TrustStoreRevocationsUpdated,

    TrustStoreBannedThumbprintsUpdated,

  /// <summary>
  /// Clients related events
  /// </summary>
  ClientCreated,

    ClientUpdated,

    ClientDeleted,

    ClientAddedToGroup,

    ClientRemovedFromGroup,

    ClientSecretCreated,

    ClientSecretDeleted,

  /// <summary>
  /// Groups related events
  /// </summary>
  GroupCreated,

    GroupUpdated,

    GroupDeleted,

  /// <summary>
  /// Authorization Codes related events
  /// </summary>
  AuthorizationCodesUserDeleteAll
}



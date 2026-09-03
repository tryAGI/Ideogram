
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Stable machine-readable integration error code. `INTEGRATION_ACCESS_DENIED` (403): the caller or organization is not allowed to use integrations. `MINI_APP_TOKEN_MISSING_SCOPES` (403): emitted by the shared mini-app token middleware. `INTEGRATION_REQUEST_INVALID` (400): malformed search request or an integration type that does not implement the operation. `INTEGRATION_NOT_CONFIGURED` (404): the organization has no enabled integration of the requested type. `INTEGRATION_STATE_CHANGED` (409): the integration mutated after the signed reference was issued; run a new search. `INTEGRATION_REFERENCE_INVALID` (404): the signed delivery reference is forged, tampered, malformed, or expired; obtain a fresh reference from a new search. `INTEGRATION_SERVER_ERROR` (503): server-side failure (adapter or runtime unavailable, credential unusable, or a malformed upstream response); retry later.
    /// </summary>
    public enum IntegrationErrorResponseError
    {
        /// <summary>
        /// the caller or organization is not allowed to use integrations. `MINI_APP_TOKEN_MISSING_SCOPES` (403): emitted by the shared mini-app token middleware. `INTEGRATION_REQUEST_INVALID` (400): malformed search request or an integration type that does not implement the operation. `INTEGRATION_NOT_CONFIGURED` (404): the organization has no enabled integration of the requested type. `INTEGRATION_STATE_CHANGED` (409): the integration mutated after the signed reference was issued; run a new search. `INTEGRATION_REFERENCE_INVALID` (404): the signed delivery reference is forged, tampered, malformed, or expired; obtain a fresh reference from a new search. `INTEGRATION_SERVER_ERROR` (503): server-side failure (adapter or runtime unavailable, credential unusable, or a malformed upstream response); retry later.
        /// </summary>
        IntegrationAccessDenied,
        /// <summary>
        /// the caller or organization is not allowed to use integrations. `MINI_APP_TOKEN_MISSING_SCOPES` (403): emitted by the shared mini-app token middleware. `INTEGRATION_REQUEST_INVALID` (400): malformed search request or an integration type that does not implement the operation. `INTEGRATION_NOT_CONFIGURED` (404): the organization has no enabled integration of the requested type. `INTEGRATION_STATE_CHANGED` (409): the integration mutated after the signed reference was issued; run a new search. `INTEGRATION_REFERENCE_INVALID` (404): the signed delivery reference is forged, tampered, malformed, or expired; obtain a fresh reference from a new search. `INTEGRATION_SERVER_ERROR` (503): server-side failure (adapter or runtime unavailable, credential unusable, or a malformed upstream response); retry later.
        /// </summary>
        IntegrationNotConfigured,
        /// <summary>
        /// the caller or organization is not allowed to use integrations. `MINI_APP_TOKEN_MISSING_SCOPES` (403): emitted by the shared mini-app token middleware. `INTEGRATION_REQUEST_INVALID` (400): malformed search request or an integration type that does not implement the operation. `INTEGRATION_NOT_CONFIGURED` (404): the organization has no enabled integration of the requested type. `INTEGRATION_STATE_CHANGED` (409): the integration mutated after the signed reference was issued; run a new search. `INTEGRATION_REFERENCE_INVALID` (404): the signed delivery reference is forged, tampered, malformed, or expired; obtain a fresh reference from a new search. `INTEGRATION_SERVER_ERROR` (503): server-side failure (adapter or runtime unavailable, credential unusable, or a malformed upstream response); retry later.
        /// </summary>
        IntegrationReferenceInvalid,
        /// <summary>
        /// the caller or organization is not allowed to use integrations. `MINI_APP_TOKEN_MISSING_SCOPES` (403): emitted by the shared mini-app token middleware. `INTEGRATION_REQUEST_INVALID` (400): malformed search request or an integration type that does not implement the operation. `INTEGRATION_NOT_CONFIGURED` (404): the organization has no enabled integration of the requested type. `INTEGRATION_STATE_CHANGED` (409): the integration mutated after the signed reference was issued; run a new search. `INTEGRATION_REFERENCE_INVALID` (404): the signed delivery reference is forged, tampered, malformed, or expired; obtain a fresh reference from a new search. `INTEGRATION_SERVER_ERROR` (503): server-side failure (adapter or runtime unavailable, credential unusable, or a malformed upstream response); retry later.
        /// </summary>
        IntegrationRequestInvalid,
        /// <summary>
        /// the caller or organization is not allowed to use integrations. `MINI_APP_TOKEN_MISSING_SCOPES` (403): emitted by the shared mini-app token middleware. `INTEGRATION_REQUEST_INVALID` (400): malformed search request or an integration type that does not implement the operation. `INTEGRATION_NOT_CONFIGURED` (404): the organization has no enabled integration of the requested type. `INTEGRATION_STATE_CHANGED` (409): the integration mutated after the signed reference was issued; run a new search. `INTEGRATION_REFERENCE_INVALID` (404): the signed delivery reference is forged, tampered, malformed, or expired; obtain a fresh reference from a new search. `INTEGRATION_SERVER_ERROR` (503): server-side failure (adapter or runtime unavailable, credential unusable, or a malformed upstream response); retry later.
        /// </summary>
        IntegrationServerError,
        /// <summary>
        /// the caller or organization is not allowed to use integrations. `MINI_APP_TOKEN_MISSING_SCOPES` (403): emitted by the shared mini-app token middleware. `INTEGRATION_REQUEST_INVALID` (400): malformed search request or an integration type that does not implement the operation. `INTEGRATION_NOT_CONFIGURED` (404): the organization has no enabled integration of the requested type. `INTEGRATION_STATE_CHANGED` (409): the integration mutated after the signed reference was issued; run a new search. `INTEGRATION_REFERENCE_INVALID` (404): the signed delivery reference is forged, tampered, malformed, or expired; obtain a fresh reference from a new search. `INTEGRATION_SERVER_ERROR` (503): server-side failure (adapter or runtime unavailable, credential unusable, or a malformed upstream response); retry later.
        /// </summary>
        IntegrationStateChanged,
        /// <summary>
        /// the caller or organization is not allowed to use integrations. `MINI_APP_TOKEN_MISSING_SCOPES` (403): emitted by the shared mini-app token middleware. `INTEGRATION_REQUEST_INVALID` (400): malformed search request or an integration type that does not implement the operation. `INTEGRATION_NOT_CONFIGURED` (404): the organization has no enabled integration of the requested type. `INTEGRATION_STATE_CHANGED` (409): the integration mutated after the signed reference was issued; run a new search. `INTEGRATION_REFERENCE_INVALID` (404): the signed delivery reference is forged, tampered, malformed, or expired; obtain a fresh reference from a new search. `INTEGRATION_SERVER_ERROR` (503): server-side failure (adapter or runtime unavailable, credential unusable, or a malformed upstream response); retry later.
        /// </summary>
        MiniAppTokenMissingScopes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntegrationErrorResponseErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntegrationErrorResponseError value)
        {
            return value switch
            {
                IntegrationErrorResponseError.IntegrationAccessDenied => "INTEGRATION_ACCESS_DENIED",
                IntegrationErrorResponseError.IntegrationNotConfigured => "INTEGRATION_NOT_CONFIGURED",
                IntegrationErrorResponseError.IntegrationReferenceInvalid => "INTEGRATION_REFERENCE_INVALID",
                IntegrationErrorResponseError.IntegrationRequestInvalid => "INTEGRATION_REQUEST_INVALID",
                IntegrationErrorResponseError.IntegrationServerError => "INTEGRATION_SERVER_ERROR",
                IntegrationErrorResponseError.IntegrationStateChanged => "INTEGRATION_STATE_CHANGED",
                IntegrationErrorResponseError.MiniAppTokenMissingScopes => "MINI_APP_TOKEN_MISSING_SCOPES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntegrationErrorResponseError? ToEnum(string value)
        {
            return value switch
            {
                "INTEGRATION_ACCESS_DENIED" => IntegrationErrorResponseError.IntegrationAccessDenied,
                "INTEGRATION_NOT_CONFIGURED" => IntegrationErrorResponseError.IntegrationNotConfigured,
                "INTEGRATION_REFERENCE_INVALID" => IntegrationErrorResponseError.IntegrationReferenceInvalid,
                "INTEGRATION_REQUEST_INVALID" => IntegrationErrorResponseError.IntegrationRequestInvalid,
                "INTEGRATION_SERVER_ERROR" => IntegrationErrorResponseError.IntegrationServerError,
                "INTEGRATION_STATE_CHANGED" => IntegrationErrorResponseError.IntegrationStateChanged,
                "MINI_APP_TOKEN_MISSING_SCOPES" => IntegrationErrorResponseError.MiniAppTokenMissingScopes,
                _ => null,
            };
        }
    }
}
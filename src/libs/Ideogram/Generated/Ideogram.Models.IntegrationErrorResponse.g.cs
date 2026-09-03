
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"token_scopes":["token_scopes","token_scopes"],"required_scopes":["required_scopes","required_scopes"],"error":"INTEGRATION_ACCESS_DENIED","message":"message"}
    /// </summary>
    public sealed partial class IntegrationErrorResponse
    {
        /// <summary>
        /// Stable machine-readable integration error code. `INTEGRATION_ACCESS_DENIED` (403): the caller or organization is not allowed to use integrations. `MINI_APP_TOKEN_MISSING_SCOPES` (403): emitted by the shared mini-app token middleware. `INTEGRATION_REQUEST_INVALID` (400): malformed search request or an integration type that does not implement the operation. `INTEGRATION_NOT_CONFIGURED` (404): the organization has no enabled integration of the requested type. `INTEGRATION_STATE_CHANGED` (409): the integration mutated after the signed reference was issued; run a new search. `INTEGRATION_REFERENCE_INVALID` (404): the signed delivery reference is forged, tampered, malformed, or expired; obtain a fresh reference from a new search. `INTEGRATION_SERVER_ERROR` (503): server-side failure (adapter or runtime unavailable, credential unusable, or a malformed upstream response); retry later.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.IntegrationErrorResponseErrorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.IntegrationErrorResponseError Error { get; set; }

        /// <summary>
        /// Stable human-readable explanation of the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Required mini-app scopes when scope authorization fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_scopes")]
        public global::System.Collections.Generic.IList<string>? RequiredScopes { get; set; }

        /// <summary>
        /// Scopes present in the mini-app token when authorization fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_scopes")]
        public global::System.Collections.Generic.IList<string>? TokenScopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationErrorResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Stable machine-readable integration error code. `INTEGRATION_ACCESS_DENIED` (403): the caller or organization is not allowed to use integrations. `MINI_APP_TOKEN_MISSING_SCOPES` (403): emitted by the shared mini-app token middleware. `INTEGRATION_REQUEST_INVALID` (400): malformed search request or an integration type that does not implement the operation. `INTEGRATION_NOT_CONFIGURED` (404): the organization has no enabled integration of the requested type. `INTEGRATION_STATE_CHANGED` (409): the integration mutated after the signed reference was issued; run a new search. `INTEGRATION_REFERENCE_INVALID` (404): the signed delivery reference is forged, tampered, malformed, or expired; obtain a fresh reference from a new search. `INTEGRATION_SERVER_ERROR` (503): server-side failure (adapter or runtime unavailable, credential unusable, or a malformed upstream response); retry later.
        /// </param>
        /// <param name="message">
        /// Stable human-readable explanation of the error.
        /// </param>
        /// <param name="requiredScopes">
        /// Required mini-app scopes when scope authorization fails.
        /// </param>
        /// <param name="tokenScopes">
        /// Scopes present in the mini-app token when authorization fails.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationErrorResponse(
            global::Ideogram.IntegrationErrorResponseError error,
            string message,
            global::System.Collections.Generic.IList<string>? requiredScopes,
            global::System.Collections.Generic.IList<string>? tokenScopes)
        {
            this.Error = error;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RequiredScopes = requiredScopes;
            this.TokenScopes = tokenScopes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationErrorResponse" /> class.
        /// </summary>
        public IntegrationErrorResponse()
        {
        }

    }
}
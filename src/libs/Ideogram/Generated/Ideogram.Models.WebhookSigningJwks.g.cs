
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// JSON Web Key Set listing the Ed25519 public keys Ideogram uses to sign<br/>
    /// webhook payloads. Each entry follows RFC 7517 conventions for OKP keys.<br/>
    /// Example: {"keys":[{"kty":"OKP","crv":"Ed25519","use":"sig","kid":"v1","x":"11qYAYKxCrfVS_7TyWQHOg7hcvPapiMlrwIaaPcHURo","alg":"EdDSA"},{"kty":"OKP","crv":"Ed25519","use":"sig","kid":"v1","x":"11qYAYKxCrfVS_7TyWQHOg7hcvPapiMlrwIaaPcHURo","alg":"EdDSA"}]}
    /// </summary>
    public sealed partial class WebhookSigningJwks
    {
        /// <summary>
        /// Active and recently-rotated signing keys. A webhook is authentic if<br/>
        /// its signature verifies against any key in this list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.WebhookSigningJwk> Keys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSigningJwks" /> class.
        /// </summary>
        /// <param name="keys">
        /// Active and recently-rotated signing keys. A webhook is authentic if<br/>
        /// its signature verifies against any key in this list.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookSigningJwks(
            global::System.Collections.Generic.IList<global::Ideogram.WebhookSigningJwk> keys)
        {
            this.Keys = keys ?? throw new global::System.ArgumentNullException(nameof(keys));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSigningJwks" /> class.
        /// </summary>
        public WebhookSigningJwks()
        {
        }

    }
}
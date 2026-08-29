
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A single Ed25519 public key. The `x` field carries the 32-byte public<br/>
    /// key as base64url without padding; `kid` matches the<br/>
    /// `X-Ideogram-Webhook-Key-Id` header on outbound webhooks for cache hints,<br/>
    /// but verifiers SHOULD try every key in the set rather than relying on<br/>
    /// `kid` alone.<br/>
    /// Example: {"kty":"OKP","crv":"Ed25519","use":"sig","kid":"v1","x":"11qYAYKxCrfVS_7TyWQHOg7hcvPapiMlrwIaaPcHURo","alg":"EdDSA"}
    /// </summary>
    public sealed partial class WebhookSigningJwk
    {
        /// <summary>
        /// Key type. Always `"OKP"` for Ed25519.<br/>
        /// Example: OKP
        /// </summary>
        /// <example>OKP</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("kty")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kty { get; set; }

        /// <summary>
        /// Curve. Always `"Ed25519"`.<br/>
        /// Example: Ed25519
        /// </summary>
        /// <example>Ed25519</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("crv")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Crv { get; set; }

        /// <summary>
        /// The 32-byte public key, base64url-encoded without padding.<br/>
        /// Example: 11qYAYKxCrfVS_7TyWQHOg7hcvPapiMlrwIaaPcHURo
        /// </summary>
        /// <example>11qYAYKxCrfVS_7TyWQHOg7hcvPapiMlrwIaaPcHURo</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string X { get; set; }

        /// <summary>
        /// Opaque key identifier; stable across rotations of the same key.<br/>
        /// Example: v1
        /// </summary>
        /// <example>v1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("kid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kid { get; set; }

        /// <summary>
        /// Always `"EdDSA"`.<br/>
        /// Example: EdDSA
        /// </summary>
        /// <example>EdDSA</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alg")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alg { get; set; }

        /// <summary>
        /// Always `"sig"` (signing-only).<br/>
        /// Example: sig
        /// </summary>
        /// <example>sig</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("use")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Use { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSigningJwk" /> class.
        /// </summary>
        /// <param name="kty">
        /// Key type. Always `"OKP"` for Ed25519.<br/>
        /// Example: OKP
        /// </param>
        /// <param name="crv">
        /// Curve. Always `"Ed25519"`.<br/>
        /// Example: Ed25519
        /// </param>
        /// <param name="x">
        /// The 32-byte public key, base64url-encoded without padding.<br/>
        /// Example: 11qYAYKxCrfVS_7TyWQHOg7hcvPapiMlrwIaaPcHURo
        /// </param>
        /// <param name="kid">
        /// Opaque key identifier; stable across rotations of the same key.<br/>
        /// Example: v1
        /// </param>
        /// <param name="alg">
        /// Always `"EdDSA"`.<br/>
        /// Example: EdDSA
        /// </param>
        /// <param name="use">
        /// Always `"sig"` (signing-only).<br/>
        /// Example: sig
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookSigningJwk(
            string kty,
            string crv,
            string x,
            string kid,
            string alg,
            string use)
        {
            this.Kty = kty ?? throw new global::System.ArgumentNullException(nameof(kty));
            this.Crv = crv ?? throw new global::System.ArgumentNullException(nameof(crv));
            this.X = x ?? throw new global::System.ArgumentNullException(nameof(x));
            this.Kid = kid ?? throw new global::System.ArgumentNullException(nameof(kid));
            this.Alg = alg ?? throw new global::System.ArgumentNullException(nameof(alg));
            this.Use = use ?? throw new global::System.ArgumentNullException(nameof(use));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSigningJwk" /> class.
        /// </summary>
        public WebhookSigningJwk()
        {
        }

    }
}
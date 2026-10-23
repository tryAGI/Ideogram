
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SvgGeneratePostVectorizerRequest
    {
        /// <summary>
        /// JPEG, PNG or WEBP source; at most 50 MB. Multipart only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// JPEG, PNG or WEBP source; at most 50 MB. Multipart only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifier")]
        public global::Ideogram.V2.AssetIdentifier? ImageAssetIdentifier { get; set; }

        /// <summary>
        /// Simple uses fewer shapes; detailed preserves fine detail; auto chooses the level of detail that best suits the image.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.V2SvgVectorizeIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaModeJsonConverter))]
        public global::Ideogram.V2.V2SvgVectorizeIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaMode? Mode { get; set; }

        /// <summary>
        /// Outputs are private by default. Enterprise outputs are always private.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// URL-safe base64 ID of a writable destination collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_collection_id")]
        public string? TargetCollectionId { get; set; }

        /// <summary>
        /// HTTPS URL that Ideogram delivers the generated result to. Ideogram sends a<br/>
        /// JSON POST to this URL once all images for the request have finished<br/>
        /// generating. The body mirrors the synchronous generate response:<br/>
        /// `request_id`, `created`, and a `data` array<br/>
        /// containing every generated image (`url`, `prompt`, `resolution`, `seed`,<br/>
        /// `is_image_safe`). Each delivery is signed with Ed25519 and verifiable<br/>
        /// against the public keys at `https://api.ideogram.ai/v1/.well-known/jwks.json`. Must be HTTPS;<br/>
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgGeneratePostVectorizerRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// JPEG, PNG or WEBP source; at most 50 MB. Multipart only.
        /// </param>
        /// <param name="imagename">
        /// JPEG, PNG or WEBP source; at most 50 MB. Multipart only.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.
        /// </param>
        /// <param name="mode">
        /// Simple uses fewer shapes; detailed preserves fine detail; auto chooses the level of detail that best suits the image.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="private">
        /// Outputs are private by default. Enterprise outputs are always private.
        /// </param>
        /// <param name="targetCollectionId">
        /// URL-safe base64 ID of a writable destination collection.
        /// </param>
        /// <param name="webhookUrl">
        /// HTTPS URL that Ideogram delivers the generated result to. Ideogram sends a<br/>
        /// JSON POST to this URL once all images for the request have finished<br/>
        /// generating. The body mirrors the synchronous generate response:<br/>
        /// `request_id`, `created`, and a `data` array<br/>
        /// containing every generated image (`url`, `prompt`, `resolution`, `seed`,<br/>
        /// `is_image_safe`). Each delivery is signed with Ed25519 and verifiable<br/>
        /// against the public keys at `https://api.ideogram.ai/v1/.well-known/jwks.json`. Must be HTTPS;<br/>
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SvgGeneratePostVectorizerRequest(
            byte[]? image,
            string? imagename,
            global::Ideogram.V2.AssetIdentifier? imageAssetIdentifier,
            global::Ideogram.V2.V2SvgVectorizeIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaMode? mode,
            bool? @private,
            string? targetCollectionId,
            string? webhookUrl)
        {
            this.Image = image;
            this.Imagename = imagename;
            this.ImageAssetIdentifier = imageAssetIdentifier;
            this.Mode = mode;
            this.Private = @private;
            this.TargetCollectionId = targetCollectionId;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgGeneratePostVectorizerRequest" /> class.
        /// </summary>
        public SvgGeneratePostVectorizerRequest()
        {
        }

    }
}

#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EditWorkflowPostGhostMannequinRequest
    {
        /// <summary>
        /// Additional photos of the same garment, up to 50 MB each. JPEG,<br/>
        /// PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and MPO are supported.<br/>
        /// Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("garment_images")]
        public global::System.Collections.Generic.IList<byte[]>? GarmentImages { get; set; }

        /// <summary>
        /// Optional front-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("front_image")]
        public byte[]? FrontImage { get; set; }

        /// <summary>
        /// Optional front-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("front_imagename")]
        public string? FrontImagename { get; set; }

        /// <summary>
        /// Optional back-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("back_image")]
        public byte[]? BackImage { get; set; }

        /// <summary>
        /// Optional back-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("back_imagename")]
        public string? BackImagename { get; set; }

        /// <summary>
        /// Optional left-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_image")]
        public byte[]? LeftImage { get; set; }

        /// <summary>
        /// Optional left-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_imagename")]
        public string? LeftImagename { get; set; }

        /// <summary>
        /// Optional right-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right_image")]
        public byte[]? RightImage { get; set; }

        /// <summary>
        /// Optional right-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right_imagename")]
        public string? RightImagename { get; set; }

        /// <summary>
        /// Optional top-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_image")]
        public byte[]? TopImage { get; set; }

        /// <summary>
        /// Optional top-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_imagename")]
        public string? TopImagename { get; set; }

        /// <summary>
        /// Optional bottom-view garment photo, up to 50 MB. Multipart<br/>
        /// requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom_image")]
        public byte[]? BottomImage { get; set; }

        /// <summary>
        /// Optional bottom-view garment photo, up to 50 MB. Multipart<br/>
        /// requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom_imagename")]
        public string? BottomImagename { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_reference_asset_identifier")]
        public global::Ideogram.AssetIdentifier? OutputReferenceAssetIdentifier { get; set; }

        /// <summary>
        /// Optional presentation example, up to 50 MB. Multipart requests only.<br/>
        /// Guides pose, framing, and lighting without copying its garment,<br/>
        /// colors, text, or branding. Garment photos remain authoritative for<br/>
        /// product identity; view and aspect_ratio take precedence, and the<br/>
        /// background remains white. Does not replace a required garment photo.<br/>
        /// Mutually exclusive with `output_reference_asset_identifier`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_reference_image")]
        public byte[]? OutputReferenceImage { get; set; }

        /// <summary>
        /// Optional presentation example, up to 50 MB. Multipart requests only.<br/>
        /// Guides pose, framing, and lighting without copying its garment,<br/>
        /// colors, text, or branding. Garment photos remain authoritative for<br/>
        /// product identity; view and aspect_ratio take precedence, and the<br/>
        /// background remains white. Does not replace a required garment photo.<br/>
        /// Mutually exclusive with `output_reference_asset_identifier`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_reference_imagename")]
        public string? OutputReferenceImagename { get; set; }

        /// <summary>
        /// Camera view for the output garment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaViewJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView View { get; set; }

        /// <summary>
        /// Optional reconstruction guidance or identity-critical garment<br/>
        /// details to check against the photos. The output always uses a clean<br/>
        /// white studio background.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        public string? Instruction { get; set; }

        /// <summary>
        /// Optional JSON object serialized as a string containing factual<br/>
        /// product context, such as title, brand, category, color, material,<br/>
        /// item code, and exact printed text. Metadata helps disambiguate the<br/>
        /// garment photos but does not add features they do not show.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// Output aspect ratio. Defaults to `1:1` when omitted. Supported<br/>
        /// values are `1:1`, `3:4`, `4:3`, `16:9`, and `9:16`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GhostMannequinQualityJsonConverter))]
        public global::Ideogram.GhostMannequinQuality? Quality { get; set; }

        /// <summary>
        /// Optional seed for repeatable results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

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
        /// Initializes a new instance of the <see cref="EditWorkflowPostGhostMannequinRequest" /> class.
        /// </summary>
        /// <param name="view">
        /// Camera view for the output garment.
        /// </param>
        /// <param name="garmentImages">
        /// Additional photos of the same garment, up to 50 MB each. JPEG,<br/>
        /// PNG, WEBP, HEIF, AVIF, GIF, BMP, TIFF, and MPO are supported.<br/>
        /// Multipart requests only.
        /// </param>
        /// <param name="frontImage">
        /// Optional front-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="frontImagename">
        /// Optional front-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="backImage">
        /// Optional back-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="backImagename">
        /// Optional back-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="leftImage">
        /// Optional left-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="leftImagename">
        /// Optional left-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="rightImage">
        /// Optional right-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="rightImagename">
        /// Optional right-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="topImage">
        /// Optional top-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="topImagename">
        /// Optional top-view garment photo, up to 50 MB. Multipart requests<br/>
        /// only.
        /// </param>
        /// <param name="bottomImage">
        /// Optional bottom-view garment photo, up to 50 MB. Multipart<br/>
        /// requests only.
        /// </param>
        /// <param name="bottomImagename">
        /// Optional bottom-view garment photo, up to 50 MB. Multipart<br/>
        /// requests only.
        /// </param>
        /// <param name="outputReferenceAssetIdentifier">
        /// An identifier for an ideogram asset.
        /// </param>
        /// <param name="outputReferenceImage">
        /// Optional presentation example, up to 50 MB. Multipart requests only.<br/>
        /// Guides pose, framing, and lighting without copying its garment,<br/>
        /// colors, text, or branding. Garment photos remain authoritative for<br/>
        /// product identity; view and aspect_ratio take precedence, and the<br/>
        /// background remains white. Does not replace a required garment photo.<br/>
        /// Mutually exclusive with `output_reference_asset_identifier`.
        /// </param>
        /// <param name="outputReferenceImagename">
        /// Optional presentation example, up to 50 MB. Multipart requests only.<br/>
        /// Guides pose, framing, and lighting without copying its garment,<br/>
        /// colors, text, or branding. Garment photos remain authoritative for<br/>
        /// product identity; view and aspect_ratio take precedence, and the<br/>
        /// background remains white. Does not replace a required garment photo.<br/>
        /// Mutually exclusive with `output_reference_asset_identifier`.
        /// </param>
        /// <param name="instruction">
        /// Optional reconstruction guidance or identity-critical garment<br/>
        /// details to check against the photos. The output always uses a clean<br/>
        /// white studio background.
        /// </param>
        /// <param name="metadata">
        /// Optional JSON object serialized as a string containing factual<br/>
        /// product context, such as title, brand, category, color, material,<br/>
        /// item code, and exact printed text. Metadata helps disambiguate the<br/>
        /// garment photos but does not add features they do not show.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. Defaults to `1:1` when omitted. Supported<br/>
        /// values are `1:1`, `3:4`, `4:3`, `16:9`, and `9:16`.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Optional seed for repeatable results.
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
        public EditWorkflowPostGhostMannequinRequest(
            global::Ideogram.V2ToolGhostMannequinPostRequestBodyContentMultipartFormDataSchemaView view,
            global::System.Collections.Generic.IList<byte[]>? garmentImages,
            byte[]? frontImage,
            string? frontImagename,
            byte[]? backImage,
            string? backImagename,
            byte[]? leftImage,
            string? leftImagename,
            byte[]? rightImage,
            string? rightImagename,
            byte[]? topImage,
            string? topImagename,
            byte[]? bottomImage,
            string? bottomImagename,
            global::Ideogram.AssetIdentifier? outputReferenceAssetIdentifier,
            byte[]? outputReferenceImage,
            string? outputReferenceImagename,
            string? instruction,
            string? metadata,
            string? aspectRatio,
            global::Ideogram.GhostMannequinQuality? quality,
            int? seed,
            string? webhookUrl)
        {
            this.GarmentImages = garmentImages;
            this.FrontImage = frontImage;
            this.FrontImagename = frontImagename;
            this.BackImage = backImage;
            this.BackImagename = backImagename;
            this.LeftImage = leftImage;
            this.LeftImagename = leftImagename;
            this.RightImage = rightImage;
            this.RightImagename = rightImagename;
            this.TopImage = topImage;
            this.TopImagename = topImagename;
            this.BottomImage = bottomImage;
            this.BottomImagename = bottomImagename;
            this.OutputReferenceAssetIdentifier = outputReferenceAssetIdentifier;
            this.OutputReferenceImage = outputReferenceImage;
            this.OutputReferenceImagename = outputReferenceImagename;
            this.View = view;
            this.Instruction = instruction;
            this.Metadata = metadata;
            this.AspectRatio = aspectRatio;
            this.Quality = quality;
            this.Seed = seed;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditWorkflowPostGhostMannequinRequest" /> class.
        /// </summary>
        public EditWorkflowPostGhostMannequinRequest()
        {
        }

    }
}
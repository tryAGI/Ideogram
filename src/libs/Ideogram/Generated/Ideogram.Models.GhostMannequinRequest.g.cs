
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Supply at least one garment reference. Directional references are<br/>
    /// nullable and accept at most one of their asset-identifier or multipart<br/>
    /// image fields. Additional unlabeled references can use exactly one of<br/>
    /// `garment_asset_identifiers` or multipart `garment_images`. Every<br/>
    /// garment image must depict the same primary garment. The total number<br/>
    /// of garment references must not exceed 15, and all raw image uploads<br/>
    /// combined must not exceed 100 MB.
    /// </summary>
    public sealed partial class GhostMannequinRequest
    {
        /// <summary>
        /// Ordered uploaded or generated images of the same garment. Use<br/>
        /// multiple angles when available so obscured construction can be<br/>
        /// reconstructed conservatively. Mutually exclusive with<br/>
        /// `garment_images`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("garment_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? GarmentAssetIdentifiers { get; set; }

        /// <summary>
        /// Raw images of the same garment, up to 50 MB each. JPEG, PNG, WEBP,<br/>
        /// HEIF, AVIF, GIF, BMP, TIFF, and MPO are supported. Multipart<br/>
        /// requests only. Mutually exclusive with<br/>
        /// `garment_asset_identifiers`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("garment_images")]
        public global::System.Collections.Generic.IList<byte[]>? GarmentImages { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("front_asset_identifier")]
        public global::Ideogram.AssetIdentifier? FrontAssetIdentifier { get; set; }

        /// <summary>
        /// Optional raw front-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `front_asset_identifier`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("front_image")]
        public byte[]? FrontImage { get; set; }

        /// <summary>
        /// Optional raw front-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `front_asset_identifier`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("front_imagename")]
        public string? FrontImagename { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("back_asset_identifier")]
        public global::Ideogram.AssetIdentifier? BackAssetIdentifier { get; set; }

        /// <summary>
        /// Optional raw back-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `back_asset_identifier`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("back_image")]
        public byte[]? BackImage { get; set; }

        /// <summary>
        /// Optional raw back-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `back_asset_identifier`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("back_imagename")]
        public string? BackImagename { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_asset_identifier")]
        public global::Ideogram.AssetIdentifier? LeftAssetIdentifier { get; set; }

        /// <summary>
        /// Optional raw left-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `left_asset_identifier`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_image")]
        public byte[]? LeftImage { get; set; }

        /// <summary>
        /// Optional raw left-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `left_asset_identifier`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_imagename")]
        public string? LeftImagename { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("right_asset_identifier")]
        public global::Ideogram.AssetIdentifier? RightAssetIdentifier { get; set; }

        /// <summary>
        /// Optional raw right-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `right_asset_identifier`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right_image")]
        public byte[]? RightImage { get; set; }

        /// <summary>
        /// Optional raw right-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `right_asset_identifier`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right_imagename")]
        public string? RightImagename { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_asset_identifier")]
        public global::Ideogram.AssetIdentifier? TopAssetIdentifier { get; set; }

        /// <summary>
        /// Optional raw top-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `top_asset_identifier`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_image")]
        public byte[]? TopImage { get; set; }

        /// <summary>
        /// Optional raw top-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `top_asset_identifier`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_imagename")]
        public string? TopImagename { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom_asset_identifier")]
        public global::Ideogram.AssetIdentifier? BottomAssetIdentifier { get; set; }

        /// <summary>
        /// Optional raw bottom-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with<br/>
        /// `bottom_asset_identifier`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom_image")]
        public byte[]? BottomImage { get; set; }

        /// <summary>
        /// Optional raw bottom-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with<br/>
        /// `bottom_asset_identifier`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom_imagename")]
        public string? BottomImagename { get; set; }

        /// <summary>
        /// Camera view for the output garment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GhostMannequinRequestViewJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.GhostMannequinRequestView View { get; set; }

        /// <summary>
        /// Optional reconstruction guidance or identity-critical garment<br/>
        /// details for the analyzer to verify. The output always uses the<br/>
        /// workflow's clean white studio presentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        public string? Instruction { get; set; }

        /// <summary>
        /// Optional JSON object serialized as a string containing factual<br/>
        /// product context, such as title, brand, category, color, material,<br/>
        /// item code, and exact printed text. Metadata helps disambiguate the<br/>
        /// garment references but does not add unsupported visual features.
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
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GptImage2QualityJsonConverter))]
        public global::Ideogram.GptImage2Quality? Quality { get; set; }

        /// <summary>
        /// Optional seed for repeatable results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// A collection you can write to, by its URL-safe base64 collection id. Completed outputs are added to it automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_collection_id")]
        public string? TargetCollectionId { get; set; }

        /// <summary>
        /// When true or omitted, the output is kept private to your account. Set to false to publish the output to the public feed. Enterprise accounts always generate privately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// HTTPS URL that Ideogram delivers the generated result to. Ideogram sends a<br/>
        /// JSON POST to this URL once all images for the request have finished<br/>
        /// generating. The body mirrors the synchronous generate response:<br/>
        /// `request_id`, `created`, and a `data` array<br/>
        /// containing every generated image (`url`, `prompt`, `resolution`, `seed`,<br/>
        /// `is_image_safe`). Each delivery is signed with Ed25519 and verifiable<br/>
        /// against the public keys at `https://api.ideogram.ai/v1/.well-known/jwks.json`. Must be HTTPS;<br/>
        /// private and loopback hosts and the cloud metadata service are rejected.<br/>
        /// Example: https://api.example.com/webhooks/ideogram
        /// </summary>
        /// <example>https://api.example.com/webhooks/ideogram</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GhostMannequinRequest" /> class.
        /// </summary>
        /// <param name="view">
        /// Camera view for the output garment.
        /// </param>
        /// <param name="garmentAssetIdentifiers">
        /// Ordered uploaded or generated images of the same garment. Use<br/>
        /// multiple angles when available so obscured construction can be<br/>
        /// reconstructed conservatively. Mutually exclusive with<br/>
        /// `garment_images`.
        /// </param>
        /// <param name="garmentImages">
        /// Raw images of the same garment, up to 50 MB each. JPEG, PNG, WEBP,<br/>
        /// HEIF, AVIF, GIF, BMP, TIFF, and MPO are supported. Multipart<br/>
        /// requests only. Mutually exclusive with<br/>
        /// `garment_asset_identifiers`.
        /// </param>
        /// <param name="frontAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="frontImage">
        /// Optional raw front-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `front_asset_identifier`.
        /// </param>
        /// <param name="frontImagename">
        /// Optional raw front-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `front_asset_identifier`.
        /// </param>
        /// <param name="backAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="backImage">
        /// Optional raw back-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `back_asset_identifier`.
        /// </param>
        /// <param name="backImagename">
        /// Optional raw back-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `back_asset_identifier`.
        /// </param>
        /// <param name="leftAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="leftImage">
        /// Optional raw left-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `left_asset_identifier`.
        /// </param>
        /// <param name="leftImagename">
        /// Optional raw left-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `left_asset_identifier`.
        /// </param>
        /// <param name="rightAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="rightImage">
        /// Optional raw right-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `right_asset_identifier`.
        /// </param>
        /// <param name="rightImagename">
        /// Optional raw right-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `right_asset_identifier`.
        /// </param>
        /// <param name="topAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="topImage">
        /// Optional raw top-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `top_asset_identifier`.
        /// </param>
        /// <param name="topImagename">
        /// Optional raw top-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with `top_asset_identifier`.
        /// </param>
        /// <param name="bottomAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="bottomImage">
        /// Optional raw bottom-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with<br/>
        /// `bottom_asset_identifier`.
        /// </param>
        /// <param name="bottomImagename">
        /// Optional raw bottom-view garment reference, up to 50 MB. Multipart<br/>
        /// requests only. Mutually exclusive with<br/>
        /// `bottom_asset_identifier`.
        /// </param>
        /// <param name="instruction">
        /// Optional reconstruction guidance or identity-critical garment<br/>
        /// details for the analyzer to verify. The output always uses the<br/>
        /// workflow's clean white studio presentation.
        /// </param>
        /// <param name="metadata">
        /// Optional JSON object serialized as a string containing factual<br/>
        /// product context, such as title, brand, category, color, material,<br/>
        /// item code, and exact printed text. Metadata helps disambiguate the<br/>
        /// garment references but does not add unsupported visual features.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. Defaults to `1:1` when omitted. Supported<br/>
        /// values are `1:1`, `3:4`, `4:3`, `16:9`, and `9:16`.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
        /// </param>
        /// <param name="seed">
        /// Optional seed for repeatable results.
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. Completed outputs are added to it automatically.
        /// </param>
        /// <param name="private">
        /// When true or omitted, the output is kept private to your account. Set to false to publish the output to the public feed. Enterprise accounts always generate privately.
        /// </param>
        /// <param name="webhookUrl">
        /// HTTPS URL that Ideogram delivers the generated result to. Ideogram sends a<br/>
        /// JSON POST to this URL once all images for the request have finished<br/>
        /// generating. The body mirrors the synchronous generate response:<br/>
        /// `request_id`, `created`, and a `data` array<br/>
        /// containing every generated image (`url`, `prompt`, `resolution`, `seed`,<br/>
        /// `is_image_safe`). Each delivery is signed with Ed25519 and verifiable<br/>
        /// against the public keys at `https://api.ideogram.ai/v1/.well-known/jwks.json`. Must be HTTPS;<br/>
        /// private and loopback hosts and the cloud metadata service are rejected.<br/>
        /// Example: https://api.example.com/webhooks/ideogram
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GhostMannequinRequest(
            global::Ideogram.GhostMannequinRequestView view,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? garmentAssetIdentifiers,
            global::System.Collections.Generic.IList<byte[]>? garmentImages,
            global::Ideogram.AssetIdentifier? frontAssetIdentifier,
            byte[]? frontImage,
            string? frontImagename,
            global::Ideogram.AssetIdentifier? backAssetIdentifier,
            byte[]? backImage,
            string? backImagename,
            global::Ideogram.AssetIdentifier? leftAssetIdentifier,
            byte[]? leftImage,
            string? leftImagename,
            global::Ideogram.AssetIdentifier? rightAssetIdentifier,
            byte[]? rightImage,
            string? rightImagename,
            global::Ideogram.AssetIdentifier? topAssetIdentifier,
            byte[]? topImage,
            string? topImagename,
            global::Ideogram.AssetIdentifier? bottomAssetIdentifier,
            byte[]? bottomImage,
            string? bottomImagename,
            string? instruction,
            string? metadata,
            string? aspectRatio,
            global::Ideogram.GptImage2Quality? quality,
            int? seed,
            string? targetCollectionId,
            bool? @private,
            string? webhookUrl)
        {
            this.GarmentAssetIdentifiers = garmentAssetIdentifiers;
            this.GarmentImages = garmentImages;
            this.FrontAssetIdentifier = frontAssetIdentifier;
            this.FrontImage = frontImage;
            this.FrontImagename = frontImagename;
            this.BackAssetIdentifier = backAssetIdentifier;
            this.BackImage = backImage;
            this.BackImagename = backImagename;
            this.LeftAssetIdentifier = leftAssetIdentifier;
            this.LeftImage = leftImage;
            this.LeftImagename = leftImagename;
            this.RightAssetIdentifier = rightAssetIdentifier;
            this.RightImage = rightImage;
            this.RightImagename = rightImagename;
            this.TopAssetIdentifier = topAssetIdentifier;
            this.TopImage = topImage;
            this.TopImagename = topImagename;
            this.BottomAssetIdentifier = bottomAssetIdentifier;
            this.BottomImage = bottomImage;
            this.BottomImagename = bottomImagename;
            this.View = view;
            this.Instruction = instruction;
            this.Metadata = metadata;
            this.AspectRatio = aspectRatio;
            this.Quality = quality;
            this.Seed = seed;
            this.TargetCollectionId = targetCollectionId;
            this.Private = @private;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GhostMannequinRequest" /> class.
        /// </summary>
        public GhostMannequinRequest()
        {
        }

    }
}
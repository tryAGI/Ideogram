
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Supply the person as either an `AssetIdentifier` reference or<br/>
    /// (multipart requests only) raw image bytes, and the garments likewise;<br/>
    /// for each source provide exactly one of the two forms. Supplying both<br/>
    /// forms of a source, or neither, is rejected with a 400.
    /// </summary>
    public sealed partial class VirtualTryOnRequest
    {
        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("person_asset_identifier")]
        public global::Ideogram.AssetIdentifier? PersonAssetIdentifier { get; set; }

        /// <summary>
        /// Photo of the person to dress (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Multipart requests only.<br/>
        /// Provide exactly one of `person_asset_identifier` or `person_image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("person_image")]
        public byte[]? PersonImage { get; set; }

        /// <summary>
        /// Photo of the person to dress (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Multipart requests only.<br/>
        /// Provide exactly one of `person_asset_identifier` or `person_image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("person_imagename")]
        public string? PersonImagename { get; set; }

        /// <summary>
        /// Photos of the clothing items to put on the person, by reference.<br/>
        /// Multiple garments are layered into one coherent outfit. Provide<br/>
        /// exactly one of `garment_asset_identifiers` or `garment_images`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("garment_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? GarmentAssetIdentifiers { get; set; }

        /// <summary>
        /// Photos of the clothing items to put on the person (max 7, max size<br/>
        /// 25MB per image), as raw bytes; only JPEG, PNG, and WEBP formats are<br/>
        /// supported. Multipart requests only. Provide exactly one of<br/>
        /// `garment_asset_identifiers` or `garment_images`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("garment_images")]
        public global::System.Collections.Generic.IList<byte[]>? GarmentImages { get; set; }

        /// <summary>
        /// The aspect ratio of the generated image. Defaults to the aspect<br/>
        /// ratio of the person's photo when omitted. Supported values are<br/>
        /// `1:1`, `3:4`, `4:3`, `16:9`, and `9:16`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// Free-text art direction, for example which garments to name, how to<br/>
        /// pose the person, and what background to place them in. The person's<br/>
        /// identity and each garment's exact appearance are always preserved,<br/>
        /// whatever this says. When omitted, the person keeps the pose and<br/>
        /// background from their photo.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        public string? Instruction { get; set; }

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
        /// Initializes a new instance of the <see cref="VirtualTryOnRequest" /> class.
        /// </summary>
        /// <param name="personAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="personImage">
        /// Photo of the person to dress (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Multipart requests only.<br/>
        /// Provide exactly one of `person_asset_identifier` or `person_image`.
        /// </param>
        /// <param name="personImagename">
        /// Photo of the person to dress (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Multipart requests only.<br/>
        /// Provide exactly one of `person_asset_identifier` or `person_image`.
        /// </param>
        /// <param name="garmentAssetIdentifiers">
        /// Photos of the clothing items to put on the person, by reference.<br/>
        /// Multiple garments are layered into one coherent outfit. Provide<br/>
        /// exactly one of `garment_asset_identifiers` or `garment_images`.
        /// </param>
        /// <param name="garmentImages">
        /// Photos of the clothing items to put on the person (max 7, max size<br/>
        /// 25MB per image), as raw bytes; only JPEG, PNG, and WEBP formats are<br/>
        /// supported. Multipart requests only. Provide exactly one of<br/>
        /// `garment_asset_identifiers` or `garment_images`.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generated image. Defaults to the aspect<br/>
        /// ratio of the person's photo when omitted. Supported values are<br/>
        /// `1:1`, `3:4`, `4:3`, `16:9`, and `9:16`.
        /// </param>
        /// <param name="instruction">
        /// Free-text art direction, for example which garments to name, how to<br/>
        /// pose the person, and what background to place them in. The person's<br/>
        /// identity and each garment's exact appearance are always preserved,<br/>
        /// whatever this says. When omitted, the person keeps the pose and<br/>
        /// background from their photo.
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
        public VirtualTryOnRequest(
            global::Ideogram.AssetIdentifier? personAssetIdentifier,
            byte[]? personImage,
            string? personImagename,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? garmentAssetIdentifiers,
            global::System.Collections.Generic.IList<byte[]>? garmentImages,
            string? aspectRatio,
            string? instruction,
            bool? @private,
            string? webhookUrl)
        {
            this.PersonAssetIdentifier = personAssetIdentifier;
            this.PersonImage = personImage;
            this.PersonImagename = personImagename;
            this.GarmentAssetIdentifiers = garmentAssetIdentifiers;
            this.GarmentImages = garmentImages;
            this.AspectRatio = aspectRatio;
            this.Instruction = instruction;
            this.Private = @private;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualTryOnRequest" /> class.
        /// </summary>
        public VirtualTryOnRequest()
        {
        }

    }
}
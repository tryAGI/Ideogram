#nullable enable

namespace Ideogram
{
    public partial interface IAutoModelClient
    {
        /// <summary>
        /// Remix an existing image, letting the server pick the best model<br/>
        /// Transform an existing image with a server-selected model, guided by a<br/>
        /// text prompt. Supply the source as `image` bytes (multipart requests<br/>
        /// only). `image_weight` controls how closely the result follows the<br/>
        /// source; when omitted the selected model chooses its usual strength.<br/>
        /// The server chooses a model that supports the requested remix controls:<br/>
        /// style references (ad hoc or saved), a color palette, style codes, a<br/>
        /// style preset, and a non-`AUTO` style type each<br/>
        /// restrict the request to a compatible model and to the 1K tier;<br/>
        /// remixes without those controls use the default model. Omit<br/>
        /// `resolution` and `aspect_ratio` to keep the source image's shape.<br/>
        /// Supplying `image_weight` together with a `resolution` or<br/>
        /// `aspect_ratio` that changes the source's aspect ratio routes the<br/>
        /// request to a model that crops the source to the new shape; that<br/>
        /// combination is served only at the 1K tier and is rejected at 2K.<br/>
        /// (The model-pinned remix endpoints such as<br/>
        /// `/v2/image/remix/ideogram-v4` reject the combination outright.)<br/>
        /// `seed` is honored only on the compatible model; the default model<br/>
        /// synthesizes an unseeded instruction prompt, so results are not<br/>
        /// reproducible there.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately after the<br/>
        /// request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ToolRemixResponse> PostToolRemixAsync(

            global::Ideogram.ToolRemixRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remix an existing image, letting the server pick the best model<br/>
        /// Transform an existing image with a server-selected model, guided by a<br/>
        /// text prompt. Supply the source as `image` bytes (multipart requests<br/>
        /// only). `image_weight` controls how closely the result follows the<br/>
        /// source; when omitted the selected model chooses its usual strength.<br/>
        /// The server chooses a model that supports the requested remix controls:<br/>
        /// style references (ad hoc or saved), a color palette, style codes, a<br/>
        /// style preset, and a non-`AUTO` style type each<br/>
        /// restrict the request to a compatible model and to the 1K tier;<br/>
        /// remixes without those controls use the default model. Omit<br/>
        /// `resolution` and `aspect_ratio` to keep the source image's shape.<br/>
        /// Supplying `image_weight` together with a `resolution` or<br/>
        /// `aspect_ratio` that changes the source's aspect ratio routes the<br/>
        /// request to a model that crops the source to the new shape; that<br/>
        /// combination is served only at the 1K tier and is rejected at 2K.<br/>
        /// (The model-pinned remix endpoints such as<br/>
        /// `/v2/image/remix/ideogram-v4` reject the combination outright.)<br/>
        /// `seed` is honored only on the compatible model; the default model<br/>
        /// synthesizes an unseeded instruction prompt, so results are not<br/>
        /// reproducible there.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately after the<br/>
        /// request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ToolRemixResponse>> PostToolRemixAsResponseAsync(

            global::Ideogram.ToolRemixRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remix an existing image, letting the server pick the best model<br/>
        /// Transform an existing image with a server-selected model, guided by a<br/>
        /// text prompt. Supply the source as `image` bytes (multipart requests<br/>
        /// only). `image_weight` controls how closely the result follows the<br/>
        /// source; when omitted the selected model chooses its usual strength.<br/>
        /// The server chooses a model that supports the requested remix controls:<br/>
        /// style references (ad hoc or saved), a color palette, style codes, a<br/>
        /// style preset, and a non-`AUTO` style type each<br/>
        /// restrict the request to a compatible model and to the 1K tier;<br/>
        /// remixes without those controls use the default model. Omit<br/>
        /// `resolution` and `aspect_ratio` to keep the source image's shape.<br/>
        /// Supplying `image_weight` together with a `resolution` or<br/>
        /// `aspect_ratio` that changes the source's aspect ratio routes the<br/>
        /// request to a model that crops the source to the new shape; that<br/>
        /// combination is served only at the 1K tier and is rejected at 2K.<br/>
        /// (The model-pinned remix endpoints such as<br/>
        /// `/v2/image/remix/ideogram-v4` reject the combination outright.)<br/>
        /// `seed` is honored only on the compatible model; the default model<br/>
        /// synthesizes an unseeded instruction prompt, so results are not<br/>
        /// reproducible there.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately after the<br/>
        /// request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The prompt that guides the remix.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// The existing upload or generated image to transform. Supply this or `image`, never both. Omit `resolution` and `aspect_ratio` to keep its shape.
        /// </param>
        /// <param name="image">
        /// The image to transform (max size 50MB), as raw bytes; only JPEG, PNG and WEBP are supported. Multipart requests only. Supply this or `image_asset_identifier`, never both. The bytes are staged for this generation request and are not added to your account's image assets.
        /// </param>
        /// <param name="imagename">
        /// The image to transform (max size 50MB), as raw bytes; only JPEG, PNG and WEBP are supported. Multipart requests only. Supply this or `image_asset_identifier`, never both. The bytes are staged for this generation request and are not added to your account's image assets.
        /// </param>
        /// <param name="imageWeight">
        /// Optional. How closely the result should follow the source image, from 1 to 100. When omitted the selected model chooses its usual strength. Combining a weight with a `resolution` or `aspect_ratio` that changes the source's aspect ratio requires the 1K tier.
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to exclude from the images. Descriptions in the prompt take precedence over descriptions in the negative prompt. Not every model consults it.
        /// </param>
        /// <param name="resolution">
        /// The requested output resolution, formatted as "WIDTHxHEIGHT" (for example "1280x800"). The output is served at the closest resolution the selected model supports in the corresponding 1K or 2K tier. Omit `aspect_ratio` when supplying a resolution. If `resolution_tier` is also supplied, it must match the tier implied by these dimensions. Combining a shape-changing value with `image_weight` requires the 1K tier.
        /// </param>
        /// <param name="aspectRatio">
        /// The requested output aspect ratio. Omit it to keep the source image's shape. `AUTO` also keeps the source shape. Omit `resolution` when supplying a concrete value. Combining a shape-changing value with `image_weight` requires the 1K tier.
        /// </param>
        /// <param name="resolutionTier">
        /// The output resolution tier. Influences which model serves the request. When omitted, the tier is inferred from `resolution`, or defaults to 1K when no exact resolution is supplied. Inputs that restrict the server's model choice (style references, saved styles, a color palette, style codes, a style preset, or a non-`AUTO` style type) currently support only 1K AUTO remixes.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `AUTO`. The selected model decides how to interpret it.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="seed">
        /// Optional. Honored when the server selects the model that supports deterministic remixes; the default model synthesizes its own prompt, so results are not reproducible there. The response reports the seed used.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="styleReferenceAssetIdentifiers">
        /// Existing upload or generated image assets whose style should guide the remix, by reference. Supplying style references restricts the server to a model that supports them and requires the 1K resolution tier. Ignored if `style_reference_collection_id` is also supplied.
        /// </param>
        /// <param name="styleReferenceCollectionId">
        /// A saved style to apply, by its URL-safe base64 collection id. Takes priority over `style_reference_asset_identifiers`. Restricts the server to a model that supports style references and requires the 1K resolution tier.
        /// </param>
        /// <param name="styleReferenceCollectionVersionId">
        /// Optional URL-safe base64 version id pinning a specific version of the `style_reference_collection_id` collection. Ignored without it.
        /// </param>
        /// <param name="stylePreset">
        /// A predefined style preset to apply. Restricts the server to a model that supports it and requires the 1K resolution tier. Cannot be combined with style codes or style references.
        /// </param>
        /// <param name="colorPalette">
        /// A color palette to apply. Restricts the server to a model that supports palettes and requires the 1K resolution tier.
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.<br/>
        /// Example: [AAFF5733, 0133FF57, DE3357FF]
        /// </param>
        /// <param name="styleType">
        /// The style type to generate with. A value other than `AUTO` restricts the server to a model that supports it and requires the 1K resolution tier.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images come back with `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request blocks until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v1/generations/{generation_id}` using the returned `generation_id`.<br/>
        /// Default Value: false
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
        /// <param name="private">
        /// Whether the generated images should be kept private. Omitted or true keeps them private. False publishes them unless the caller's plan always generates privately.
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. The output images are added to it when the request completes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ToolRemixResponse> PostToolRemixAsync(
            string prompt,
            bool? dryRun = default,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            int? imageWeight = default,
            string? negativePrompt = default,
            string? resolution = default,
            global::Ideogram.AspectRatioV4? aspectRatio = default,
            global::Ideogram.ToolRemixRequestResolutionTier? resolutionTier = default,
            global::Ideogram.MagicPromptOption? magicPrompt = default,
            int? seed = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? styleReferenceAssetIdentifiers = default,
            string? styleReferenceCollectionId = default,
            string? styleReferenceCollectionVersionId = default,
            global::Ideogram.StylePresetV3? stylePreset = default,
            global::Ideogram.ColorPaletteWithPresetNameOrMembers? colorPalette = default,
            global::System.Collections.Generic.IList<string>? styleCodes = default,
            global::Ideogram.StyleTypeV3? styleType = default,
            int? numImages = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            string? webhookUrl = default,
            bool? @private = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
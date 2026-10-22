#nullable enable

namespace Ideogram.V2
{
    public partial interface IIdeogramV2Client
    {
        /// <summary>
        /// Precise edit with Ideogram 4.5<br/>
        /// Edit an image with Ideogram 4.5 and get the result back at that image's<br/>
        /// exact width and height. Upload the image as `image` using<br/>
        /// `multipart/form-data`, with optional `reference_images` and a `mask`.<br/>
        /// Returns results directly by default; set `async` or supply a<br/>
        /// `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.<br/>
        /// Editing the whole image is bounded by 4194304 pixels (the area of a<br/>
        /// 2048x2048 square), so a larger image comes back scaled down to fit: an<br/>
        /// 8192x8192 image returns as 2048x2048.<br/>
        /// To edit a 4K or 8K image at its full resolution, set `context_window`<br/>
        /// to confine the edit to one region, either `auto` together with a<br/>
        /// `mask`, or `y_min,x_min,y_max,x_max` to name the region yourself. Only<br/>
        /// that region changes, the rest of the image comes back unchanged, and<br/>
        /// the result keeps the image's own width and height at any input size.<br/>
        /// ```bash<br/>
        /// curl -X POST https://api.ideogram.ai/v2/image/precise-edit/ideogram-4-5 \<br/>
        ///   -H "Api-Key: $IDEOGRAM_API_KEY" \<br/>
        ///   -F image=@photo_8k.png \<br/>
        ///   -F mask=@mask_8k.png \<br/>
        ///   -F context_window=auto \<br/>
        ///   -F prompt="Add round black sunglasses."<br/>
        /// ```
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.PreciseEditImageIdeogram45Response> CreateImagePreciseEditIdeogram45Async(

            global::Ideogram.V2.ImagesPreciseEditPostPreciseEditImageV2Ideogram45Request request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Precise edit with Ideogram 4.5<br/>
        /// Edit an image with Ideogram 4.5 and get the result back at that image's<br/>
        /// exact width and height. Upload the image as `image` using<br/>
        /// `multipart/form-data`, with optional `reference_images` and a `mask`.<br/>
        /// Returns results directly by default; set `async` or supply a<br/>
        /// `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.<br/>
        /// Editing the whole image is bounded by 4194304 pixels (the area of a<br/>
        /// 2048x2048 square), so a larger image comes back scaled down to fit: an<br/>
        /// 8192x8192 image returns as 2048x2048.<br/>
        /// To edit a 4K or 8K image at its full resolution, set `context_window`<br/>
        /// to confine the edit to one region, either `auto` together with a<br/>
        /// `mask`, or `y_min,x_min,y_max,x_max` to name the region yourself. Only<br/>
        /// that region changes, the rest of the image comes back unchanged, and<br/>
        /// the result keeps the image's own width and height at any input size.<br/>
        /// ```bash<br/>
        /// curl -X POST https://api.ideogram.ai/v2/image/precise-edit/ideogram-4-5 \<br/>
        ///   -H "Api-Key: $IDEOGRAM_API_KEY" \<br/>
        ///   -F image=@photo_8k.png \<br/>
        ///   -F mask=@mask_8k.png \<br/>
        ///   -F context_window=auto \<br/>
        ///   -F prompt="Add round black sunglasses."<br/>
        /// ```
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.PreciseEditImageIdeogram45Response>> CreateImagePreciseEditIdeogram45AsResponseAsync(

            global::Ideogram.V2.ImagesPreciseEditPostPreciseEditImageV2Ideogram45Request request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Precise edit with Ideogram 4.5<br/>
        /// Edit an image with Ideogram 4.5 and get the result back at that image's<br/>
        /// exact width and height. Upload the image as `image` using<br/>
        /// `multipart/form-data`, with optional `reference_images` and a `mask`.<br/>
        /// Returns results directly by default; set `async` or supply a<br/>
        /// `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.<br/>
        /// Editing the whole image is bounded by 4194304 pixels (the area of a<br/>
        /// 2048x2048 square), so a larger image comes back scaled down to fit: an<br/>
        /// 8192x8192 image returns as 2048x2048.<br/>
        /// To edit a 4K or 8K image at its full resolution, set `context_window`<br/>
        /// to confine the edit to one region, either `auto` together with a<br/>
        /// `mask`, or `y_min,x_min,y_max,x_max` to name the region yourself. Only<br/>
        /// that region changes, the rest of the image comes back unchanged, and<br/>
        /// the result keeps the image's own width and height at any input size.<br/>
        /// ```bash<br/>
        /// curl -X POST https://api.ideogram.ai/v2/image/precise-edit/ideogram-4-5 \<br/>
        ///   -H "Api-Key: $IDEOGRAM_API_KEY" \<br/>
        ///   -F image=@photo_8k.png \<br/>
        ///   -F mask=@mask_8k.png \<br/>
        ///   -F context_window=auto \<br/>
        ///   -F prompt="Add round black sunglasses."<br/>
        /// ```
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The edit instruction, in natural language or as a structured JSON<br/>
        /// prompt. Natural language is automatically converted into a<br/>
        /// structured prompt; valid structured JSON is used as is.
        /// </param>
        /// <param name="image">
        /// The image to edit, as raw bytes (max 50MB and 67108864 pixels, which 8192x8192 meets exactly; JPEG, PNG, or WEBP). Multipart requests only, and ignored when the same image is also supplied by reference. The output always matches this image's width and height, and pixels the edit did not meaningfully change are copied exactly from it. Set `context_window` to keep the full resolution of an image over 4194304 pixels.
        /// </param>
        /// <param name="imagename">
        /// The image to edit, as raw bytes (max 50MB and 67108864 pixels, which 8192x8192 meets exactly; JPEG, PNG, or WEBP). Multipart requests only, and ignored when the same image is also supplied by reference. The output always matches this image's width and height, and pixels the edit did not meaningfully change are copied exactly from it. Set `context_window` to keep the full resolution of an image over 4194304 pixels.
        /// </param>
        /// <param name="referenceImages">
        /// Optional images to guide the edit (max 4, max 50MB each; JPEG, PNG, or WEBP). They are never edited themselves; only `image` is. Multipart requests only, and ignored when the same references are also supplied by reference. A request with a `mask` can include at most three, because the mask takes up one reference slot.
        /// </param>
        /// <param name="mask">
        /// An optional mask that limits the edit to part of `image` (max 50MB; JPEG, PNG, or WEBP). Multipart requests only. Black marks the area to edit and white the area to keep; values in between are rounded to the nearer of the two. The mask must have the same width and height as the image being edited and contain both black and white areas. A masked request can include at most three reference images.
        /// </param>
        /// <param name="maskname">
        /// An optional mask that limits the edit to part of `image` (max 50MB; JPEG, PNG, or WEBP). Multipart requests only. Black marks the area to edit and white the area to keep; values in between are rounded to the nearer of the two. The mask must have the same width and height as the image being edited and contain both black and white areas. A masked request can include at most three reference images.
        /// </param>
        /// <param name="contextWindow">
        /// Which region of the image to edit. Set this to keep the full resolution of an image larger than 4194304 pixels.<br/>
        /// `none`, the default, edits the whole image, which is bounded by 4194304 pixels (the area of a 2048x2048 square); a larger image comes back scaled down to fit. For example, an 8192x8192 image returns as 2048x2048.<br/>
        /// `auto` requires a `mask` and fits a region around the masked area. If the mask selects more than 4194304 pixels no region fits it, and the request falls back to editing the whole image, scaled down as above.<br/>
        /// `y_min,x_min,y_max,x_max` names the region explicitly, by its corners. Rows come first, matching the `bbox` ordering used elsewhere in this API, and the values are the edited image's own pixels with the origin at its top-left corner. For example `512,1024,2048,3072` is the region 2048 pixels wide and 1536 tall whose top-left corner is 1024 across and 512 down. The maximum edges are exclusive, so the region measures `x_max - x_min` by `y_max - y_min`. It must lie inside the image, measure at least 256px on each side, have an aspect ratio between 1:6 and 6:1, and cover no more than 4194304 pixels. A `mask` may select only pixels inside it.<br/>
        /// With `auto` or an explicit region, only that region changes, the rest of the image comes back unchanged, and the output keeps the image's own width and height at any input size.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="quality">
        /// The rendering quality to use. `very_low` is the fastest and cheapest, and `high` takes longer and is priced higher. This is the only field that affects the price: the size of the image you send does not change it, and neither does `context_window`.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Run copyright detection on the generated images. Adds latency; flagged images are returned with `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request waits until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll `GET /v2/generations/{generation_id}` with the returned `generation_id` for the result.<br/>
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
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.PreciseEditImageIdeogram45Response> CreateImagePreciseEditIdeogram45Async(
            string prompt,
            byte[] image,
            string imagename,
            bool? dryRun = default,
            global::System.Collections.Generic.IList<byte[]>? referenceImages = default,
            byte[]? mask = default,
            string? maskname = default,
            string? contextWindow = default,
            global::Ideogram.V2.V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality? quality = default,
            int? seed = default,
            int? numImages = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Precise edit with Ideogram 4.5<br/>
        /// Edit an image with Ideogram 4.5 and get the result back at that image's<br/>
        /// exact width and height. Upload the image as `image` using<br/>
        /// `multipart/form-data`, with optional `reference_images` and a `mask`.<br/>
        /// Returns results directly by default; set `async` or supply a<br/>
        /// `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.<br/>
        /// Editing the whole image is bounded by 4194304 pixels (the area of a<br/>
        /// 2048x2048 square), so a larger image comes back scaled down to fit: an<br/>
        /// 8192x8192 image returns as 2048x2048.<br/>
        /// To edit a 4K or 8K image at its full resolution, set `context_window`<br/>
        /// to confine the edit to one region, either `auto` together with a<br/>
        /// `mask`, or `y_min,x_min,y_max,x_max` to name the region yourself. Only<br/>
        /// that region changes, the rest of the image comes back unchanged, and<br/>
        /// the result keeps the image's own width and height at any input size.<br/>
        /// ```bash<br/>
        /// curl -X POST https://api.ideogram.ai/v2/image/precise-edit/ideogram-4-5 \<br/>
        ///   -H "Api-Key: $IDEOGRAM_API_KEY" \<br/>
        ///   -F image=@photo_8k.png \<br/>
        ///   -F mask=@mask_8k.png \<br/>
        ///   -F context_window=auto \<br/>
        ///   -F prompt="Add round black sunglasses."<br/>
        /// ```
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The edit instruction, in natural language or as a structured JSON<br/>
        /// prompt. Natural language is automatically converted into a<br/>
        /// structured prompt; valid structured JSON is used as is.
        /// </param>
        /// <param name="image">
        /// The image to edit, as raw bytes (max 50MB and 67108864 pixels, which 8192x8192 meets exactly; JPEG, PNG, or WEBP). Multipart requests only, and ignored when the same image is also supplied by reference. The output always matches this image's width and height, and pixels the edit did not meaningfully change are copied exactly from it. Set `context_window` to keep the full resolution of an image over 4194304 pixels.
        /// </param>
        /// <param name="imagename">
        /// The image to edit, as raw bytes (max 50MB and 67108864 pixels, which 8192x8192 meets exactly; JPEG, PNG, or WEBP). Multipart requests only, and ignored when the same image is also supplied by reference. The output always matches this image's width and height, and pixels the edit did not meaningfully change are copied exactly from it. Set `context_window` to keep the full resolution of an image over 4194304 pixels.
        /// </param>
        /// <param name="referenceImages">
        /// Optional images to guide the edit (max 4, max 50MB each; JPEG, PNG, or WEBP). They are never edited themselves; only `image` is. Multipart requests only, and ignored when the same references are also supplied by reference. A request with a `mask` can include at most three, because the mask takes up one reference slot.
        /// </param>
        /// <param name="referenceImagesFileNames">
        /// Optional file names to use for the multipart 'reference_images' file parts.
        /// </param>
        /// <param name="mask">
        /// An optional mask that limits the edit to part of `image` (max 50MB; JPEG, PNG, or WEBP). Multipart requests only. Black marks the area to edit and white the area to keep; values in between are rounded to the nearer of the two. The mask must have the same width and height as the image being edited and contain both black and white areas. A masked request can include at most three reference images.
        /// </param>
        /// <param name="maskname">
        /// An optional mask that limits the edit to part of `image` (max 50MB; JPEG, PNG, or WEBP). Multipart requests only. Black marks the area to edit and white the area to keep; values in between are rounded to the nearer of the two. The mask must have the same width and height as the image being edited and contain both black and white areas. A masked request can include at most three reference images.
        /// </param>
        /// <param name="contextWindow">
        /// Which region of the image to edit. Set this to keep the full resolution of an image larger than 4194304 pixels.<br/>
        /// `none`, the default, edits the whole image, which is bounded by 4194304 pixels (the area of a 2048x2048 square); a larger image comes back scaled down to fit. For example, an 8192x8192 image returns as 2048x2048.<br/>
        /// `auto` requires a `mask` and fits a region around the masked area. If the mask selects more than 4194304 pixels no region fits it, and the request falls back to editing the whole image, scaled down as above.<br/>
        /// `y_min,x_min,y_max,x_max` names the region explicitly, by its corners. Rows come first, matching the `bbox` ordering used elsewhere in this API, and the values are the edited image's own pixels with the origin at its top-left corner. For example `512,1024,2048,3072` is the region 2048 pixels wide and 1536 tall whose top-left corner is 1024 across and 512 down. The maximum edges are exclusive, so the region measures `x_max - x_min` by `y_max - y_min`. It must lie inside the image, measure at least 256px on each side, have an aspect ratio between 1:6 and 6:1, and cover no more than 4194304 pixels. A `mask` may select only pixels inside it.<br/>
        /// With `auto` or an explicit region, only that region changes, the rest of the image comes back unchanged, and the output keeps the image's own width and height at any input size.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="quality">
        /// The rendering quality to use. `very_low` is the fastest and cheapest, and `high` takes longer and is priced higher. This is the only field that affects the price: the size of the image you send does not change it, and neither does `context_window`.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Run copyright detection on the generated images. Adds latency; flagged images are returned with `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request waits until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll `GET /v2/generations/{generation_id}` with the returned `generation_id` for the result.<br/>
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
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.PreciseEditImageIdeogram45Response> CreateImagePreciseEditIdeogram45Async(
            string prompt,
            global::System.IO.Stream image,
            string imagename,
            bool? dryRun = default,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? referenceImages = default,
            global::System.Collections.Generic.IReadOnlyList<string>? referenceImagesFileNames = default,
            global::System.IO.Stream? mask = default,
            string? maskname = default,
            string? contextWindow = default,
            global::Ideogram.V2.V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality? quality = default,
            int? seed = default,
            int? numImages = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Precise edit with Ideogram 4.5<br/>
        /// Edit an image with Ideogram 4.5 and get the result back at that image's<br/>
        /// exact width and height. Upload the image as `image` using<br/>
        /// `multipart/form-data`, with optional `reference_images` and a `mask`.<br/>
        /// Returns results directly by default; set `async` or supply a<br/>
        /// `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.<br/>
        /// Editing the whole image is bounded by 4194304 pixels (the area of a<br/>
        /// 2048x2048 square), so a larger image comes back scaled down to fit: an<br/>
        /// 8192x8192 image returns as 2048x2048.<br/>
        /// To edit a 4K or 8K image at its full resolution, set `context_window`<br/>
        /// to confine the edit to one region, either `auto` together with a<br/>
        /// `mask`, or `y_min,x_min,y_max,x_max` to name the region yourself. Only<br/>
        /// that region changes, the rest of the image comes back unchanged, and<br/>
        /// the result keeps the image's own width and height at any input size.<br/>
        /// ```bash<br/>
        /// curl -X POST https://api.ideogram.ai/v2/image/precise-edit/ideogram-4-5 \<br/>
        ///   -H "Api-Key: $IDEOGRAM_API_KEY" \<br/>
        ///   -F image=@photo_8k.png \<br/>
        ///   -F mask=@mask_8k.png \<br/>
        ///   -F context_window=auto \<br/>
        ///   -F prompt="Add round black sunglasses."<br/>
        /// ```
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The edit instruction, in natural language or as a structured JSON<br/>
        /// prompt. Natural language is automatically converted into a<br/>
        /// structured prompt; valid structured JSON is used as is.
        /// </param>
        /// <param name="image">
        /// The image to edit, as raw bytes (max 50MB and 67108864 pixels, which 8192x8192 meets exactly; JPEG, PNG, or WEBP). Multipart requests only, and ignored when the same image is also supplied by reference. The output always matches this image's width and height, and pixels the edit did not meaningfully change are copied exactly from it. Set `context_window` to keep the full resolution of an image over 4194304 pixels.
        /// </param>
        /// <param name="imagename">
        /// The image to edit, as raw bytes (max 50MB and 67108864 pixels, which 8192x8192 meets exactly; JPEG, PNG, or WEBP). Multipart requests only, and ignored when the same image is also supplied by reference. The output always matches this image's width and height, and pixels the edit did not meaningfully change are copied exactly from it. Set `context_window` to keep the full resolution of an image over 4194304 pixels.
        /// </param>
        /// <param name="referenceImages">
        /// Optional images to guide the edit (max 4, max 50MB each; JPEG, PNG, or WEBP). They are never edited themselves; only `image` is. Multipart requests only, and ignored when the same references are also supplied by reference. A request with a `mask` can include at most three, because the mask takes up one reference slot.
        /// </param>
        /// <param name="referenceImagesFileNames">
        /// Optional file names to use for the multipart 'reference_images' file parts.
        /// </param>
        /// <param name="mask">
        /// An optional mask that limits the edit to part of `image` (max 50MB; JPEG, PNG, or WEBP). Multipart requests only. Black marks the area to edit and white the area to keep; values in between are rounded to the nearer of the two. The mask must have the same width and height as the image being edited and contain both black and white areas. A masked request can include at most three reference images.
        /// </param>
        /// <param name="maskname">
        /// An optional mask that limits the edit to part of `image` (max 50MB; JPEG, PNG, or WEBP). Multipart requests only. Black marks the area to edit and white the area to keep; values in between are rounded to the nearer of the two. The mask must have the same width and height as the image being edited and contain both black and white areas. A masked request can include at most three reference images.
        /// </param>
        /// <param name="contextWindow">
        /// Which region of the image to edit. Set this to keep the full resolution of an image larger than 4194304 pixels.<br/>
        /// `none`, the default, edits the whole image, which is bounded by 4194304 pixels (the area of a 2048x2048 square); a larger image comes back scaled down to fit. For example, an 8192x8192 image returns as 2048x2048.<br/>
        /// `auto` requires a `mask` and fits a region around the masked area. If the mask selects more than 4194304 pixels no region fits it, and the request falls back to editing the whole image, scaled down as above.<br/>
        /// `y_min,x_min,y_max,x_max` names the region explicitly, by its corners. Rows come first, matching the `bbox` ordering used elsewhere in this API, and the values are the edited image's own pixels with the origin at its top-left corner. For example `512,1024,2048,3072` is the region 2048 pixels wide and 1536 tall whose top-left corner is 1024 across and 512 down. The maximum edges are exclusive, so the region measures `x_max - x_min` by `y_max - y_min`. It must lie inside the image, measure at least 256px on each side, have an aspect ratio between 1:6 and 6:1, and cover no more than 4194304 pixels. A `mask` may select only pixels inside it.<br/>
        /// With `auto` or an explicit region, only that region changes, the rest of the image comes back unchanged, and the output keeps the image's own width and height at any input size.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="quality">
        /// The rendering quality to use. `very_low` is the fastest and cheapest, and `high` takes longer and is priced higher. This is the only field that affects the price: the size of the image you send does not change it, and neither does `context_window`.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Run copyright detection on the generated images. Adds latency; flagged images are returned with `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request waits until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll `GET /v2/generations/{generation_id}` with the returned `generation_id` for the result.<br/>
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
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.PreciseEditImageIdeogram45Response>> CreateImagePreciseEditIdeogram45AsResponseAsync(
            string prompt,
            global::System.IO.Stream image,
            string imagename,
            bool? dryRun = default,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? referenceImages = default,
            global::System.Collections.Generic.IReadOnlyList<string>? referenceImagesFileNames = default,
            global::System.IO.Stream? mask = default,
            string? maskname = default,
            string? contextWindow = default,
            global::Ideogram.V2.V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality? quality = default,
            int? seed = default,
            int? numImages = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
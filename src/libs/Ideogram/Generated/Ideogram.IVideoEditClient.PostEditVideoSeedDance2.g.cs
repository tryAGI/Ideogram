#nullable enable

namespace Ideogram
{
    public partial interface IVideoEditClient
    {
        /// <summary>
        /// Edit a video with Seedance 2.0 by regenerating from frames of it<br/>
        /// Edit a video you already have stored with Ideogram by replacing part of<br/>
        /// it. Reference the source video with `video_asset_identifier` and mark the<br/>
        /// span to replace with `start_frame_time` and `end_frame_time`, in seconds.<br/>
        /// Seedance 2.0 generates a new clip for that span from your prompt, and the<br/>
        /// result is the source video with the generated clip spliced in over the<br/>
        /// span: everything before `start_frame_time`, then the generated clip, then<br/>
        /// everything from `end_frame_time` on. That edited video is the asset the<br/>
        /// request produces.<br/>
        /// `is_start_frame_included` and `is_end_frame_included` anchor the generated<br/>
        /// clip on the span's own end frames, so it joins the surrounding footage<br/>
        /// instead of cutting to something unrelated. Anchoring the start opens the<br/>
        /// clip on the frame already at `start_frame_time`; anchoring the end lands<br/>
        /// it on the frame at `end_frame_time`; anchoring both joins at each seam. At<br/>
        /// least one must be anchored.<br/>
        /// The generated clip is used at its own length, which the model rarely makes<br/>
        /// exactly the span's, so the edited video is usually a different length from<br/>
        /// the source. Request a `duration` close to the span to keep them near each<br/>
        /// other. The clip is scaled and cropped to fill the source's frame and<br/>
        /// conformed to its frame rate, so resolution and aspect ratio follow the<br/>
        /// source rather than being requested.<br/>
        /// Video generation always runs asynchronously: the response returns as<br/>
        /// soon as the request is accepted and carries only a `generation_id`.<br/>
        /// Poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using that id, or supply a<br/>
        /// `webhook_url` to have the finished result POSTed to your server<br/>
        /// instead.<br/>
        /// Video links are available for a limited period of time; download the<br/>
        /// video if you want to keep it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateVideoSeedDance2Response> PostEditVideoSeedDance2Async(

            global::Ideogram.EditVideoSeedDance2Request request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit a video with Seedance 2.0 by regenerating from frames of it<br/>
        /// Edit a video you already have stored with Ideogram by replacing part of<br/>
        /// it. Reference the source video with `video_asset_identifier` and mark the<br/>
        /// span to replace with `start_frame_time` and `end_frame_time`, in seconds.<br/>
        /// Seedance 2.0 generates a new clip for that span from your prompt, and the<br/>
        /// result is the source video with the generated clip spliced in over the<br/>
        /// span: everything before `start_frame_time`, then the generated clip, then<br/>
        /// everything from `end_frame_time` on. That edited video is the asset the<br/>
        /// request produces.<br/>
        /// `is_start_frame_included` and `is_end_frame_included` anchor the generated<br/>
        /// clip on the span's own end frames, so it joins the surrounding footage<br/>
        /// instead of cutting to something unrelated. Anchoring the start opens the<br/>
        /// clip on the frame already at `start_frame_time`; anchoring the end lands<br/>
        /// it on the frame at `end_frame_time`; anchoring both joins at each seam. At<br/>
        /// least one must be anchored.<br/>
        /// The generated clip is used at its own length, which the model rarely makes<br/>
        /// exactly the span's, so the edited video is usually a different length from<br/>
        /// the source. Request a `duration` close to the span to keep them near each<br/>
        /// other. The clip is scaled and cropped to fill the source's frame and<br/>
        /// conformed to its frame rate, so resolution and aspect ratio follow the<br/>
        /// source rather than being requested.<br/>
        /// Video generation always runs asynchronously: the response returns as<br/>
        /// soon as the request is accepted and carries only a `generation_id`.<br/>
        /// Poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using that id, or supply a<br/>
        /// `webhook_url` to have the finished result POSTed to your server<br/>
        /// instead.<br/>
        /// Video links are available for a limited period of time; download the<br/>
        /// video if you want to keep it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateVideoSeedDance2Response>> PostEditVideoSeedDance2AsResponseAsync(

            global::Ideogram.EditVideoSeedDance2Request request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit a video with Seedance 2.0 by regenerating from frames of it<br/>
        /// Edit a video you already have stored with Ideogram by replacing part of<br/>
        /// it. Reference the source video with `video_asset_identifier` and mark the<br/>
        /// span to replace with `start_frame_time` and `end_frame_time`, in seconds.<br/>
        /// Seedance 2.0 generates a new clip for that span from your prompt, and the<br/>
        /// result is the source video with the generated clip spliced in over the<br/>
        /// span: everything before `start_frame_time`, then the generated clip, then<br/>
        /// everything from `end_frame_time` on. That edited video is the asset the<br/>
        /// request produces.<br/>
        /// `is_start_frame_included` and `is_end_frame_included` anchor the generated<br/>
        /// clip on the span's own end frames, so it joins the surrounding footage<br/>
        /// instead of cutting to something unrelated. Anchoring the start opens the<br/>
        /// clip on the frame already at `start_frame_time`; anchoring the end lands<br/>
        /// it on the frame at `end_frame_time`; anchoring both joins at each seam. At<br/>
        /// least one must be anchored.<br/>
        /// The generated clip is used at its own length, which the model rarely makes<br/>
        /// exactly the span's, so the edited video is usually a different length from<br/>
        /// the source. Request a `duration` close to the span to keep them near each<br/>
        /// other. The clip is scaled and cropped to fill the source's frame and<br/>
        /// conformed to its frame rate, so resolution and aspect ratio follow the<br/>
        /// source rather than being requested.<br/>
        /// Video generation always runs asynchronously: the response returns as<br/>
        /// soon as the request is accepted and carries only a `generation_id`.<br/>
        /// Poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using that id, or supply a<br/>
        /// `webhook_url` to have the finished result POSTed to your server<br/>
        /// instead.<br/>
        /// Video links are available for a limited period of time; download the<br/>
        /// video if you want to keep it.
        /// </summary>
        /// <param name="videoAssetIdentifier">
        /// A reference to a video already stored with Ideogram to take the frames from. Only video assets are accepted.
        /// </param>
        /// <param name="startFrameTime">
        /// Where the replaced span of the source video begins. Everything before it is kept as-is.
        /// </param>
        /// <param name="isStartFrameIncluded">
        /// Whether the generated clip is anchored on the frame already at `start_frame_time`, so it opens on the footage it replaces. Set it to false to anchor on the end frame alone, in which case `is_end_frame_included` must be true.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="endFrameTime">
        /// Where the replaced span of the source video ends; must come after `start_frame_time`. Everything from here on is kept as-is.
        /// </param>
        /// <param name="isEndFrameIncluded">
        /// Whether the generated clip is anchored on the frame at `end_frame_time`, so it lands on the footage that follows the span.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// A natural-language prompt describing what the replaced span should show.<br/>
        /// Example: The camera pushes in as the dancer turns towards the light.
        /// </param>
        /// <param name="resolution">
        /// The resolution tier the replaced span is generated at. The clip is then scaled to the source video's own frame, so this affects the detail generated rather than the edited video's dimensions.
        /// </param>
        /// <param name="duration">
        /// The length of the generated video in seconds. When omitted, the model<br/>
        /// picks the best duration for the prompt ("auto").<br/>
        /// Example: 5
        /// </param>
        /// <param name="generateAudio">
        /// Whether to generate an audio track for the video. Audio roughly<br/>
        /// doubles the provider cost and is subject to stricter output moderation.<br/>
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
        /// When true or omitted, the output is kept private to your account. Set to false to publish the output to the public feed. Enterprise accounts always generate privately.
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. The output videos are added to it when the request completes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateVideoSeedDance2Response> PostEditVideoSeedDance2Async(
            global::Ideogram.AssetIdentifier videoAssetIdentifier,
            float startFrameTime,
            float endFrameTime,
            string prompt,
            bool? isStartFrameIncluded = default,
            bool? isEndFrameIncluded = default,
            global::Ideogram.SeedDance2Resolution? resolution = default,
            int? duration = default,
            bool? generateAudio = default,
            string? webhookUrl = default,
            bool? @private = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
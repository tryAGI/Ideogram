#nullable enable

namespace Ideogram
{
    public partial interface IMiniAppsClient
    {
        /// <summary>
        /// Publish a mini-app preview entry<br/>
        /// Publishes a mini-app preview entry. Called by the mini-apps preview deploy pipeline to register a throwaway preview deploy, keyed by its unique preview id. Re-publishing an existing preview id refreshes every deploy-managed field. Preview entries are independent from the main catalog: they carry no slug, owner, or membership gating, and anyone with the preview link can access the app.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.PublishMiniAppPreviewResponse> PublishPreviewMiniAppAsync(

            global::Ideogram.PublishMiniAppPreviewRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish a mini-app preview entry<br/>
        /// Publishes a mini-app preview entry. Called by the mini-apps preview deploy pipeline to register a throwaway preview deploy, keyed by its unique preview id. Re-publishing an existing preview id refreshes every deploy-managed field. Preview entries are independent from the main catalog: they carry no slug, owner, or membership gating, and anyone with the preview link can access the app.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.PublishMiniAppPreviewResponse>> PublishPreviewMiniAppAsResponseAsync(

            global::Ideogram.PublishMiniAppPreviewRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish a mini-app preview entry<br/>
        /// Publishes a mini-app preview entry. Called by the mini-apps preview deploy pipeline to register a throwaway preview deploy, keyed by its unique preview id. Re-publishing an existing preview id refreshes every deploy-managed field. Preview entries are independent from the main catalog: they carry no slug, owner, or membership gating, and anyone with the preview link can access the app.
        /// </summary>
        /// <param name="previewId">
        /// Unique, URL-safe preview identifier composed by the deploy pipeline.
        /// </param>
        /// <param name="slug">
        /// Unique, stable, URL-safe mini-app identifier.
        /// </param>
        /// <param name="label">
        /// Human-readable display name shown for the preview.
        /// </param>
        /// <param name="description">
        /// Short description of what the mini-app does.
        /// </param>
        /// <param name="embed">
        /// How the mini-app is embedded. `iframe` loads the app in a sandboxed frame; `mfe` loads it as a micro-frontend module.
        /// </param>
        /// <param name="scopes">
        /// Permission scopes the mini-app preview requests.
        /// </param>
        /// <param name="acceptsImageInput">
        /// Optional on publish. Whether the app can receive an existing image as its initial input. Omit this field to preserve the current value when re-publishing an existing preview; new previews default to false.
        /// </param>
        /// <param name="deploymentUrl">
        /// URL where the preview mini-app is served. Must be an `https://*.run.app` Cloud Run URL.
        /// </param>
        /// <param name="deploymentCommit">
        /// Source commit hash of the deployed build.
        /// </param>
        /// <param name="deploymentTime">
        /// When the deployment that produced this build completed.
        /// </param>
        /// <param name="website">
        /// Structured website metadata for the mini-app.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.PublishMiniAppPreviewResponse> PublishPreviewMiniAppAsync(
            string previewId,
            string label,
            global::Ideogram.PublishMiniAppPreviewRequestEmbed embed,
            global::System.Collections.Generic.IList<string> scopes,
            string deploymentUrl,
            string? slug = default,
            string? description = default,
            bool? acceptsImageInput = default,
            string? deploymentCommit = default,
            global::System.DateTime? deploymentTime = default,
            object? website = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Ideogram
{
    public partial interface IMiniAppsClient
    {
        /// <summary>
        /// Publish a mini-app catalog entry<br/>
        /// Publishes a mini-app's catalog entry. Called by the mini-apps deploy pipeline after a deploy to register or refresh a single app, keyed by its unique slug. Re-publishing an existing app refreshes the deploy-managed fields (label, description, embed mode, scopes, image-input support, deployment details, and website) while leaving administrator-managed settings and artwork untouched. Artwork from the request is used only when creating a new app.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.PublishMiniAppResponse> PublishMiniAppAsync(

            global::Ideogram.PublishMiniAppRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish a mini-app catalog entry<br/>
        /// Publishes a mini-app's catalog entry. Called by the mini-apps deploy pipeline after a deploy to register or refresh a single app, keyed by its unique slug. Re-publishing an existing app refreshes the deploy-managed fields (label, description, embed mode, scopes, image-input support, deployment details, and website) while leaving administrator-managed settings and artwork untouched. Artwork from the request is used only when creating a new app.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.PublishMiniAppResponse>> PublishMiniAppAsResponseAsync(

            global::Ideogram.PublishMiniAppRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish a mini-app catalog entry<br/>
        /// Publishes a mini-app's catalog entry. Called by the mini-apps deploy pipeline after a deploy to register or refresh a single app, keyed by its unique slug. Re-publishing an existing app refreshes the deploy-managed fields (label, description, embed mode, scopes, image-input support, deployment details, and website) while leaving administrator-managed settings and artwork untouched. Artwork from the request is used only when creating a new app.
        /// </summary>
        /// <param name="slug">
        /// Unique, stable, URL-safe mini-app identifier.
        /// </param>
        /// <param name="label">
        /// Human-readable display name shown in the catalog.
        /// </param>
        /// <param name="description">
        /// Short description of what the mini-app does.
        /// </param>
        /// <param name="embed">
        /// How the mini-app is embedded. `iframe` loads the app in a sandboxed frame; `mfe` loads it as a micro-frontend module.
        /// </param>
        /// <param name="scopes">
        /// Permission scopes the mini-app requests.
        /// </param>
        /// <param name="acceptsImageInput">
        /// Optional on publish. Whether the app can receive an existing image as its initial input. Omit this field to preserve the current value when re-publishing an existing app; new apps default to false. Catalog responses always include the resolved boolean.
        /// </param>
        /// <param name="deploymentUrl">
        /// Absolute HTTPS URL where the deployed mini-app is served from.
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
        global::System.Threading.Tasks.Task<global::Ideogram.PublishMiniAppResponse> PublishMiniAppAsync(
            string slug,
            string label,
            global::Ideogram.PublishMiniAppRequestEmbed embed,
            global::System.Collections.Generic.IList<string> scopes,
            string? description = default,
            bool? acceptsImageInput = default,
            string? deploymentUrl = default,
            string? deploymentCommit = default,
            global::System.DateTime? deploymentTime = default,
            object? website = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
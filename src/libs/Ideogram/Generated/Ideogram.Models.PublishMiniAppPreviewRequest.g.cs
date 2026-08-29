
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The mini-app preview entry to publish. Supply `slug` when the preview is a build of a catalog app so that work created through the preview is credited to that app; omit it for a preview of an app that is not in the catalog.<br/>
    /// Example: {"accepts_image_input":true,"deployment_time":"2000-01-23T04:56:07\u002B00:00","website":{"key":""},"preview_id":"preview_id","deployment_url":"deployment_url","deployment_commit":"deployment_commit","description":"description","label":"label","embed":"iframe","scopes":["scopes","scopes"],"slug":"slug"}
    /// </summary>
    public sealed partial class PublishMiniAppPreviewRequest
    {
        /// <summary>
        /// Unique, URL-safe preview identifier composed by the deploy pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviewId { get; set; }

        /// <summary>
        /// Unique, stable, URL-safe mini-app identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Human-readable display name shown for the preview.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Short description of what the mini-app does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// How the mini-app is embedded. `iframe` loads the app in a sandboxed frame; `mfe` loads it as a micro-frontend module.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.PublishMiniAppPreviewRequestEmbedJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.PublishMiniAppPreviewRequestEmbed Embed { get; set; }

        /// <summary>
        /// Permission scopes the mini-app preview requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>
        /// Optional on publish. Whether the app can receive an existing image as its initial input. Omit this field to preserve the current value when re-publishing an existing preview; new previews default to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepts_image_input")]
        public bool? AcceptsImageInput { get; set; }

        /// <summary>
        /// URL where the preview mini-app is served. Must be an `https://*.run.app` Cloud Run URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentUrl { get; set; }

        /// <summary>
        /// Source commit hash of the deployed build.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_commit")]
        public string? DeploymentCommit { get; set; }

        /// <summary>
        /// When the deployment that produced this build completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_time")]
        public global::System.DateTime? DeploymentTime { get; set; }

        /// <summary>
        /// Structured website metadata for the mini-app.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        public object? Website { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishMiniAppPreviewRequest" /> class.
        /// </summary>
        /// <param name="previewId">
        /// Unique, URL-safe preview identifier composed by the deploy pipeline.
        /// </param>
        /// <param name="label">
        /// Human-readable display name shown for the preview.
        /// </param>
        /// <param name="embed">
        /// How the mini-app is embedded. `iframe` loads the app in a sandboxed frame; `mfe` loads it as a micro-frontend module.
        /// </param>
        /// <param name="scopes">
        /// Permission scopes the mini-app preview requests.
        /// </param>
        /// <param name="deploymentUrl">
        /// URL where the preview mini-app is served. Must be an `https://*.run.app` Cloud Run URL.
        /// </param>
        /// <param name="slug">
        /// Unique, stable, URL-safe mini-app identifier.
        /// </param>
        /// <param name="description">
        /// Short description of what the mini-app does.
        /// </param>
        /// <param name="acceptsImageInput">
        /// Optional on publish. Whether the app can receive an existing image as its initial input. Omit this field to preserve the current value when re-publishing an existing preview; new previews default to false.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublishMiniAppPreviewRequest(
            string previewId,
            string label,
            global::Ideogram.PublishMiniAppPreviewRequestEmbed embed,
            global::System.Collections.Generic.IList<string> scopes,
            string deploymentUrl,
            string? slug,
            string? description,
            bool? acceptsImageInput,
            string? deploymentCommit,
            global::System.DateTime? deploymentTime,
            object? website)
        {
            this.PreviewId = previewId ?? throw new global::System.ArgumentNullException(nameof(previewId));
            this.Slug = slug;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Description = description;
            this.Embed = embed;
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
            this.AcceptsImageInput = acceptsImageInput;
            this.DeploymentUrl = deploymentUrl ?? throw new global::System.ArgumentNullException(nameof(deploymentUrl));
            this.DeploymentCommit = deploymentCommit;
            this.DeploymentTime = deploymentTime;
            this.Website = website;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishMiniAppPreviewRequest" /> class.
        /// </summary>
        public PublishMiniAppPreviewRequest()
        {
        }

    }
}
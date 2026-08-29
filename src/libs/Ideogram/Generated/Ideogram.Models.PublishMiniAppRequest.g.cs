
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The mini-app catalog entry to publish. Artwork initializes a new app; re-publishing an existing slug preserves its current artwork. Optional nullable fields preserve their current values when omitted or null.<br/>
    /// Example: {"accepts_image_input":true,"deployment_time":"2000-01-23T04:56:07\u002B00:00","website":{"key":""},"deployment_url":"https://openapi-generator.tech","deployment_commit":"deployment_commit","description":"description","label":"label","embed":"iframe","scopes":["scopes","scopes"],"slug":"slug"}
    /// </summary>
    public sealed partial class PublishMiniAppRequest
    {
        /// <summary>
        /// Unique, stable, URL-safe mini-app identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Human-readable display name shown in the catalog.
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.PublishMiniAppRequestEmbedJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.PublishMiniAppRequestEmbed Embed { get; set; }

        /// <summary>
        /// Permission scopes the mini-app requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Scopes { get; set; }

        /// <summary>
        /// Optional on publish. Whether the app can receive an existing image as its initial input. Omit this field to preserve the current value when re-publishing an existing app; new apps default to false. Catalog responses always include the resolved boolean.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepts_image_input")]
        public bool? AcceptsImageInput { get; set; }

        /// <summary>
        /// Absolute HTTPS URL where the deployed mini-app is served from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_url")]
        public string? DeploymentUrl { get; set; }

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
        /// Initializes a new instance of the <see cref="PublishMiniAppRequest" /> class.
        /// </summary>
        /// <param name="slug">
        /// Unique, stable, URL-safe mini-app identifier.
        /// </param>
        /// <param name="label">
        /// Human-readable display name shown in the catalog.
        /// </param>
        /// <param name="embed">
        /// How the mini-app is embedded. `iframe` loads the app in a sandboxed frame; `mfe` loads it as a micro-frontend module.
        /// </param>
        /// <param name="scopes">
        /// Permission scopes the mini-app requests.
        /// </param>
        /// <param name="description">
        /// Short description of what the mini-app does.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublishMiniAppRequest(
            string slug,
            string label,
            global::Ideogram.PublishMiniAppRequestEmbed embed,
            global::System.Collections.Generic.IList<string> scopes,
            string? description,
            bool? acceptsImageInput,
            string? deploymentUrl,
            string? deploymentCommit,
            global::System.DateTime? deploymentTime,
            object? website)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Description = description;
            this.Embed = embed;
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
            this.AcceptsImageInput = acceptsImageInput;
            this.DeploymentUrl = deploymentUrl;
            this.DeploymentCommit = deploymentCommit;
            this.DeploymentTime = deploymentTime;
            this.Website = website;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishMiniAppRequest" /> class.
        /// </summary>
        public PublishMiniAppRequest()
        {
        }

    }
}
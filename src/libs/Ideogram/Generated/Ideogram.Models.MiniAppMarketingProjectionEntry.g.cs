
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Public-safe metadata for a mini-app marketing page.<br/>
    /// Example: {"is_marketing":true,"website":{"key":""},"deployment_time":"2000-01-23T04:56:07\u002B00:00","archived_at":"2000-01-23T04:56:07\u002B00:00","deployment_url":"https://openapi-generator.tech","deployment_commit":"deployment_commit","icon":"icon","description":"description","label":"label","cover":"cover","embed":"iframe","slug":"slug","card":"card"}
    /// </summary>
    public sealed partial class MiniAppMarketingProjectionEntry
    {
        /// <summary>
        /// Unique, stable, URL-safe mini-app identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Human-readable mini-app name.
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
        /// How the mini-app runs. Iframe and MFE apps use hosted deployments; native apps are bundled into the Ideogram frontend.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MiniAppMarketingProjectionEntryEmbedJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.MiniAppMarketingProjectionEntryEmbed Embed { get; set; }

        /// <summary>
        /// Public URL for the mini-app icon.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Public URL for the mini-app cover image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover")]
        public string? Cover { get; set; }

        /// <summary>
        /// Public URL for the mini-app card image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("card")]
        public string? Card { get; set; }

        /// <summary>
        /// Structured metadata used to build the mini-app marketing page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Website { get; set; }

        /// <summary>
        /// Archive timestamp; active projection entries omit this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// Whether the entry is selected for public marketing pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_marketing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsMarketing { get; set; }

        /// <summary>
        /// Public URL where a hosted mini-app is served. Native apps omit this field.
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MiniAppMarketingProjectionEntry" /> class.
        /// </summary>
        /// <param name="slug">
        /// Unique, stable, URL-safe mini-app identifier.
        /// </param>
        /// <param name="label">
        /// Human-readable mini-app name.
        /// </param>
        /// <param name="embed">
        /// How the mini-app runs. Iframe and MFE apps use hosted deployments; native apps are bundled into the Ideogram frontend.
        /// </param>
        /// <param name="website">
        /// Structured metadata used to build the mini-app marketing page.
        /// </param>
        /// <param name="isMarketing">
        /// Whether the entry is selected for public marketing pages.
        /// </param>
        /// <param name="description">
        /// Short description of what the mini-app does.
        /// </param>
        /// <param name="icon">
        /// Public URL for the mini-app icon.
        /// </param>
        /// <param name="cover">
        /// Public URL for the mini-app cover image.
        /// </param>
        /// <param name="card">
        /// Public URL for the mini-app card image.
        /// </param>
        /// <param name="archivedAt">
        /// Archive timestamp; active projection entries omit this field.
        /// </param>
        /// <param name="deploymentUrl">
        /// Public URL where a hosted mini-app is served. Native apps omit this field.
        /// </param>
        /// <param name="deploymentCommit">
        /// Source commit hash of the deployed build.
        /// </param>
        /// <param name="deploymentTime">
        /// When the deployment that produced this build completed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MiniAppMarketingProjectionEntry(
            string slug,
            string label,
            global::Ideogram.MiniAppMarketingProjectionEntryEmbed embed,
            object website,
            bool isMarketing,
            string? description,
            string? icon,
            string? cover,
            string? card,
            global::System.DateTime? archivedAt,
            string? deploymentUrl,
            string? deploymentCommit,
            global::System.DateTime? deploymentTime)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Description = description;
            this.Embed = embed;
            this.Icon = icon;
            this.Cover = cover;
            this.Card = card;
            this.Website = website ?? throw new global::System.ArgumentNullException(nameof(website));
            this.ArchivedAt = archivedAt;
            this.IsMarketing = isMarketing;
            this.DeploymentUrl = deploymentUrl;
            this.DeploymentCommit = deploymentCommit;
            this.DeploymentTime = deploymentTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MiniAppMarketingProjectionEntry" /> class.
        /// </summary>
        public MiniAppMarketingProjectionEntry()
        {
        }

    }
}
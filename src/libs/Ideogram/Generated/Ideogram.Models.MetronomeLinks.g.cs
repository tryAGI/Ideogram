
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetronomeLinks
    {
        /// <summary>
        /// The URL to display the customer invoice and API usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoices_iframe_url")]
        public string? InvoicesIframeUrl { get; set; }

        /// <summary>
        /// The URL to display the customer invoice and API usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoices_iframe_dark_mode_url")]
        public string? InvoicesIframeDarkModeUrl { get; set; }

        /// <summary>
        /// The URL to display the customer invoice and API usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_iframe_url")]
        public string? CreditsIframeUrl { get; set; }

        /// <summary>
        /// The URL to display the customer invoice and API usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_iframe_dark_mode_url")]
        public string? CreditsIframeDarkModeUrl { get; set; }

        /// <summary>
        /// The URL to display the customer usage dashboard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_iframe_url")]
        public string? UsageIframeUrl { get; set; }

        /// <summary>
        /// The URL to display the customer usage dashboard, in dark mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_iframe_dark_mode_url")]
        public string? UsageIframeDarkModeUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetronomeLinks" /> class.
        /// </summary>
        /// <param name="invoicesIframeUrl">
        /// The URL to display the customer invoice and API usage.
        /// </param>
        /// <param name="invoicesIframeDarkModeUrl">
        /// The URL to display the customer invoice and API usage.
        /// </param>
        /// <param name="creditsIframeUrl">
        /// The URL to display the customer invoice and API usage.
        /// </param>
        /// <param name="creditsIframeDarkModeUrl">
        /// The URL to display the customer invoice and API usage.
        /// </param>
        /// <param name="usageIframeUrl">
        /// The URL to display the customer usage dashboard.
        /// </param>
        /// <param name="usageIframeDarkModeUrl">
        /// The URL to display the customer usage dashboard, in dark mode.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetronomeLinks(
            string? invoicesIframeUrl,
            string? invoicesIframeDarkModeUrl,
            string? creditsIframeUrl,
            string? creditsIframeDarkModeUrl,
            string? usageIframeUrl,
            string? usageIframeDarkModeUrl)
        {
            this.InvoicesIframeUrl = invoicesIframeUrl;
            this.InvoicesIframeDarkModeUrl = invoicesIframeDarkModeUrl;
            this.CreditsIframeUrl = creditsIframeUrl;
            this.CreditsIframeDarkModeUrl = creditsIframeDarkModeUrl;
            this.UsageIframeUrl = usageIframeUrl;
            this.UsageIframeDarkModeUrl = usageIframeDarkModeUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetronomeLinks" /> class.
        /// </summary>
        public MetronomeLinks()
        {
        }
    }
}
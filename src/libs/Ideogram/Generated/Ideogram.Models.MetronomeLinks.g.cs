
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}

#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListOrganizationInvoicesResponse
    {
        /// <summary>
        /// List of invoices
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.Invoice> Invoices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrganizationInvoicesResponse" /> class.
        /// </summary>
        /// <param name="invoices">
        /// List of invoices
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListOrganizationInvoicesResponse(
            global::System.Collections.Generic.IList<global::Ideogram.Invoice> invoices)
        {
            this.Invoices = invoices ?? throw new global::System.ArgumentNullException(nameof(invoices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOrganizationInvoicesResponse" /> class.
        /// </summary>
        public ListOrganizationInvoicesResponse()
        {
        }
    }
}
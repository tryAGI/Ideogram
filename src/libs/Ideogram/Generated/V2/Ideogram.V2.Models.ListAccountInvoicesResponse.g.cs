
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListAccountInvoicesResponse
    {
        /// <summary>
        /// The organization's invoices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.V2.AccountInvoice> Invoices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAccountInvoicesResponse" /> class.
        /// </summary>
        /// <param name="invoices">
        /// The organization's invoices.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAccountInvoicesResponse(
            global::System.Collections.Generic.IList<global::Ideogram.V2.AccountInvoice> invoices)
        {
            this.Invoices = invoices ?? throw new global::System.ArgumentNullException(nameof(invoices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAccountInvoicesResponse" /> class.
        /// </summary>
        public ListAccountInvoicesResponse()
        {
        }

    }
}
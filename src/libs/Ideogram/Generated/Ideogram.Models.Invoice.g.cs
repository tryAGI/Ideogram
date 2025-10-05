
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Invoice
    {
        /// <summary>
        /// The start time of the invoice period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// The end time of the invoice period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTime { get; set; }

        /// <summary>
        /// Represents a price.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_spend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.Price TotalSpend { get; set; }

        /// <summary>
        /// The date when the invoice was paid (optional, may be null if unpaid)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice_paid_date")]
        public global::System.DateTime? InvoicePaidDate { get; set; }

        /// <summary>
        /// A list of line items within the invoice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line_items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.InvoiceLineItem> LineItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice" /> class.
        /// </summary>
        /// <param name="startTime">
        /// The start time of the invoice period
        /// </param>
        /// <param name="endTime">
        /// The end time of the invoice period
        /// </param>
        /// <param name="totalSpend">
        /// Represents a price.
        /// </param>
        /// <param name="invoicePaidDate">
        /// The date when the invoice was paid (optional, may be null if unpaid)
        /// </param>
        /// <param name="lineItems">
        /// A list of line items within the invoice
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Invoice(
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::Ideogram.Price totalSpend,
            global::System.Collections.Generic.IList<global::Ideogram.InvoiceLineItem> lineItems,
            global::System.DateTime? invoicePaidDate)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.TotalSpend = totalSpend ?? throw new global::System.ArgumentNullException(nameof(totalSpend));
            this.LineItems = lineItems ?? throw new global::System.ArgumentNullException(nameof(lineItems));
            this.InvoicePaidDate = invoicePaidDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice" /> class.
        /// </summary>
        public Invoice()
        {
        }
    }
}
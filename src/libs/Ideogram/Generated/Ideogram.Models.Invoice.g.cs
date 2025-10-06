
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
        /// The date when the invoice was issued
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issued_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime IssuedTime { get; set; }

        /// <summary>
        /// Represents a price.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_spend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.Price TotalSpend { get; set; }

        /// <summary>
        /// Status of the invoice<br/>
        /// Example: PAID
        /// </summary>
        /// <example>PAID</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.InvoiceStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.InvoiceStatus InvoiceStatus { get; set; }

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
        /// <param name="issuedTime">
        /// The date when the invoice was issued
        /// </param>
        /// <param name="totalSpend">
        /// Represents a price.
        /// </param>
        /// <param name="invoiceStatus">
        /// Status of the invoice<br/>
        /// Example: PAID
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
            global::System.DateTime issuedTime,
            global::Ideogram.Price totalSpend,
            global::Ideogram.InvoiceStatus invoiceStatus,
            global::System.Collections.Generic.IList<global::Ideogram.InvoiceLineItem> lineItems)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.IssuedTime = issuedTime;
            this.TotalSpend = totalSpend ?? throw new global::System.ArgumentNullException(nameof(totalSpend));
            this.InvoiceStatus = invoiceStatus;
            this.LineItems = lineItems ?? throw new global::System.ArgumentNullException(nameof(lineItems));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice" /> class.
        /// </summary>
        public Invoice()
        {
        }
    }
}
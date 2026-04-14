
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"charge_name":"Image Generation - V3","total":{"amount":1050,"currency_code":"USD"},"quantity":1000,"unit_price":{"amount":1050,"currency_code":"USD"},"api_key_id":"api_key_id"}
    /// </summary>
    public sealed partial class InvoiceLineItem
    {
        /// <summary>
        /// The name of the charge<br/>
        /// Example: Image Generation - V3
        /// </summary>
        /// <example>Image Generation - V3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("charge_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChargeName { get; set; }

        /// <summary>
        /// The API key associated with the usage, when available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        public string? ApiKeyId { get; set; }

        /// <summary>
        /// The quantity of the charge<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Quantity { get; set; }

        /// <summary>
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </summary>
        /// <example>{"amount":1050,"currency_code":"USD"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.Price UnitPrice { get; set; }

        /// <summary>
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </summary>
        /// <example>{"amount":1050,"currency_code":"USD"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.Price Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceLineItem" /> class.
        /// </summary>
        /// <param name="chargeName">
        /// The name of the charge<br/>
        /// Example: Image Generation - V3
        /// </param>
        /// <param name="quantity">
        /// The quantity of the charge<br/>
        /// Example: 1000
        /// </param>
        /// <param name="unitPrice">
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </param>
        /// <param name="total">
        /// Represents a price.<br/>
        /// Example: {"amount":1050,"currency_code":"USD"}
        /// </param>
        /// <param name="apiKeyId">
        /// The API key associated with the usage, when available
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InvoiceLineItem(
            string chargeName,
            int quantity,
            global::Ideogram.Price unitPrice,
            global::Ideogram.Price total,
            string? apiKeyId)
        {
            this.ChargeName = chargeName ?? throw new global::System.ArgumentNullException(nameof(chargeName));
            this.ApiKeyId = apiKeyId;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice ?? throw new global::System.ArgumentNullException(nameof(unitPrice));
            this.Total = total ?? throw new global::System.ArgumentNullException(nameof(total));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceLineItem" /> class.
        /// </summary>
        public InvoiceLineItem()
        {
        }
    }
}
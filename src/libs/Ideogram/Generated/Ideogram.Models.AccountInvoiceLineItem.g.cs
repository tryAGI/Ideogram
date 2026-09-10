
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// One charged product on an invoice.<br/>
    /// Example: {"cost_total":"84.00","quantity":"2100","api_key":{"redacted_key":"ATG5\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","id":"JRPVD7jWR1aTBYiJ0UFVOg","label":"Live production environment"},"description":"Ideogram v4 Generation","unit_price":"0.04","currency_code":"USD"}
    /// </summary>
    public sealed partial class AccountInvoiceLineItem
    {
        /// <summary>
        /// Display name of the charged product. Not an identifier.<br/>
        /// Example: Ideogram v4 Generation
        /// </summary>
        /// <example>Ideogram v4 Generation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Number of billed units, as a decimal string.<br/>
        /// Example: 2100
        /// </summary>
        /// <example>2100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Quantity { get; set; }

        /// <summary>
        /// Price per unit in `currency_code`, as a decimal string.<br/>
        /// Example: 0.04
        /// </summary>
        /// <example>0.04</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UnitPrice { get; set; }

        /// <summary>
        /// Total charged amount in `currency_code`, as a decimal string.<br/>
        /// Example: 84.00
        /// </summary>
        /// <example>84.00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CostTotal { get; set; }

        /// <summary>
        /// ISO 4217 currency code of the amounts on this line item.<br/>
        /// Example: USD
        /// </summary>
        /// <example>USD</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrencyCode { get; set; }

        /// <summary>
        /// The API key the usage was billed to, in redacted form.<br/>
        /// Example: {"redacted_key":"ATG5\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","id":"JRPVD7jWR1aTBYiJ0UFVOg","label":"Live production environment"}
        /// </summary>
        /// <example>{"redacted_key":"ATG5\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","id":"JRPVD7jWR1aTBYiJ0UFVOg","label":"Live production environment"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public global::Ideogram.AccountUsageApiKey? ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountInvoiceLineItem" /> class.
        /// </summary>
        /// <param name="description">
        /// Display name of the charged product. Not an identifier.<br/>
        /// Example: Ideogram v4 Generation
        /// </param>
        /// <param name="quantity">
        /// Number of billed units, as a decimal string.<br/>
        /// Example: 2100
        /// </param>
        /// <param name="unitPrice">
        /// Price per unit in `currency_code`, as a decimal string.<br/>
        /// Example: 0.04
        /// </param>
        /// <param name="costTotal">
        /// Total charged amount in `currency_code`, as a decimal string.<br/>
        /// Example: 84.00
        /// </param>
        /// <param name="currencyCode">
        /// ISO 4217 currency code of the amounts on this line item.<br/>
        /// Example: USD
        /// </param>
        /// <param name="apiKey">
        /// The API key the usage was billed to, in redacted form.<br/>
        /// Example: {"redacted_key":"ATG5\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","id":"JRPVD7jWR1aTBYiJ0UFVOg","label":"Live production environment"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountInvoiceLineItem(
            string description,
            string quantity,
            string unitPrice,
            string costTotal,
            string currencyCode,
            global::Ideogram.AccountUsageApiKey? apiKey)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Quantity = quantity ?? throw new global::System.ArgumentNullException(nameof(quantity));
            this.UnitPrice = unitPrice ?? throw new global::System.ArgumentNullException(nameof(unitPrice));
            this.CostTotal = costTotal ?? throw new global::System.ArgumentNullException(nameof(costTotal));
            this.CurrencyCode = currencyCode ?? throw new global::System.ArgumentNullException(nameof(currencyCode));
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountInvoiceLineItem" /> class.
        /// </summary>
        public AccountInvoiceLineItem()
        {
        }

    }
}
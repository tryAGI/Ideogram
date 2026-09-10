
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// One billed rate for one billing actor within one time bucket.<br/>
    /// Example: {"product":"ideogram_v4_generation","endpoint":"/v2/images/generate/ideogram-v4","cost_total":"84.00","user_email":"user_email","api_key":{"redacted_key":"ATG5\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","id":"JRPVD7jWR1aTBYiJ0UFVOg","label":"Live production environment"},"description":"Ideogram v4 Generation","billed_units":{"unit":"image","quantity":"2100","unit_price":"0.04"},"source":"api","currency_code":"USD","dimensions":{"key":"dimensions"}}
    /// </summary>
    public sealed partial class AccountUsageLineItem
    {
        /// <summary>
        /// Stable identifier of the billed product, matching the public pricing catalog. `unknown` when a historical charge can no longer be attributed; its cost is still included.<br/>
        /// Example: ideogram_v4_generation
        /// </summary>
        /// <example>ideogram_v4_generation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Product { get; set; }

        /// <summary>
        /// The API endpoint path this product belongs to.<br/>
        /// Example: /v2/images/generate/ideogram-v4
        /// </summary>
        /// <example>/v2/images/generate/ideogram-v4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// Display name of the billed product. Not an identifier.<br/>
        /// Example: Ideogram v4 Generation
        /// </summary>
        /// <example>Ideogram v4 Generation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Pricing dimensions this line item was billed under, for products priced per dimension (for example rendering speed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public global::System.Collections.Generic.Dictionary<string, string>? Dimensions { get; set; }

        /// <summary>
        /// Total billed amount in `currency_code`, as a decimal string.<br/>
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
        /// Which billing surface the usage came through. `api` usage is attributed to an API key when one was used; `app` usage is attributed to the member who generated it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.AccountUsageLineItemSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.AccountUsageLineItemSource Source { get; set; }

        /// <summary>
        /// The API key the usage was billed to, in redacted form.<br/>
        /// Example: {"redacted_key":"ATG5\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","id":"JRPVD7jWR1aTBYiJ0UFVOg","label":"Live production environment"}
        /// </summary>
        /// <example>{"redacted_key":"ATG5\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","id":"JRPVD7jWR1aTBYiJ0UFVOg","label":"Live production environment"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public global::Ideogram.AccountUsageApiKey? ApiKey { get; set; }

        /// <summary>
        /// Email address of the member who generated the usage. Only present on `app` usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// Per-unit detail for products billed per item. `quantity × unit_price` always equals the line item's `cost_total`.<br/>
        /// Example: {"unit":"image","quantity":"2100","unit_price":"0.04"}
        /// </summary>
        /// <example>{"unit":"image","quantity":"2100","unit_price":"0.04"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("billed_units")]
        public global::Ideogram.AccountUsageBilledUnits? BilledUnits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountUsageLineItem" /> class.
        /// </summary>
        /// <param name="product">
        /// Stable identifier of the billed product, matching the public pricing catalog. `unknown` when a historical charge can no longer be attributed; its cost is still included.<br/>
        /// Example: ideogram_v4_generation
        /// </param>
        /// <param name="endpoint">
        /// The API endpoint path this product belongs to.<br/>
        /// Example: /v2/images/generate/ideogram-v4
        /// </param>
        /// <param name="description">
        /// Display name of the billed product. Not an identifier.<br/>
        /// Example: Ideogram v4 Generation
        /// </param>
        /// <param name="costTotal">
        /// Total billed amount in `currency_code`, as a decimal string.<br/>
        /// Example: 84.00
        /// </param>
        /// <param name="currencyCode">
        /// ISO 4217 currency code of the amounts on this line item.<br/>
        /// Example: USD
        /// </param>
        /// <param name="source">
        /// Which billing surface the usage came through. `api` usage is attributed to an API key when one was used; `app` usage is attributed to the member who generated it.
        /// </param>
        /// <param name="dimensions">
        /// Pricing dimensions this line item was billed under, for products priced per dimension (for example rendering speed).
        /// </param>
        /// <param name="apiKey">
        /// The API key the usage was billed to, in redacted form.<br/>
        /// Example: {"redacted_key":"ATG5\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","id":"JRPVD7jWR1aTBYiJ0UFVOg","label":"Live production environment"}
        /// </param>
        /// <param name="userEmail">
        /// Email address of the member who generated the usage. Only present on `app` usage.
        /// </param>
        /// <param name="billedUnits">
        /// Per-unit detail for products billed per item. `quantity × unit_price` always equals the line item's `cost_total`.<br/>
        /// Example: {"unit":"image","quantity":"2100","unit_price":"0.04"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountUsageLineItem(
            string product,
            string endpoint,
            string description,
            string costTotal,
            string currencyCode,
            global::Ideogram.AccountUsageLineItemSource source,
            global::System.Collections.Generic.Dictionary<string, string>? dimensions,
            global::Ideogram.AccountUsageApiKey? apiKey,
            string? userEmail,
            global::Ideogram.AccountUsageBilledUnits? billedUnits)
        {
            this.Product = product ?? throw new global::System.ArgumentNullException(nameof(product));
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Dimensions = dimensions;
            this.CostTotal = costTotal ?? throw new global::System.ArgumentNullException(nameof(costTotal));
            this.CurrencyCode = currencyCode ?? throw new global::System.ArgumentNullException(nameof(currencyCode));
            this.Source = source;
            this.ApiKey = apiKey;
            this.UserEmail = userEmail;
            this.BilledUnits = billedUnits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountUsageLineItem" /> class.
        /// </summary>
        public AccountUsageLineItem()
        {
        }

    }
}
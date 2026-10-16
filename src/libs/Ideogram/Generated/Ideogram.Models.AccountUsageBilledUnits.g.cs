
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Per-unit detail for products billed per item. `quantity × unit_price` always equals the line item's `cost_total`.
    /// </summary>
    public sealed partial class AccountUsageBilledUnits
    {
        /// <summary>
        /// What one billed unit is (for example `image`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Unit { get; set; }

        /// <summary>
        /// Number of units billed, as a decimal string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Quantity { get; set; }

        /// <summary>
        /// Price per unit in `currency_code`, as a decimal string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UnitPrice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountUsageBilledUnits" /> class.
        /// </summary>
        /// <param name="unit">
        /// What one billed unit is (for example `image`).
        /// </param>
        /// <param name="quantity">
        /// Number of units billed, as a decimal string.
        /// </param>
        /// <param name="unitPrice">
        /// Price per unit in `currency_code`, as a decimal string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountUsageBilledUnits(
            string unit,
            string quantity,
            string unitPrice)
        {
            this.Unit = unit ?? throw new global::System.ArgumentNullException(nameof(unit));
            this.Quantity = quantity ?? throw new global::System.ArgumentNullException(nameof(quantity));
            this.UnitPrice = unitPrice ?? throw new global::System.ArgumentNullException(nameof(unitPrice));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountUsageBilledUnits" /> class.
        /// </summary>
        public AccountUsageBilledUnits()
        {
        }

    }
}

#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Status of the invoice<br/>
    /// Example: PAID
    /// </summary>
    public enum InvoiceStatus
    {
        /// <summary>
        /// 
        /// </summary>
        DRAFT,
        /// <summary>
        /// 
        /// </summary>
        PENDINGPAYMENT,
        /// <summary>
        /// 
        /// </summary>
        PAID,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InvoiceStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InvoiceStatus value)
        {
            return value switch
            {
                InvoiceStatus.DRAFT => "DRAFT",
                InvoiceStatus.PENDINGPAYMENT => "PENDING_PAYMENT",
                InvoiceStatus.PAID => "PAID",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InvoiceStatus? ToEnum(string value)
        {
            return value switch
            {
                "DRAFT" => InvoiceStatus.DRAFT,
                "PENDING_PAYMENT" => InvoiceStatus.PENDINGPAYMENT,
                "PAID" => InvoiceStatus.PAID,
                _ => null,
            };
        }
    }
}
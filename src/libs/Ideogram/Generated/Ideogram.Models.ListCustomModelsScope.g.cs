
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListCustomModelsScope
    {
        /// <summary>
        /// 
        /// </summary>
        Owned,
        /// <summary>
        /// 
        /// </summary>
        Shared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListCustomModelsScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCustomModelsScope value)
        {
            return value switch
            {
                ListCustomModelsScope.Owned => "owned",
                ListCustomModelsScope.Shared => "shared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCustomModelsScope? ToEnum(string value)
        {
            return value switch
            {
                "owned" => ListCustomModelsScope.Owned,
                "shared" => ListCustomModelsScope.Shared,
                _ => null,
            };
        }
    }
}
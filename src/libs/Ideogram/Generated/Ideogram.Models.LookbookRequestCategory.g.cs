
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Selects the category-specific Lookbook presentation reference.
    /// </summary>
    public enum LookbookRequestCategory
    {
        /// <summary>
        ///
        /// </summary>
        Dresses,
        /// <summary>
        ///
        /// </summary>
        Jeans,
        /// <summary>
        ///
        /// </summary>
        Pants,
        /// <summary>
        ///
        /// </summary>
        Tops,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LookbookRequestCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LookbookRequestCategory value)
        {
            return value switch
            {
                LookbookRequestCategory.Dresses => "dresses",
                LookbookRequestCategory.Jeans => "jeans",
                LookbookRequestCategory.Pants => "pants",
                LookbookRequestCategory.Tops => "tops",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LookbookRequestCategory? ToEnum(string value)
        {
            return value switch
            {
                "dresses" => LookbookRequestCategory.Dresses,
                "jeans" => LookbookRequestCategory.Jeans,
                "pants" => LookbookRequestCategory.Pants,
                "tops" => LookbookRequestCategory.Tops,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// The target language for the copy. Arabic is rendered right-to-left. Each request covers one language; send one request per language.
    /// </summary>
    public enum V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage
    {
        /// <summary>
        ///
        /// </summary>
        Ar,
        /// <summary>
        ///
        /// </summary>
        Cs,
        /// <summary>
        ///
        /// </summary>
        Da,
        /// <summary>
        ///
        /// </summary>
        De,
        /// <summary>
        ///
        /// </summary>
        En,
        /// <summary>
        ///
        /// </summary>
        Es,
        /// <summary>
        ///
        /// </summary>
        Fi,
        /// <summary>
        ///
        /// </summary>
        Fr,
        /// <summary>
        ///
        /// </summary>
        FrCa,
        /// <summary>
        ///
        /// </summary>
        Hu,
        /// <summary>
        ///
        /// </summary>
        It,
        /// <summary>
        ///
        /// </summary>
        Ja,
        /// <summary>
        ///
        /// </summary>
        Nl,
        /// <summary>
        ///
        /// </summary>
        No,
        /// <summary>
        ///
        /// </summary>
        Pl,
        /// <summary>
        ///
        /// </summary>
        Pt,
        /// <summary>
        ///
        /// </summary>
        Sv,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage value)
        {
            return value switch
            {
                V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Ar => "ar",
                V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Cs => "cs",
                V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Da => "da",
                V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.De => "de",
                V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.En => "en",
                V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Es => "es",
                V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Fi => "fi",
                V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Fr => "fr",
                V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.FrCa => "fr-ca",
                V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Hu => "hu",
                V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.It => "it",
                V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Ja => "ja",
                V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Nl => "nl",
                V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.No => "no",
                V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Pl => "pl",
                V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Pt => "pt",
                V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Sv => "sv",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Ar,
                "cs" => V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Cs,
                "da" => V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Da,
                "de" => V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.De,
                "en" => V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.En,
                "es" => V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Es,
                "fi" => V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Fi,
                "fr" => V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Fr,
                "fr-ca" => V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.FrCa,
                "hu" => V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Hu,
                "it" => V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.It,
                "ja" => V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Ja,
                "nl" => V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Nl,
                "no" => V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.No,
                "pl" => V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Pl,
                "pt" => V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Pt,
                "sv" => V2ToolAdLocalizerPostRequestBodyContentMultipartFormDataSchemaLanguage.Sv,
                _ => null,
            };
        }
    }
}
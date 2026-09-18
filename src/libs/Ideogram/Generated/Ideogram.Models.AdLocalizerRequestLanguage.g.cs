
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The target language the copy is rebuilt in. Arabic is rendered right-to-left.
    /// </summary>
    public enum AdLocalizerRequestLanguage
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
    public static class AdLocalizerRequestLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdLocalizerRequestLanguage value)
        {
            return value switch
            {
                AdLocalizerRequestLanguage.Ar => "ar",
                AdLocalizerRequestLanguage.Cs => "cs",
                AdLocalizerRequestLanguage.Da => "da",
                AdLocalizerRequestLanguage.De => "de",
                AdLocalizerRequestLanguage.En => "en",
                AdLocalizerRequestLanguage.Es => "es",
                AdLocalizerRequestLanguage.Fi => "fi",
                AdLocalizerRequestLanguage.Fr => "fr",
                AdLocalizerRequestLanguage.FrCa => "fr-ca",
                AdLocalizerRequestLanguage.Hu => "hu",
                AdLocalizerRequestLanguage.It => "it",
                AdLocalizerRequestLanguage.Ja => "ja",
                AdLocalizerRequestLanguage.Nl => "nl",
                AdLocalizerRequestLanguage.No => "no",
                AdLocalizerRequestLanguage.Pl => "pl",
                AdLocalizerRequestLanguage.Pt => "pt",
                AdLocalizerRequestLanguage.Sv => "sv",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdLocalizerRequestLanguage? ToEnum(string value)
        {
            return value switch
            {
                "ar" => AdLocalizerRequestLanguage.Ar,
                "cs" => AdLocalizerRequestLanguage.Cs,
                "da" => AdLocalizerRequestLanguage.Da,
                "de" => AdLocalizerRequestLanguage.De,
                "en" => AdLocalizerRequestLanguage.En,
                "es" => AdLocalizerRequestLanguage.Es,
                "fi" => AdLocalizerRequestLanguage.Fi,
                "fr" => AdLocalizerRequestLanguage.Fr,
                "fr-ca" => AdLocalizerRequestLanguage.FrCa,
                "hu" => AdLocalizerRequestLanguage.Hu,
                "it" => AdLocalizerRequestLanguage.It,
                "ja" => AdLocalizerRequestLanguage.Ja,
                "nl" => AdLocalizerRequestLanguage.Nl,
                "no" => AdLocalizerRequestLanguage.No,
                "pl" => AdLocalizerRequestLanguage.Pl,
                "pt" => AdLocalizerRequestLanguage.Pt,
                "sv" => AdLocalizerRequestLanguage.Sv,
                _ => null,
            };
        }
    }
}
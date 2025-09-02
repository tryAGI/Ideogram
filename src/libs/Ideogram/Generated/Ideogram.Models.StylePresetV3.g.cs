
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A predefined style preset that applies a specific artistic style to the generated image.<br/>
    /// Example: BRIGHT_ART
    /// </summary>
    public enum StylePresetV3
    {
        /// <summary>
        /// 
        /// </summary>
        x80SILLUSTRATION,
        /// <summary>
        /// 
        /// </summary>
        x90SNOSTALGIA,
        /// <summary>
        /// 
        /// </summary>
        ABSTRACTORGANIC,
        /// <summary>
        /// 
        /// </summary>
        ANALOGNOSTALGIA,
        /// <summary>
        /// 
        /// </summary>
        ARTBRUT,
        /// <summary>
        /// 
        /// </summary>
        ARTDECO,
        /// <summary>
        /// 
        /// </summary>
        ARTPOSTER,
        /// <summary>
        /// 
        /// </summary>
        AURA,
        /// <summary>
        /// 
        /// </summary>
        AVANTGARDE,
        /// <summary>
        /// 
        /// </summary>
        BAUHAUS,
        /// <summary>
        /// 
        /// </summary>
        BLUEPRINT,
        /// <summary>
        /// 
        /// </summary>
        BLURRYMOTION,
        /// <summary>
        /// 
        /// </summary>
        BRIGHTART,
        /// <summary>
        /// 
        /// </summary>
        C4DCARTOON,
        /// <summary>
        /// 
        /// </summary>
        CHILDRENSBOOK,
        /// <summary>
        /// 
        /// </summary>
        COLLAGE,
        /// <summary>
        /// 
        /// </summary>
        COLORINGBOOKI,
        /// <summary>
        /// 
        /// </summary>
        COLORINGBOOKII,
        /// <summary>
        /// 
        /// </summary>
        CUBISM,
        /// <summary>
        /// 
        /// </summary>
        DARKAURA,
        /// <summary>
        /// 
        /// </summary>
        DOODLE,
        /// <summary>
        /// 
        /// </summary>
        DOUBLEEXPOSURE,
        /// <summary>
        /// 
        /// </summary>
        DRAMATICCINEMA,
        /// <summary>
        /// 
        /// </summary>
        EDITORIAL,
        /// <summary>
        /// 
        /// </summary>
        EMOTIONALMINIMAL,
        /// <summary>
        /// 
        /// </summary>
        ETHEREALPARTY,
        /// <summary>
        /// 
        /// </summary>
        EXPIREDFILM,
        /// <summary>
        /// 
        /// </summary>
        FLATART,
        /// <summary>
        /// 
        /// </summary>
        FLATVECTOR,
        /// <summary>
        /// 
        /// </summary>
        FORESTREVERIE,
        /// <summary>
        /// 
        /// </summary>
        GEOMINIMALIST,
        /// <summary>
        /// 
        /// </summary>
        GLASSPRISM,
        /// <summary>
        /// 
        /// </summary>
        GOLDENHOUR,
        /// <summary>
        /// 
        /// </summary>
        GRAFFITII,
        /// <summary>
        /// 
        /// </summary>
        GRAFFITIII,
        /// <summary>
        /// 
        /// </summary>
        HALFTONEPRINT,
        /// <summary>
        /// 
        /// </summary>
        HIGHCONTRAST,
        /// <summary>
        /// 
        /// </summary>
        HIPPIEERA,
        /// <summary>
        /// 
        /// </summary>
        ICONIC,
        /// <summary>
        /// 
        /// </summary>
        JAPANDIFUSION,
        /// <summary>
        /// 
        /// </summary>
        JAZZY,
        /// <summary>
        /// 
        /// </summary>
        LONGEXPOSURE,
        /// <summary>
        /// 
        /// </summary>
        MAGAZINEEDITORIAL,
        /// <summary>
        /// 
        /// </summary>
        MINIMALILLUSTRATION,
        /// <summary>
        /// 
        /// </summary>
        MIXEDMEDIA,
        /// <summary>
        /// 
        /// </summary>
        MONOCHROME,
        /// <summary>
        /// 
        /// </summary>
        NIGHTLIFE,
        /// <summary>
        /// 
        /// </summary>
        OILPAINTING,
        /// <summary>
        /// 
        /// </summary>
        OLDCARTOONS,
        /// <summary>
        /// 
        /// </summary>
        PAINTGESTURE,
        /// <summary>
        /// 
        /// </summary>
        POPART,
        /// <summary>
        /// 
        /// </summary>
        RETROETCHING,
        /// <summary>
        /// 
        /// </summary>
        RIVIERAPOP,
        /// <summary>
        /// 
        /// </summary>
        SPOTLIGHT80S,
        /// <summary>
        /// 
        /// </summary>
        STYLIZEDRED,
        /// <summary>
        /// 
        /// </summary>
        SURREALCOLLAGE,
        /// <summary>
        /// 
        /// </summary>
        TRAVELPOSTER,
        /// <summary>
        /// 
        /// </summary>
        VINTAGEGEO,
        /// <summary>
        /// 
        /// </summary>
        VINTAGEPOSTER,
        /// <summary>
        /// 
        /// </summary>
        WATERCOLOR,
        /// <summary>
        /// 
        /// </summary>
        WEIRD,
        /// <summary>
        /// 
        /// </summary>
        WOODBLOCKPRINT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StylePresetV3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StylePresetV3 value)
        {
            return value switch
            {
                StylePresetV3.x80SILLUSTRATION => "80S_ILLUSTRATION",
                StylePresetV3.x90SNOSTALGIA => "90S_NOSTALGIA",
                StylePresetV3.ABSTRACTORGANIC => "ABSTRACT_ORGANIC",
                StylePresetV3.ANALOGNOSTALGIA => "ANALOG_NOSTALGIA",
                StylePresetV3.ARTBRUT => "ART_BRUT",
                StylePresetV3.ARTDECO => "ART_DECO",
                StylePresetV3.ARTPOSTER => "ART_POSTER",
                StylePresetV3.AURA => "AURA",
                StylePresetV3.AVANTGARDE => "AVANT_GARDE",
                StylePresetV3.BAUHAUS => "BAUHAUS",
                StylePresetV3.BLUEPRINT => "BLUEPRINT",
                StylePresetV3.BLURRYMOTION => "BLURRY_MOTION",
                StylePresetV3.BRIGHTART => "BRIGHT_ART",
                StylePresetV3.C4DCARTOON => "C4D_CARTOON",
                StylePresetV3.CHILDRENSBOOK => "CHILDRENS_BOOK",
                StylePresetV3.COLLAGE => "COLLAGE",
                StylePresetV3.COLORINGBOOKI => "COLORING_BOOK_I",
                StylePresetV3.COLORINGBOOKII => "COLORING_BOOK_II",
                StylePresetV3.CUBISM => "CUBISM",
                StylePresetV3.DARKAURA => "DARK_AURA",
                StylePresetV3.DOODLE => "DOODLE",
                StylePresetV3.DOUBLEEXPOSURE => "DOUBLE_EXPOSURE",
                StylePresetV3.DRAMATICCINEMA => "DRAMATIC_CINEMA",
                StylePresetV3.EDITORIAL => "EDITORIAL",
                StylePresetV3.EMOTIONALMINIMAL => "EMOTIONAL_MINIMAL",
                StylePresetV3.ETHEREALPARTY => "ETHEREAL_PARTY",
                StylePresetV3.EXPIREDFILM => "EXPIRED_FILM",
                StylePresetV3.FLATART => "FLAT_ART",
                StylePresetV3.FLATVECTOR => "FLAT_VECTOR",
                StylePresetV3.FORESTREVERIE => "FOREST_REVERIE",
                StylePresetV3.GEOMINIMALIST => "GEO_MINIMALIST",
                StylePresetV3.GLASSPRISM => "GLASS_PRISM",
                StylePresetV3.GOLDENHOUR => "GOLDEN_HOUR",
                StylePresetV3.GRAFFITII => "GRAFFITI_I",
                StylePresetV3.GRAFFITIII => "GRAFFITI_II",
                StylePresetV3.HALFTONEPRINT => "HALFTONE_PRINT",
                StylePresetV3.HIGHCONTRAST => "HIGH_CONTRAST",
                StylePresetV3.HIPPIEERA => "HIPPIE_ERA",
                StylePresetV3.ICONIC => "ICONIC",
                StylePresetV3.JAPANDIFUSION => "JAPANDI_FUSION",
                StylePresetV3.JAZZY => "JAZZY",
                StylePresetV3.LONGEXPOSURE => "LONG_EXPOSURE",
                StylePresetV3.MAGAZINEEDITORIAL => "MAGAZINE_EDITORIAL",
                StylePresetV3.MINIMALILLUSTRATION => "MINIMAL_ILLUSTRATION",
                StylePresetV3.MIXEDMEDIA => "MIXED_MEDIA",
                StylePresetV3.MONOCHROME => "MONOCHROME",
                StylePresetV3.NIGHTLIFE => "NIGHTLIFE",
                StylePresetV3.OILPAINTING => "OIL_PAINTING",
                StylePresetV3.OLDCARTOONS => "OLD_CARTOONS",
                StylePresetV3.PAINTGESTURE => "PAINT_GESTURE",
                StylePresetV3.POPART => "POP_ART",
                StylePresetV3.RETROETCHING => "RETRO_ETCHING",
                StylePresetV3.RIVIERAPOP => "RIVIERA_POP",
                StylePresetV3.SPOTLIGHT80S => "SPOTLIGHT_80S",
                StylePresetV3.STYLIZEDRED => "STYLIZED_RED",
                StylePresetV3.SURREALCOLLAGE => "SURREAL_COLLAGE",
                StylePresetV3.TRAVELPOSTER => "TRAVEL_POSTER",
                StylePresetV3.VINTAGEGEO => "VINTAGE_GEO",
                StylePresetV3.VINTAGEPOSTER => "VINTAGE_POSTER",
                StylePresetV3.WATERCOLOR => "WATERCOLOR",
                StylePresetV3.WEIRD => "WEIRD",
                StylePresetV3.WOODBLOCKPRINT => "WOODBLOCK_PRINT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StylePresetV3? ToEnum(string value)
        {
            return value switch
            {
                "80S_ILLUSTRATION" => StylePresetV3.x80SILLUSTRATION,
                "90S_NOSTALGIA" => StylePresetV3.x90SNOSTALGIA,
                "ABSTRACT_ORGANIC" => StylePresetV3.ABSTRACTORGANIC,
                "ANALOG_NOSTALGIA" => StylePresetV3.ANALOGNOSTALGIA,
                "ART_BRUT" => StylePresetV3.ARTBRUT,
                "ART_DECO" => StylePresetV3.ARTDECO,
                "ART_POSTER" => StylePresetV3.ARTPOSTER,
                "AURA" => StylePresetV3.AURA,
                "AVANT_GARDE" => StylePresetV3.AVANTGARDE,
                "BAUHAUS" => StylePresetV3.BAUHAUS,
                "BLUEPRINT" => StylePresetV3.BLUEPRINT,
                "BLURRY_MOTION" => StylePresetV3.BLURRYMOTION,
                "BRIGHT_ART" => StylePresetV3.BRIGHTART,
                "C4D_CARTOON" => StylePresetV3.C4DCARTOON,
                "CHILDRENS_BOOK" => StylePresetV3.CHILDRENSBOOK,
                "COLLAGE" => StylePresetV3.COLLAGE,
                "COLORING_BOOK_I" => StylePresetV3.COLORINGBOOKI,
                "COLORING_BOOK_II" => StylePresetV3.COLORINGBOOKII,
                "CUBISM" => StylePresetV3.CUBISM,
                "DARK_AURA" => StylePresetV3.DARKAURA,
                "DOODLE" => StylePresetV3.DOODLE,
                "DOUBLE_EXPOSURE" => StylePresetV3.DOUBLEEXPOSURE,
                "DRAMATIC_CINEMA" => StylePresetV3.DRAMATICCINEMA,
                "EDITORIAL" => StylePresetV3.EDITORIAL,
                "EMOTIONAL_MINIMAL" => StylePresetV3.EMOTIONALMINIMAL,
                "ETHEREAL_PARTY" => StylePresetV3.ETHEREALPARTY,
                "EXPIRED_FILM" => StylePresetV3.EXPIREDFILM,
                "FLAT_ART" => StylePresetV3.FLATART,
                "FLAT_VECTOR" => StylePresetV3.FLATVECTOR,
                "FOREST_REVERIE" => StylePresetV3.FORESTREVERIE,
                "GEO_MINIMALIST" => StylePresetV3.GEOMINIMALIST,
                "GLASS_PRISM" => StylePresetV3.GLASSPRISM,
                "GOLDEN_HOUR" => StylePresetV3.GOLDENHOUR,
                "GRAFFITI_I" => StylePresetV3.GRAFFITII,
                "GRAFFITI_II" => StylePresetV3.GRAFFITIII,
                "HALFTONE_PRINT" => StylePresetV3.HALFTONEPRINT,
                "HIGH_CONTRAST" => StylePresetV3.HIGHCONTRAST,
                "HIPPIE_ERA" => StylePresetV3.HIPPIEERA,
                "ICONIC" => StylePresetV3.ICONIC,
                "JAPANDI_FUSION" => StylePresetV3.JAPANDIFUSION,
                "JAZZY" => StylePresetV3.JAZZY,
                "LONG_EXPOSURE" => StylePresetV3.LONGEXPOSURE,
                "MAGAZINE_EDITORIAL" => StylePresetV3.MAGAZINEEDITORIAL,
                "MINIMAL_ILLUSTRATION" => StylePresetV3.MINIMALILLUSTRATION,
                "MIXED_MEDIA" => StylePresetV3.MIXEDMEDIA,
                "MONOCHROME" => StylePresetV3.MONOCHROME,
                "NIGHTLIFE" => StylePresetV3.NIGHTLIFE,
                "OIL_PAINTING" => StylePresetV3.OILPAINTING,
                "OLD_CARTOONS" => StylePresetV3.OLDCARTOONS,
                "PAINT_GESTURE" => StylePresetV3.PAINTGESTURE,
                "POP_ART" => StylePresetV3.POPART,
                "RETRO_ETCHING" => StylePresetV3.RETROETCHING,
                "RIVIERA_POP" => StylePresetV3.RIVIERAPOP,
                "SPOTLIGHT_80S" => StylePresetV3.SPOTLIGHT80S,
                "STYLIZED_RED" => StylePresetV3.STYLIZEDRED,
                "SURREAL_COLLAGE" => StylePresetV3.SURREALCOLLAGE,
                "TRAVEL_POSTER" => StylePresetV3.TRAVELPOSTER,
                "VINTAGE_GEO" => StylePresetV3.VINTAGEGEO,
                "VINTAGE_POSTER" => StylePresetV3.VINTAGEPOSTER,
                "WATERCOLOR" => StylePresetV3.WATERCOLOR,
                "WEIRD" => StylePresetV3.WEIRD,
                "WOODBLOCK_PRINT" => StylePresetV3.WOODBLOCKPRINT,
                _ => null,
            };
        }
    }
}

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
        x80sIllustration,
        /// <summary>
        /// 
        /// </summary>
        x90sNostalgia,
        /// <summary>
        /// 
        /// </summary>
        AbstractOrganic,
        /// <summary>
        /// 
        /// </summary>
        AnalogNostalgia,
        /// <summary>
        /// 
        /// </summary>
        ArtBrut,
        /// <summary>
        /// 
        /// </summary>
        ArtDeco,
        /// <summary>
        /// 
        /// </summary>
        ArtPoster,
        /// <summary>
        /// 
        /// </summary>
        Aura,
        /// <summary>
        /// 
        /// </summary>
        AvantGarde,
        /// <summary>
        /// 
        /// </summary>
        Bauhaus,
        /// <summary>
        /// 
        /// </summary>
        Blueprint,
        /// <summary>
        /// 
        /// </summary>
        BlurryMotion,
        /// <summary>
        /// 
        /// </summary>
        BrightArt,
        /// <summary>
        /// 
        /// </summary>
        C4dCartoon,
        /// <summary>
        /// 
        /// </summary>
        ChildrensBook,
        /// <summary>
        /// 
        /// </summary>
        Collage,
        /// <summary>
        /// 
        /// </summary>
        ColoringBookI,
        /// <summary>
        /// 
        /// </summary>
        ColoringBookIi,
        /// <summary>
        /// 
        /// </summary>
        Cubism,
        /// <summary>
        /// 
        /// </summary>
        DarkAura,
        /// <summary>
        /// 
        /// </summary>
        Doodle,
        /// <summary>
        /// 
        /// </summary>
        DoubleExposure,
        /// <summary>
        /// 
        /// </summary>
        DramaticCinema,
        /// <summary>
        /// 
        /// </summary>
        Editorial,
        /// <summary>
        /// 
        /// </summary>
        EmotionalMinimal,
        /// <summary>
        /// 
        /// </summary>
        EtherealParty,
        /// <summary>
        /// 
        /// </summary>
        ExpiredFilm,
        /// <summary>
        /// 
        /// </summary>
        FlatArt,
        /// <summary>
        /// 
        /// </summary>
        FlatVector,
        /// <summary>
        /// 
        /// </summary>
        ForestReverie,
        /// <summary>
        /// 
        /// </summary>
        GeoMinimalist,
        /// <summary>
        /// 
        /// </summary>
        GlassPrism,
        /// <summary>
        /// 
        /// </summary>
        GoldenHour,
        /// <summary>
        /// 
        /// </summary>
        GraffitiI,
        /// <summary>
        /// 
        /// </summary>
        GraffitiIi,
        /// <summary>
        /// 
        /// </summary>
        HalftonePrint,
        /// <summary>
        /// 
        /// </summary>
        HighContrast,
        /// <summary>
        /// 
        /// </summary>
        HippieEra,
        /// <summary>
        /// 
        /// </summary>
        Iconic,
        /// <summary>
        /// 
        /// </summary>
        JapandiFusion,
        /// <summary>
        /// 
        /// </summary>
        Jazzy,
        /// <summary>
        /// 
        /// </summary>
        LongExposure,
        /// <summary>
        /// 
        /// </summary>
        MagazineEditorial,
        /// <summary>
        /// 
        /// </summary>
        MinimalIllustration,
        /// <summary>
        /// 
        /// </summary>
        MixedMedia,
        /// <summary>
        /// 
        /// </summary>
        Monochrome,
        /// <summary>
        /// 
        /// </summary>
        Nightlife,
        /// <summary>
        /// 
        /// </summary>
        OilPainting,
        /// <summary>
        /// 
        /// </summary>
        OldCartoons,
        /// <summary>
        /// 
        /// </summary>
        PaintGesture,
        /// <summary>
        /// 
        /// </summary>
        PopArt,
        /// <summary>
        /// 
        /// </summary>
        RetroEtching,
        /// <summary>
        /// 
        /// </summary>
        RivieraPop,
        /// <summary>
        /// 
        /// </summary>
        Spotlight80s,
        /// <summary>
        /// 
        /// </summary>
        StylizedRed,
        /// <summary>
        /// 
        /// </summary>
        SurrealCollage,
        /// <summary>
        /// 
        /// </summary>
        TravelPoster,
        /// <summary>
        /// 
        /// </summary>
        VintageGeo,
        /// <summary>
        /// 
        /// </summary>
        VintagePoster,
        /// <summary>
        /// 
        /// </summary>
        Watercolor,
        /// <summary>
        /// 
        /// </summary>
        Weird,
        /// <summary>
        /// 
        /// </summary>
        WoodblockPrint,
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
                StylePresetV3.x80sIllustration => "80S_ILLUSTRATION",
                StylePresetV3.x90sNostalgia => "90S_NOSTALGIA",
                StylePresetV3.AbstractOrganic => "ABSTRACT_ORGANIC",
                StylePresetV3.AnalogNostalgia => "ANALOG_NOSTALGIA",
                StylePresetV3.ArtBrut => "ART_BRUT",
                StylePresetV3.ArtDeco => "ART_DECO",
                StylePresetV3.ArtPoster => "ART_POSTER",
                StylePresetV3.Aura => "AURA",
                StylePresetV3.AvantGarde => "AVANT_GARDE",
                StylePresetV3.Bauhaus => "BAUHAUS",
                StylePresetV3.Blueprint => "BLUEPRINT",
                StylePresetV3.BlurryMotion => "BLURRY_MOTION",
                StylePresetV3.BrightArt => "BRIGHT_ART",
                StylePresetV3.C4dCartoon => "C4D_CARTOON",
                StylePresetV3.ChildrensBook => "CHILDRENS_BOOK",
                StylePresetV3.Collage => "COLLAGE",
                StylePresetV3.ColoringBookI => "COLORING_BOOK_I",
                StylePresetV3.ColoringBookIi => "COLORING_BOOK_II",
                StylePresetV3.Cubism => "CUBISM",
                StylePresetV3.DarkAura => "DARK_AURA",
                StylePresetV3.Doodle => "DOODLE",
                StylePresetV3.DoubleExposure => "DOUBLE_EXPOSURE",
                StylePresetV3.DramaticCinema => "DRAMATIC_CINEMA",
                StylePresetV3.Editorial => "EDITORIAL",
                StylePresetV3.EmotionalMinimal => "EMOTIONAL_MINIMAL",
                StylePresetV3.EtherealParty => "ETHEREAL_PARTY",
                StylePresetV3.ExpiredFilm => "EXPIRED_FILM",
                StylePresetV3.FlatArt => "FLAT_ART",
                StylePresetV3.FlatVector => "FLAT_VECTOR",
                StylePresetV3.ForestReverie => "FOREST_REVERIE",
                StylePresetV3.GeoMinimalist => "GEO_MINIMALIST",
                StylePresetV3.GlassPrism => "GLASS_PRISM",
                StylePresetV3.GoldenHour => "GOLDEN_HOUR",
                StylePresetV3.GraffitiI => "GRAFFITI_I",
                StylePresetV3.GraffitiIi => "GRAFFITI_II",
                StylePresetV3.HalftonePrint => "HALFTONE_PRINT",
                StylePresetV3.HighContrast => "HIGH_CONTRAST",
                StylePresetV3.HippieEra => "HIPPIE_ERA",
                StylePresetV3.Iconic => "ICONIC",
                StylePresetV3.JapandiFusion => "JAPANDI_FUSION",
                StylePresetV3.Jazzy => "JAZZY",
                StylePresetV3.LongExposure => "LONG_EXPOSURE",
                StylePresetV3.MagazineEditorial => "MAGAZINE_EDITORIAL",
                StylePresetV3.MinimalIllustration => "MINIMAL_ILLUSTRATION",
                StylePresetV3.MixedMedia => "MIXED_MEDIA",
                StylePresetV3.Monochrome => "MONOCHROME",
                StylePresetV3.Nightlife => "NIGHTLIFE",
                StylePresetV3.OilPainting => "OIL_PAINTING",
                StylePresetV3.OldCartoons => "OLD_CARTOONS",
                StylePresetV3.PaintGesture => "PAINT_GESTURE",
                StylePresetV3.PopArt => "POP_ART",
                StylePresetV3.RetroEtching => "RETRO_ETCHING",
                StylePresetV3.RivieraPop => "RIVIERA_POP",
                StylePresetV3.Spotlight80s => "SPOTLIGHT_80S",
                StylePresetV3.StylizedRed => "STYLIZED_RED",
                StylePresetV3.SurrealCollage => "SURREAL_COLLAGE",
                StylePresetV3.TravelPoster => "TRAVEL_POSTER",
                StylePresetV3.VintageGeo => "VINTAGE_GEO",
                StylePresetV3.VintagePoster => "VINTAGE_POSTER",
                StylePresetV3.Watercolor => "WATERCOLOR",
                StylePresetV3.Weird => "WEIRD",
                StylePresetV3.WoodblockPrint => "WOODBLOCK_PRINT",
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
                "80S_ILLUSTRATION" => StylePresetV3.x80sIllustration,
                "90S_NOSTALGIA" => StylePresetV3.x90sNostalgia,
                "ABSTRACT_ORGANIC" => StylePresetV3.AbstractOrganic,
                "ANALOG_NOSTALGIA" => StylePresetV3.AnalogNostalgia,
                "ART_BRUT" => StylePresetV3.ArtBrut,
                "ART_DECO" => StylePresetV3.ArtDeco,
                "ART_POSTER" => StylePresetV3.ArtPoster,
                "AURA" => StylePresetV3.Aura,
                "AVANT_GARDE" => StylePresetV3.AvantGarde,
                "BAUHAUS" => StylePresetV3.Bauhaus,
                "BLUEPRINT" => StylePresetV3.Blueprint,
                "BLURRY_MOTION" => StylePresetV3.BlurryMotion,
                "BRIGHT_ART" => StylePresetV3.BrightArt,
                "C4D_CARTOON" => StylePresetV3.C4dCartoon,
                "CHILDRENS_BOOK" => StylePresetV3.ChildrensBook,
                "COLLAGE" => StylePresetV3.Collage,
                "COLORING_BOOK_I" => StylePresetV3.ColoringBookI,
                "COLORING_BOOK_II" => StylePresetV3.ColoringBookIi,
                "CUBISM" => StylePresetV3.Cubism,
                "DARK_AURA" => StylePresetV3.DarkAura,
                "DOODLE" => StylePresetV3.Doodle,
                "DOUBLE_EXPOSURE" => StylePresetV3.DoubleExposure,
                "DRAMATIC_CINEMA" => StylePresetV3.DramaticCinema,
                "EDITORIAL" => StylePresetV3.Editorial,
                "EMOTIONAL_MINIMAL" => StylePresetV3.EmotionalMinimal,
                "ETHEREAL_PARTY" => StylePresetV3.EtherealParty,
                "EXPIRED_FILM" => StylePresetV3.ExpiredFilm,
                "FLAT_ART" => StylePresetV3.FlatArt,
                "FLAT_VECTOR" => StylePresetV3.FlatVector,
                "FOREST_REVERIE" => StylePresetV3.ForestReverie,
                "GEO_MINIMALIST" => StylePresetV3.GeoMinimalist,
                "GLASS_PRISM" => StylePresetV3.GlassPrism,
                "GOLDEN_HOUR" => StylePresetV3.GoldenHour,
                "GRAFFITI_I" => StylePresetV3.GraffitiI,
                "GRAFFITI_II" => StylePresetV3.GraffitiIi,
                "HALFTONE_PRINT" => StylePresetV3.HalftonePrint,
                "HIGH_CONTRAST" => StylePresetV3.HighContrast,
                "HIPPIE_ERA" => StylePresetV3.HippieEra,
                "ICONIC" => StylePresetV3.Iconic,
                "JAPANDI_FUSION" => StylePresetV3.JapandiFusion,
                "JAZZY" => StylePresetV3.Jazzy,
                "LONG_EXPOSURE" => StylePresetV3.LongExposure,
                "MAGAZINE_EDITORIAL" => StylePresetV3.MagazineEditorial,
                "MINIMAL_ILLUSTRATION" => StylePresetV3.MinimalIllustration,
                "MIXED_MEDIA" => StylePresetV3.MixedMedia,
                "MONOCHROME" => StylePresetV3.Monochrome,
                "NIGHTLIFE" => StylePresetV3.Nightlife,
                "OIL_PAINTING" => StylePresetV3.OilPainting,
                "OLD_CARTOONS" => StylePresetV3.OldCartoons,
                "PAINT_GESTURE" => StylePresetV3.PaintGesture,
                "POP_ART" => StylePresetV3.PopArt,
                "RETRO_ETCHING" => StylePresetV3.RetroEtching,
                "RIVIERA_POP" => StylePresetV3.RivieraPop,
                "SPOTLIGHT_80S" => StylePresetV3.Spotlight80s,
                "STYLIZED_RED" => StylePresetV3.StylizedRed,
                "SURREAL_COLLAGE" => StylePresetV3.SurrealCollage,
                "TRAVEL_POSTER" => StylePresetV3.TravelPoster,
                "VINTAGE_GEO" => StylePresetV3.VintageGeo,
                "VINTAGE_POSTER" => StylePresetV3.VintagePoster,
                "WATERCOLOR" => StylePresetV3.Watercolor,
                "WEIRD" => StylePresetV3.Weird,
                "WOODBLOCK_PRINT" => StylePresetV3.WoodblockPrint,
                _ => null,
            };
        }
    }
}
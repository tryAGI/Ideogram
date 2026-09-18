
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A predefined style preset that applies a specific artistic style to the generated image.<br/>
    /// Example: bright_art
    /// </summary>
    public enum IdeogramV3StylePreset
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
    public static class IdeogramV3StylePresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdeogramV3StylePreset value)
        {
            return value switch
            {
                IdeogramV3StylePreset.x80sIllustration => "80s_illustration",
                IdeogramV3StylePreset.x90sNostalgia => "90s_nostalgia",
                IdeogramV3StylePreset.AbstractOrganic => "abstract_organic",
                IdeogramV3StylePreset.AnalogNostalgia => "analog_nostalgia",
                IdeogramV3StylePreset.ArtBrut => "art_brut",
                IdeogramV3StylePreset.ArtDeco => "art_deco",
                IdeogramV3StylePreset.ArtPoster => "art_poster",
                IdeogramV3StylePreset.Aura => "aura",
                IdeogramV3StylePreset.AvantGarde => "avant_garde",
                IdeogramV3StylePreset.Bauhaus => "bauhaus",
                IdeogramV3StylePreset.Blueprint => "blueprint",
                IdeogramV3StylePreset.BlurryMotion => "blurry_motion",
                IdeogramV3StylePreset.BrightArt => "bright_art",
                IdeogramV3StylePreset.C4dCartoon => "c4d_cartoon",
                IdeogramV3StylePreset.ChildrensBook => "childrens_book",
                IdeogramV3StylePreset.Collage => "collage",
                IdeogramV3StylePreset.ColoringBookI => "coloring_book_i",
                IdeogramV3StylePreset.ColoringBookIi => "coloring_book_ii",
                IdeogramV3StylePreset.Cubism => "cubism",
                IdeogramV3StylePreset.DarkAura => "dark_aura",
                IdeogramV3StylePreset.Doodle => "doodle",
                IdeogramV3StylePreset.DoubleExposure => "double_exposure",
                IdeogramV3StylePreset.DramaticCinema => "dramatic_cinema",
                IdeogramV3StylePreset.Editorial => "editorial",
                IdeogramV3StylePreset.EmotionalMinimal => "emotional_minimal",
                IdeogramV3StylePreset.EtherealParty => "ethereal_party",
                IdeogramV3StylePreset.ExpiredFilm => "expired_film",
                IdeogramV3StylePreset.FlatArt => "flat_art",
                IdeogramV3StylePreset.FlatVector => "flat_vector",
                IdeogramV3StylePreset.ForestReverie => "forest_reverie",
                IdeogramV3StylePreset.GeoMinimalist => "geo_minimalist",
                IdeogramV3StylePreset.GlassPrism => "glass_prism",
                IdeogramV3StylePreset.GoldenHour => "golden_hour",
                IdeogramV3StylePreset.GraffitiI => "graffiti_i",
                IdeogramV3StylePreset.GraffitiIi => "graffiti_ii",
                IdeogramV3StylePreset.HalftonePrint => "halftone_print",
                IdeogramV3StylePreset.HighContrast => "high_contrast",
                IdeogramV3StylePreset.HippieEra => "hippie_era",
                IdeogramV3StylePreset.Iconic => "iconic",
                IdeogramV3StylePreset.JapandiFusion => "japandi_fusion",
                IdeogramV3StylePreset.Jazzy => "jazzy",
                IdeogramV3StylePreset.LongExposure => "long_exposure",
                IdeogramV3StylePreset.MagazineEditorial => "magazine_editorial",
                IdeogramV3StylePreset.MinimalIllustration => "minimal_illustration",
                IdeogramV3StylePreset.MixedMedia => "mixed_media",
                IdeogramV3StylePreset.Monochrome => "monochrome",
                IdeogramV3StylePreset.Nightlife => "nightlife",
                IdeogramV3StylePreset.OilPainting => "oil_painting",
                IdeogramV3StylePreset.OldCartoons => "old_cartoons",
                IdeogramV3StylePreset.PaintGesture => "paint_gesture",
                IdeogramV3StylePreset.PopArt => "pop_art",
                IdeogramV3StylePreset.RetroEtching => "retro_etching",
                IdeogramV3StylePreset.RivieraPop => "riviera_pop",
                IdeogramV3StylePreset.Spotlight80s => "spotlight_80s",
                IdeogramV3StylePreset.StylizedRed => "stylized_red",
                IdeogramV3StylePreset.SurrealCollage => "surreal_collage",
                IdeogramV3StylePreset.TravelPoster => "travel_poster",
                IdeogramV3StylePreset.VintageGeo => "vintage_geo",
                IdeogramV3StylePreset.VintagePoster => "vintage_poster",
                IdeogramV3StylePreset.Watercolor => "watercolor",
                IdeogramV3StylePreset.Weird => "weird",
                IdeogramV3StylePreset.WoodblockPrint => "woodblock_print",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdeogramV3StylePreset? ToEnum(string value)
        {
            return value switch
            {
                "80s_illustration" => IdeogramV3StylePreset.x80sIllustration,
                "90s_nostalgia" => IdeogramV3StylePreset.x90sNostalgia,
                "abstract_organic" => IdeogramV3StylePreset.AbstractOrganic,
                "analog_nostalgia" => IdeogramV3StylePreset.AnalogNostalgia,
                "art_brut" => IdeogramV3StylePreset.ArtBrut,
                "art_deco" => IdeogramV3StylePreset.ArtDeco,
                "art_poster" => IdeogramV3StylePreset.ArtPoster,
                "aura" => IdeogramV3StylePreset.Aura,
                "avant_garde" => IdeogramV3StylePreset.AvantGarde,
                "bauhaus" => IdeogramV3StylePreset.Bauhaus,
                "blueprint" => IdeogramV3StylePreset.Blueprint,
                "blurry_motion" => IdeogramV3StylePreset.BlurryMotion,
                "bright_art" => IdeogramV3StylePreset.BrightArt,
                "c4d_cartoon" => IdeogramV3StylePreset.C4dCartoon,
                "childrens_book" => IdeogramV3StylePreset.ChildrensBook,
                "collage" => IdeogramV3StylePreset.Collage,
                "coloring_book_i" => IdeogramV3StylePreset.ColoringBookI,
                "coloring_book_ii" => IdeogramV3StylePreset.ColoringBookIi,
                "cubism" => IdeogramV3StylePreset.Cubism,
                "dark_aura" => IdeogramV3StylePreset.DarkAura,
                "doodle" => IdeogramV3StylePreset.Doodle,
                "double_exposure" => IdeogramV3StylePreset.DoubleExposure,
                "dramatic_cinema" => IdeogramV3StylePreset.DramaticCinema,
                "editorial" => IdeogramV3StylePreset.Editorial,
                "emotional_minimal" => IdeogramV3StylePreset.EmotionalMinimal,
                "ethereal_party" => IdeogramV3StylePreset.EtherealParty,
                "expired_film" => IdeogramV3StylePreset.ExpiredFilm,
                "flat_art" => IdeogramV3StylePreset.FlatArt,
                "flat_vector" => IdeogramV3StylePreset.FlatVector,
                "forest_reverie" => IdeogramV3StylePreset.ForestReverie,
                "geo_minimalist" => IdeogramV3StylePreset.GeoMinimalist,
                "glass_prism" => IdeogramV3StylePreset.GlassPrism,
                "golden_hour" => IdeogramV3StylePreset.GoldenHour,
                "graffiti_i" => IdeogramV3StylePreset.GraffitiI,
                "graffiti_ii" => IdeogramV3StylePreset.GraffitiIi,
                "halftone_print" => IdeogramV3StylePreset.HalftonePrint,
                "high_contrast" => IdeogramV3StylePreset.HighContrast,
                "hippie_era" => IdeogramV3StylePreset.HippieEra,
                "iconic" => IdeogramV3StylePreset.Iconic,
                "japandi_fusion" => IdeogramV3StylePreset.JapandiFusion,
                "jazzy" => IdeogramV3StylePreset.Jazzy,
                "long_exposure" => IdeogramV3StylePreset.LongExposure,
                "magazine_editorial" => IdeogramV3StylePreset.MagazineEditorial,
                "minimal_illustration" => IdeogramV3StylePreset.MinimalIllustration,
                "mixed_media" => IdeogramV3StylePreset.MixedMedia,
                "monochrome" => IdeogramV3StylePreset.Monochrome,
                "nightlife" => IdeogramV3StylePreset.Nightlife,
                "oil_painting" => IdeogramV3StylePreset.OilPainting,
                "old_cartoons" => IdeogramV3StylePreset.OldCartoons,
                "paint_gesture" => IdeogramV3StylePreset.PaintGesture,
                "pop_art" => IdeogramV3StylePreset.PopArt,
                "retro_etching" => IdeogramV3StylePreset.RetroEtching,
                "riviera_pop" => IdeogramV3StylePreset.RivieraPop,
                "spotlight_80s" => IdeogramV3StylePreset.Spotlight80s,
                "stylized_red" => IdeogramV3StylePreset.StylizedRed,
                "surreal_collage" => IdeogramV3StylePreset.SurrealCollage,
                "travel_poster" => IdeogramV3StylePreset.TravelPoster,
                "vintage_geo" => IdeogramV3StylePreset.VintageGeo,
                "vintage_poster" => IdeogramV3StylePreset.VintagePoster,
                "watercolor" => IdeogramV3StylePreset.Watercolor,
                "weird" => IdeogramV3StylePreset.Weird,
                "woodblock_print" => IdeogramV3StylePreset.WoodblockPrint,
                _ => null,
            };
        }
    }
}
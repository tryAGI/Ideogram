
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// The kind of mistake.
    /// </summary>
    public enum ImageJudgmentIssueCategory
    {
        /// <summary>
        ///
        /// </summary>
        BodiesHands,
        /// <summary>
        ///
        /// </summary>
        EditLeftovers,
        /// <summary>
        ///
        /// </summary>
        ImageQuality,
        /// <summary>
        ///
        /// </summary>
        LightingRealism,
        /// <summary>
        ///
        /// </summary>
        LogoText,
        /// <summary>
        ///
        /// </summary>
        Other,
        /// <summary>
        ///
        /// </summary>
        ProductBuilt,
        /// <summary>
        ///
        /// </summary>
        ProductLook,
        /// <summary>
        ///
        /// </summary>
        SceneGeometry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageJudgmentIssueCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageJudgmentIssueCategory value)
        {
            return value switch
            {
                ImageJudgmentIssueCategory.BodiesHands => "bodies_hands",
                ImageJudgmentIssueCategory.EditLeftovers => "edit_leftovers",
                ImageJudgmentIssueCategory.ImageQuality => "image_quality",
                ImageJudgmentIssueCategory.LightingRealism => "lighting_realism",
                ImageJudgmentIssueCategory.LogoText => "logo_text",
                ImageJudgmentIssueCategory.Other => "other",
                ImageJudgmentIssueCategory.ProductBuilt => "product_built",
                ImageJudgmentIssueCategory.ProductLook => "product_look",
                ImageJudgmentIssueCategory.SceneGeometry => "scene_geometry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageJudgmentIssueCategory? ToEnum(string value)
        {
            return value switch
            {
                "bodies_hands" => ImageJudgmentIssueCategory.BodiesHands,
                "edit_leftovers" => ImageJudgmentIssueCategory.EditLeftovers,
                "image_quality" => ImageJudgmentIssueCategory.ImageQuality,
                "lighting_realism" => ImageJudgmentIssueCategory.LightingRealism,
                "logo_text" => ImageJudgmentIssueCategory.LogoText,
                "other" => ImageJudgmentIssueCategory.Other,
                "product_built" => ImageJudgmentIssueCategory.ProductBuilt,
                "product_look" => ImageJudgmentIssueCategory.ProductLook,
                "scene_geometry" => ImageJudgmentIssueCategory.SceneGeometry,
                _ => null,
            };
        }
    }
}
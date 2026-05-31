
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateDesignRequestV4
    {
        /// <summary>
        /// The text prompt for editable design generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Random seed for reproducibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </summary>
        /// <example>ON</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MagicPromptOptionJsonConverter))]
        public global::Ideogram.MagicPromptOption? MagicPromptOption { get; set; }

        /// <summary>
        /// A base64url-encoded magic prompt system prompt config ID to use for this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt_system_prompt_config_id")]
        public string? MagicPromptSystemPromptConfigId { get; set; }

        /// <summary>
        /// The resolutions supported for Ideogram 4.0 layout-to-image and design generation.<br/>
        /// Example: 1024x1024
        /// </summary>
        /// <example>1024x1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ResolutionV4LayoutJsonConverter))]
        public global::Ideogram.ResolutionV4Layout? Resolution { get; set; }

        /// <summary>
        /// The rendering speed to use. For Ideogram V4, `rendering_speed=FLASH`<br/>
        /// is coming soon; requests with `rendering_speed=FLASH` currently<br/>
        /// return a 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendering_speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.RenderingSpeedJsonConverter))]
        public global::Ideogram.RenderingSpeed? RenderingSpeed { get; set; }

        /// <summary>
        /// Experimental. Up to 4 static inspiration images used as transferable visual style references for V4 layout-to-image design. Images are not edit targets and are not inserted into the generated HTML layout. Supported formats are JPEG, PNG, and WebP (max size 10MB each). Animated images are not supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inspiration_reference_images")]
        public global::System.Collections.Generic.IList<byte[]>? InspirationReferenceImages { get; set; }

        /// <summary>
        /// Experimental. Model to use for the inspiration vision prepass.<br/>
        /// Default Value: claude-sonnet-4-6
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inspiration_reference_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GenerateDesignRequestV4InspirationReferenceModelJsonConverter))]
        public global::Ideogram.GenerateDesignRequestV4InspirationReferenceModel? InspirationReferenceModel { get; set; }

        /// <summary>
        /// Experimental. Model to use for the HTML/layout and base-plate handoff generation call.<br/>
        /// Default Value: claude-sonnet-4-6
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_generation_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GenerateDesignRequestV4ArtifactGenerationModelJsonConverter))]
        public global::Ideogram.GenerateDesignRequestV4ArtifactGenerationModel? ArtifactGenerationModel { get; set; }

        /// <summary>
        /// Experimental. Staging only. Select a v4 layout-to-image pipeline variant.<br/>
        /// Omit for the default v4l2i path. Rejected on production.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout2image_variant")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GenerateDesignRequestV4Layout2imageVariantJsonConverter))]
        public global::Ideogram.GenerateDesignRequestV4Layout2imageVariant? Layout2imageVariant { get; set; }

        /// <summary>
        /// layered (default): full editable design payload with text layers and HTML.<br/>
        /// url: JSON with an expiring link to the final composited cover image.<br/>
        /// binary: raw PNG bytes of the final composited cover image (Content-Type image/png).<br/>
        /// html: raw HTML document of the generated layout (Content-Type text/html).<br/>
        /// Default Value: layered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GenerateDesignRequestV4ResponseTypeJsonConverter))]
        public global::Ideogram.GenerateDesignRequestV4ResponseType? ResponseType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDesignRequestV4" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The text prompt for editable design generation.
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.
        /// </param>
        /// <param name="magicPromptOption">
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </param>
        /// <param name="magicPromptSystemPromptConfigId">
        /// A base64url-encoded magic prompt system prompt config ID to use for this request.
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 4.0 layout-to-image and design generation.<br/>
        /// Example: 1024x1024
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use. For Ideogram V4, `rendering_speed=FLASH`<br/>
        /// is coming soon; requests with `rendering_speed=FLASH` currently<br/>
        /// return a 400.
        /// </param>
        /// <param name="inspirationReferenceImages">
        /// Experimental. Up to 4 static inspiration images used as transferable visual style references for V4 layout-to-image design. Images are not edit targets and are not inserted into the generated HTML layout. Supported formats are JPEG, PNG, and WebP (max size 10MB each). Animated images are not supported.
        /// </param>
        /// <param name="inspirationReferenceModel">
        /// Experimental. Model to use for the inspiration vision prepass.<br/>
        /// Default Value: claude-sonnet-4-6
        /// </param>
        /// <param name="artifactGenerationModel">
        /// Experimental. Model to use for the HTML/layout and base-plate handoff generation call.<br/>
        /// Default Value: claude-sonnet-4-6
        /// </param>
        /// <param name="layout2imageVariant">
        /// Experimental. Staging only. Select a v4 layout-to-image pipeline variant.<br/>
        /// Omit for the default v4l2i path. Rejected on production.
        /// </param>
        /// <param name="responseType">
        /// layered (default): full editable design payload with text layers and HTML.<br/>
        /// url: JSON with an expiring link to the final composited cover image.<br/>
        /// binary: raw PNG bytes of the final composited cover image (Content-Type image/png).<br/>
        /// html: raw HTML document of the generated layout (Content-Type text/html).<br/>
        /// Default Value: layered
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateDesignRequestV4(
            string prompt,
            int? seed,
            global::Ideogram.MagicPromptOption? magicPromptOption,
            string? magicPromptSystemPromptConfigId,
            global::Ideogram.ResolutionV4Layout? resolution,
            global::Ideogram.RenderingSpeed? renderingSpeed,
            global::System.Collections.Generic.IList<byte[]>? inspirationReferenceImages,
            global::Ideogram.GenerateDesignRequestV4InspirationReferenceModel? inspirationReferenceModel,
            global::Ideogram.GenerateDesignRequestV4ArtifactGenerationModel? artifactGenerationModel,
            global::Ideogram.GenerateDesignRequestV4Layout2imageVariant? layout2imageVariant,
            global::Ideogram.GenerateDesignRequestV4ResponseType? responseType)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Seed = seed;
            this.MagicPromptOption = magicPromptOption;
            this.MagicPromptSystemPromptConfigId = magicPromptSystemPromptConfigId;
            this.Resolution = resolution;
            this.RenderingSpeed = renderingSpeed;
            this.InspirationReferenceImages = inspirationReferenceImages;
            this.InspirationReferenceModel = inspirationReferenceModel;
            this.ArtifactGenerationModel = artifactGenerationModel;
            this.Layout2imageVariant = layout2imageVariant;
            this.ResponseType = responseType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDesignRequestV4" /> class.
        /// </summary>
        public GenerateDesignRequestV4()
        {
        }

    }
}
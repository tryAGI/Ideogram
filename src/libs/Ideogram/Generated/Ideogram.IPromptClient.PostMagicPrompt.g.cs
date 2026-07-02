#nullable enable

namespace Ideogram
{
    public partial interface IPromptClient
    {
        /// <summary>
        /// Generate Magic Prompt<br/>
        /// Transforms basic prompts into a magic prompt. Internal use only (feature flagged). TODO: update description if enabled externally.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.MagicPromptResponse> PostMagicPromptAsync(

            global::Ideogram.MagicPromptRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Magic Prompt<br/>
        /// Transforms basic prompts into a magic prompt. Internal use only (feature flagged). TODO: update description if enabled externally.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.MagicPromptResponse>> PostMagicPromptAsResponseAsync(

            global::Ideogram.MagicPromptRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Magic Prompt<br/>
        /// Transforms basic prompts into a magic prompt. Internal use only (feature flagged). TODO: update description if enabled externally.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to enhance with a magic prompt. Mutually<br/>
        /// exclusive with `messages`; one of the two must be set.<br/>
        /// Example: a cat
        /// </param>
        /// <param name="magicPromptVersion">
        /// The magic prompt version to use when magic prompt option is set to AUTO or ON.<br/>
        /// Example: V_0
        /// </param>
        /// <param name="classifyPromptCategory">
        /// Whether to classify the prompt into a use case category.<br/>
        /// Default Value: true<br/>
        /// Example: false
        /// </param>
        /// <param name="styleType">
        /// The style type to generate with.<br/>
        /// Default Value: GENERAL<br/>
        /// Example: GENERAL
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducible generation<br/>
        /// Example: 12345
        /// </param>
        /// <param name="characterReferenceImages">
        /// Generations with character reference are subject to the character reference pricing. A set of images to use as character references (maximum total size 10MB across all character references), currently only supports 1 character reference image. The images should be in JPEG, PNG or WebP format.
        /// </param>
        /// <param name="systemPrompt">
        /// A system prompt to use for the magic prompt.<br/>
        /// Example: You are a helpful assistant that generates magic prompts for images.
        /// </param>
        /// <param name="aspectRatio">
        /// Optional target aspect ratio used to condition the generated<br/>
        /// magic prompt's framing. Forwarded to the autoprompt pipeline<br/>
        /// so registry-driven system prompts that interpolate<br/>
        /// `` see the bucket the caller intends.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature override. Defaults to the trainer-conditioned<br/>
        /// value when omitted (0.7 for V4_QWEN_3_5_27B). Only honored with<br/>
        /// V4 magic-prompt versions; supplying it with another version<br/>
        /// returns 400.
        /// </param>
        /// <param name="topP">
        /// Nucleus-sampling top_p override. Only honored with V4 versions.
        /// </param>
        /// <param name="topK">
        /// Top-k sampling override. Only honored with V4 versions.
        /// </param>
        /// <param name="minP">
        /// min_p sampling override. Only honored with V4 versions.
        /// </param>
        /// <param name="maxTokens">
        /// Cap on the number of tokens the model may generate. Defaults to<br/>
        /// 4096 (the trainer's reference cap) when omitted. Only honored<br/>
        /// with V4 versions.
        /// </param>
        /// <param name="presencePenalty">
        /// Presence-penalty override. Only honored with V4 versions.
        /// </param>
        /// <param name="frequencyPenalty">
        /// Frequency-penalty override. Only honored with V4 versions.
        /// </param>
        /// <param name="repetitionPenalty">
        /// Repetition-penalty override. Only honored with V4 versions.
        /// </param>
        /// <param name="checkpoint">
        /// Optional override of the LoRA adapter the V4 magic-prompt<br/>
        /// wrapper downloads and runs. Pass a `gs://` URI pointing at a<br/>
        /// checkpoint directory containing `adapter_config.json`. When<br/>
        /// omitted, the wrapper-preloaded production checkpoint is used.<br/>
        /// Honored with the wrapper-routed LoRA versions<br/>
        /// `V4_QWEN_3_5_27B` and `V4_QWEN_3_5_27B_FULL_FINETUNE_LORA`;<br/>
        /// supplying it with `V4_QWEN_3_5_27B_PREFUSED` or<br/>
        /// `V4_QWEN_3_5_27B_FULL_FINETUNE` (which serve fixed weights and<br/>
        /// cannot swap adapters per request) or any other version returns<br/>
        /// 400.
        /// </param>
        /// <param name="messages">
        /// Pre-formed chat messages forwarded verbatim to V4. Mutually<br/>
        /// exclusive with `prompt`; exactly one must be set. V4 only.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.MagicPromptResponse> PostMagicPromptAsync(
            global::Ideogram.MagicPromptVersionEnum magicPromptVersion,
            bool classifyPromptCategory,
            string? prompt = default,
            global::Ideogram.StyleTypeV3? styleType = default,
            int? seed = default,
            global::System.Collections.Generic.IList<byte[]>? characterReferenceImages = default,
            string? systemPrompt = default,
            global::Ideogram.AspectRatioV3? aspectRatio = default,
            float? temperature = default,
            float? topP = default,
            int? topK = default,
            float? minP = default,
            int? maxTokens = default,
            float? presencePenalty = default,
            float? frequencyPenalty = default,
            float? repetitionPenalty = default,
            string? checkpoint = default,
            global::System.Collections.Generic.IList<global::Ideogram.MagicPromptRequestMessagesInner>? messages = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
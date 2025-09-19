#nullable enable

namespace Ideogram
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Initiate Batch Magic Prompt Evalution<br/>
        /// Runs automated evaluation of multiple LLM models and system prompts for magic prompt generation. <br/>
        /// Generates images using large batches of user prompt inputs. Internal use only (feature flagged).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.InternalBatchResponse> PostBatchAsync(
            global::Ideogram.InternalBatchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Initiate Batch Magic Prompt Evalution<br/>
        /// Runs automated evaluation of multiple LLM models and system prompts for magic prompt generation. <br/>
        /// Generates images using large batches of user prompt inputs. Internal use only (feature flagged).
        /// </summary>
        /// <param name="userPrompts">
        /// The prompts to enhance with a magic prompt.<br/>
        /// Example: [a cat, a dog]
        /// </param>
        /// <param name="experimentVariant">
        /// The experiment variant used for template selection for the magic prompts.<br/>
        /// Example: MAGIC_PROMPT_NO_TEXT
        /// </param>
        /// <param name="samplingRequestParams"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.InternalBatchResponse> PostBatchAsync(
            global::System.Collections.Generic.IList<string> userPrompts,
            string? experimentVariant = default,
            global::Ideogram.SamplingRequestParams? samplingRequestParams = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
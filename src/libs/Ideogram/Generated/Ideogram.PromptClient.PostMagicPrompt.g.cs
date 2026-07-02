
#nullable enable

namespace Ideogram
{
    public partial class PromptClient
    {


        private static readonly global::Ideogram.EndPointSecurityRequirement s_PostMagicPromptSecurityRequirement0 =
            new global::Ideogram.EndPointSecurityRequirement
            {
                Authorizations = new global::Ideogram.EndPointAuthorizationRequirement[]
                {                    new global::Ideogram.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Ideogram.EndPointSecurityRequirement[] s_PostMagicPromptSecurityRequirements =
            new global::Ideogram.EndPointSecurityRequirement[]
            {                s_PostMagicPromptSecurityRequirement0,
            };
        partial void PreparePostMagicPromptArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Ideogram.MagicPromptRequest request);
        partial void PreparePostMagicPromptRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Ideogram.MagicPromptRequest request);
        partial void ProcessPostMagicPromptResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPostMagicPromptResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate Magic Prompt<br/>
        /// Transforms basic prompts into a magic prompt. Internal use only (feature flagged). TODO: update description if enabled externally.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.MagicPromptResponse> PostMagicPromptAsync(

            global::Ideogram.MagicPromptRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await PostMagicPromptAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Generate Magic Prompt<br/>
        /// Transforms basic prompts into a magic prompt. Internal use only (feature flagged). TODO: update description if enabled externally.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.MagicPromptResponse>> PostMagicPromptAsResponseAsync(

            global::Ideogram.MagicPromptRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePostMagicPromptArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Ideogram.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PostMagicPromptSecurityRequirements,
                operationName: "PostMagicPromptAsync");

            using var __timeoutCancellationTokenSource = global::Ideogram.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Ideogram.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Ideogram.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Ideogram.PathBuilder(
                                path: "/magic-prompt",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Ideogram.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }

                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            if (request.Prompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Prompt ?? string.Empty),
                                    name: "\"prompt\"");

                            }
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(request.MagicPromptVersion.ToValueString()),
                                name: "\"magic_prompt_version\"");

                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.ClassifyPromptCategory, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                name: "\"classify_prompt_category\"");

                            if (request.StyleType != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.StyleType).HasValue ? (request.StyleType).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"style_type\"");

                            }
                            if (request.Seed != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Seed, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"seed\"");

                            }
                            if (request.CharacterReferenceImages != default)
                            {

                                for (var __iCharacterReferenceImages = 0; __iCharacterReferenceImages < request.CharacterReferenceImages.Count; __iCharacterReferenceImages++)
                                {
                                    var __contentCharacterReferenceImages = new global::System.Net.Http.ByteArrayContent(request.CharacterReferenceImages[__iCharacterReferenceImages]);
                                __contentCharacterReferenceImages.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
                                    __httpRequestContent.Add(
                                        content: __contentCharacterReferenceImages,
                                        name: "\"character_reference_images\"",
                                        fileName: $"\"file{__iCharacterReferenceImages}.bin\"");
                                    if (__contentCharacterReferenceImages.Headers.ContentDisposition != null)
                                    {
                                        __contentCharacterReferenceImages.Headers.ContentDisposition.FileNameStar = null;
                                    }
                                }

                            }
                            if (request.SystemPrompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.SystemPrompt ?? string.Empty),
                                    name: "\"system_prompt\"");

                            }
                            if (request.AspectRatio != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.AspectRatio).HasValue ? (request.AspectRatio).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"aspect_ratio\"");

                            }
                            if (request.Temperature != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Temperature, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"temperature\"");

                            }
                            if (request.TopP != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.TopP, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"top_p\"");

                            }
                            if (request.TopK != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.TopK, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"top_k\"");

                            }
                            if (request.MinP != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.MinP, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"min_p\"");

                            }
                            if (request.MaxTokens != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.MaxTokens, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"max_tokens\"");

                            }
                            if (request.PresencePenalty != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.PresencePenalty, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"presence_penalty\"");

                            }
                            if (request.FrequencyPenalty != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.FrequencyPenalty, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"frequency_penalty\"");

                            }
                            if (request.RepetitionPenalty != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.RepetitionPenalty, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"repetition_penalty\"");

                            }
                            if (request.Checkpoint != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Checkpoint ?? string.Empty),
                                    name: "\"checkpoint\"");

                            }
                            if (request.Messages != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.Messages, x => x.ToJson(JsonSerializerContext)))}]"),
                                    name: "\"messages\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::Ideogram.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PreparePostMagicPromptRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Ideogram.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Ideogram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PostMagicPrompt",
                                methodName: "PostMagicPromptAsync",
                                pathTemplate: "\"/magic-prompt\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Ideogram.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Ideogram.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Ideogram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PostMagicPrompt",
                                methodName: "PostMagicPromptAsync",
                                pathTemplate: "\"/magic-prompt\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Ideogram.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Ideogram.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Ideogram.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Ideogram.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Ideogram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PostMagicPrompt",
                                methodName: "PostMagicPromptAsync",
                                pathTemplate: "\"/magic-prompt\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Ideogram.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessPostMagicPromptResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Ideogram.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Ideogram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PostMagicPrompt",
                                methodName: "PostMagicPromptAsync",
                                pathTemplate: "\"/magic-prompt\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Ideogram.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Ideogram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PostMagicPrompt",
                                methodName: "PostMagicPromptAsync",
                                pathTemplate: "\"/magic-prompt\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // 
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Ideogram.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // 
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::Ideogram.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // 
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::Ideogram.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    responseBody: __content_429,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // 
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::Ideogram.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessPostMagicPromptResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Ideogram.MagicPromptResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Ideogram.AutoSDKHttpResponse<global::Ideogram.MagicPromptResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Ideogram.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Ideogram.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Ideogram.MagicPromptResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Ideogram.AutoSDKHttpResponse<global::Ideogram.MagicPromptResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Ideogram.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Ideogram.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
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
        public async global::System.Threading.Tasks.Task<global::Ideogram.MagicPromptResponse> PostMagicPromptAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Ideogram.MagicPromptRequest
            {
                Prompt = prompt,
                MagicPromptVersion = magicPromptVersion,
                ClassifyPromptCategory = classifyPromptCategory,
                StyleType = styleType,
                Seed = seed,
                CharacterReferenceImages = characterReferenceImages,
                SystemPrompt = systemPrompt,
                AspectRatio = aspectRatio,
                Temperature = temperature,
                TopP = topP,
                TopK = topK,
                MinP = minP,
                MaxTokens = maxTokens,
                PresencePenalty = presencePenalty,
                FrequencyPenalty = frequencyPenalty,
                RepetitionPenalty = repetitionPenalty,
                Checkpoint = checkpoint,
                Messages = messages,
            };

            return await PostMagicPromptAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
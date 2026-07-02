
#nullable enable

namespace Ideogram
{
    public partial class GenerateClient
    {


        private static readonly global::Ideogram.EndPointSecurityRequirement s_PostGenerateDesignV4SecurityRequirement0 =
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
        private static readonly global::Ideogram.EndPointSecurityRequirement[] s_PostGenerateDesignV4SecurityRequirements =
            new global::Ideogram.EndPointSecurityRequirement[]
            {                s_PostGenerateDesignV4SecurityRequirement0,
            };
        partial void PreparePostGenerateDesignV4Arguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Ideogram.GenerateDesignRequestV4 request);
        partial void PreparePostGenerateDesignV4Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Ideogram.GenerateDesignRequestV4 request);
        partial void ProcessPostGenerateDesignV4Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPostGenerateDesignV4ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate an editable design with Ideogram 4.0 HTML<br/>
        /// Experimental prototype endpoint for generating an editable V4 HTML design from a prompt.<br/>
        /// Optionally accepts inspiration reference images to guide transferable visual style. Inspiration images are design/style references only and are not edit targets.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.PostGenerateDesignV4200Response> PostGenerateDesignV4Async(

            global::Ideogram.GenerateDesignRequestV4 request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await PostGenerateDesignV4AsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Generate an editable design with Ideogram 4.0 HTML<br/>
        /// Experimental prototype endpoint for generating an editable V4 HTML design from a prompt.<br/>
        /// Optionally accepts inspiration reference images to guide transferable visual style. Inspiration images are design/style references only and are not edit targets.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.PostGenerateDesignV4200Response>> PostGenerateDesignV4AsResponseAsync(

            global::Ideogram.GenerateDesignRequestV4 request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePostGenerateDesignV4Arguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Ideogram.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PostGenerateDesignV4SecurityRequirements,
                operationName: "PostGenerateDesignV4Async");

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
                                path: "/v1/ideogram-v4/generate-design",
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
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent(request.Prompt ?? string.Empty),
                                name: "\"prompt\"");

                            if (request.Seed != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Seed, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"seed\"");

                            }
                            if (request.MagicPromptOption != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.MagicPromptOption).HasValue ? (request.MagicPromptOption).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"magic_prompt_option\"");

                            }
                            if (request.MagicPromptSystemPromptConfigId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.MagicPromptSystemPromptConfigId ?? string.Empty),
                                    name: "\"magic_prompt_system_prompt_config_id\"");

                            }
                            if (request.Resolution != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.Resolution).HasValue ? (request.Resolution).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"resolution\"");

                            }
                            if (request.RenderingSpeed != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.RenderingSpeed).HasValue ? (request.RenderingSpeed).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"rendering_speed\"");

                            }
                            if (request.InspirationReferenceImages != default)
                            {

                                for (var __iInspirationReferenceImages = 0; __iInspirationReferenceImages < request.InspirationReferenceImages.Count; __iInspirationReferenceImages++)
                                {
                                    var __contentInspirationReferenceImages = new global::System.Net.Http.ByteArrayContent(request.InspirationReferenceImages[__iInspirationReferenceImages]);
                                __contentInspirationReferenceImages.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
                                    __httpRequestContent.Add(
                                        content: __contentInspirationReferenceImages,
                                        name: "\"inspiration_reference_images\"",
                                        fileName: $"\"file{__iInspirationReferenceImages}.bin\"");
                                    if (__contentInspirationReferenceImages.Headers.ContentDisposition != null)
                                    {
                                        __contentInspirationReferenceImages.Headers.ContentDisposition.FileNameStar = null;
                                    }
                                }

                            }
                            if (request.InspirationReferenceModel != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.InspirationReferenceModel).HasValue ? (request.InspirationReferenceModel).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"inspiration_reference_model\"");

                            }
                            if (request.ArtifactGenerationModel != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.ArtifactGenerationModel).HasValue ? (request.ArtifactGenerationModel).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"artifact_generation_model\"");

                            }
                            if (request.Layout2imageVariant != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.Layout2imageVariant).HasValue ? (request.Layout2imageVariant).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"layout2image_variant\"");

                            }
                            if (request.ResponseType != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.ResponseType).HasValue ? (request.ResponseType).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"response_type\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::Ideogram.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PreparePostGenerateDesignV4Request(
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
                                operationId: "PostGenerateDesignV4",
                                methodName: "PostGenerateDesignV4Async",
                                pathTemplate: "\"/v1/ideogram-v4/generate-design\"",
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
                                operationId: "PostGenerateDesignV4",
                                methodName: "PostGenerateDesignV4Async",
                                pathTemplate: "\"/v1/ideogram-v4/generate-design\"",
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
                                operationId: "PostGenerateDesignV4",
                                methodName: "PostGenerateDesignV4Async",
                                pathTemplate: "\"/v1/ideogram-v4/generate-design\"",
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
                ProcessPostGenerateDesignV4Response(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Ideogram.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Ideogram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PostGenerateDesignV4",
                                methodName: "PostGenerateDesignV4Async",
                                pathTemplate: "\"/v1/ideogram-v4/generate-design\"",
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
                                operationId: "PostGenerateDesignV4",
                                methodName: "PostGenerateDesignV4Async",
                                pathTemplate: "\"/v1/ideogram-v4/generate-design\"",
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
                            // Prompt failed the safety check.
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::Ideogram.GenerateImageSafetyError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::Ideogram.GenerateImageSafetyError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::Ideogram.GenerateImageSafetyError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::Ideogram.ApiException<global::Ideogram.GenerateImageSafetyError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
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
                                ProcessPostGenerateDesignV4ResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Ideogram.PostGenerateDesignV4200Response.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Ideogram.AutoSDKHttpResponse<global::Ideogram.PostGenerateDesignV4200Response>(
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

                                    var __value = await global::Ideogram.PostGenerateDesignV4200Response.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Ideogram.AutoSDKHttpResponse<global::Ideogram.PostGenerateDesignV4200Response>(
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
        /// Generate an editable design with Ideogram 4.0 HTML<br/>
        /// Experimental prototype endpoint for generating an editable V4 HTML design from a prompt.<br/>
        /// Optionally accepts inspiration reference images to guide transferable visual style. Inspiration images are design/style references only and are not edit targets.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.PostGenerateDesignV4200Response> PostGenerateDesignV4Async(
            string prompt,
            int? seed = default,
            global::Ideogram.MagicPromptOption? magicPromptOption = default,
            string? magicPromptSystemPromptConfigId = default,
            global::Ideogram.ResolutionV4Layout? resolution = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            global::System.Collections.Generic.IList<byte[]>? inspirationReferenceImages = default,
            global::Ideogram.GenerateDesignRequestV4InspirationReferenceModel? inspirationReferenceModel = default,
            global::Ideogram.GenerateDesignRequestV4ArtifactGenerationModel? artifactGenerationModel = default,
            global::Ideogram.GenerateDesignRequestV4Layout2imageVariant? layout2imageVariant = default,
            global::Ideogram.GenerateDesignRequestV4ResponseType? responseType = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Ideogram.GenerateDesignRequestV4
            {
                Prompt = prompt,
                Seed = seed,
                MagicPromptOption = magicPromptOption,
                MagicPromptSystemPromptConfigId = magicPromptSystemPromptConfigId,
                Resolution = resolution,
                RenderingSpeed = renderingSpeed,
                InspirationReferenceImages = inspirationReferenceImages,
                InspirationReferenceModel = inspirationReferenceModel,
                ArtifactGenerationModel = artifactGenerationModel,
                Layout2imageVariant = layout2imageVariant,
                ResponseType = responseType,
            };

            return await PostGenerateDesignV4Async(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
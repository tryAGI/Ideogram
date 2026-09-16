
#nullable enable

namespace Ideogram
{
    public partial class AutoModelClient
    {


        private static readonly global::Ideogram.EndPointSecurityRequirement s_PostToolRemixSecurityRequirement0 =
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
        private static readonly global::Ideogram.EndPointSecurityRequirement[] s_PostToolRemixSecurityRequirements =
            new global::Ideogram.EndPointSecurityRequirement[]
            {                s_PostToolRemixSecurityRequirement0,
            };
        partial void PreparePostToolRemixArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? dryRun,
            global::Ideogram.ToolRemixRequest request);
        partial void PreparePostToolRemixRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? dryRun,
            global::Ideogram.ToolRemixRequest request);
        partial void ProcessPostToolRemixResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPostToolRemixResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Remix an existing image, letting the server pick the best model<br/>
        /// Transform an existing image with a server-selected model, guided by a<br/>
        /// text prompt. Supply the source as `image` bytes (multipart requests<br/>
        /// only). `image_weight` controls how closely the result follows the<br/>
        /// source; when omitted the selected model chooses its usual strength.<br/>
        /// The server chooses a model that supports the requested remix controls:<br/>
        /// style references (ad hoc or saved), a color palette, style codes, a<br/>
        /// style preset, and a non-`AUTO` style type each<br/>
        /// restrict the request to a compatible model and to the 1K tier;<br/>
        /// remixes without those controls use the default model. Omit<br/>
        /// `resolution` and `aspect_ratio` to keep the source image's shape.<br/>
        /// Supplying `image_weight` together with a `resolution` or<br/>
        /// `aspect_ratio` that changes the source's aspect ratio routes the<br/>
        /// request to a model that crops the source to the new shape; that<br/>
        /// combination is served only at the 1K tier and is rejected at 2K.<br/>
        /// (The model-pinned remix endpoints such as<br/>
        /// `/v2/image/remix/ideogram-v4` reject the combination outright.)<br/>
        /// `seed` is honored only on the compatible model; the default model<br/>
        /// synthesizes an unseeded instruction prompt, so results are not<br/>
        /// reproducible there.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately after the<br/>
        /// request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.ToolRemixResponse> PostToolRemixAsync(

            global::Ideogram.ToolRemixRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await PostToolRemixAsResponseAsync(

                request: request,
                dryRun: dryRun,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Remix an existing image, letting the server pick the best model<br/>
        /// Transform an existing image with a server-selected model, guided by a<br/>
        /// text prompt. Supply the source as `image` bytes (multipart requests<br/>
        /// only). `image_weight` controls how closely the result follows the<br/>
        /// source; when omitted the selected model chooses its usual strength.<br/>
        /// The server chooses a model that supports the requested remix controls:<br/>
        /// style references (ad hoc or saved), a color palette, style codes, a<br/>
        /// style preset, and a non-`AUTO` style type each<br/>
        /// restrict the request to a compatible model and to the 1K tier;<br/>
        /// remixes without those controls use the default model. Omit<br/>
        /// `resolution` and `aspect_ratio` to keep the source image's shape.<br/>
        /// Supplying `image_weight` together with a `resolution` or<br/>
        /// `aspect_ratio` that changes the source's aspect ratio routes the<br/>
        /// request to a model that crops the source to the new shape; that<br/>
        /// combination is served only at the 1K tier and is rejected at 2K.<br/>
        /// (The model-pinned remix endpoints such as<br/>
        /// `/v2/image/remix/ideogram-v4` reject the combination outright.)<br/>
        /// `seed` is honored only on the compatible model; the default model<br/>
        /// synthesizes an unseeded instruction prompt, so results are not<br/>
        /// reproducible there.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately after the<br/>
        /// request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ToolRemixResponse>> PostToolRemixAsResponseAsync(

            global::Ideogram.ToolRemixRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePostToolRemixArguments(
                httpClient: HttpClient,
                dryRun: ref dryRun,
                request: request);


            var __authorizations = global::Ideogram.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PostToolRemixSecurityRequirements,
                operationName: "PostToolRemixAsync");

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
                                path: "/v2/image/remix/auto",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("dry_run", dryRun?.ToString().ToLowerInvariant())
                                ;
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

                            if (request.ImageAssetIdentifier != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.ImageAssetIdentifier.ToJson(JsonSerializerContext)),
                                    name: "\"image_asset_identifier\"");

                            }
                            if (request.Image != default)
                            {

                                var __contentImage = new global::System.Net.Http.ByteArrayContent(request.Image ?? global::System.Array.Empty<byte>());
                                __contentImage.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.Imagename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.Imagename) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentImage,
                                    name: "\"image\"",
                                    fileName: request.Imagename != null ? $"\"{request.Imagename}\"" : string.Empty);
                                if (__contentImage.Headers.ContentDisposition != null)
                                {
                                    __contentImage.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.ImageWeight != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.ImageWeight, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"image_weight\"");

                            }
                            if (request.NegativePrompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.NegativePrompt ?? string.Empty),
                                    name: "\"negative_prompt\"");

                            }
                            if (request.Resolution != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Resolution ?? string.Empty),
                                    name: "\"resolution\"");

                            }
                            if (request.AspectRatio != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.AspectRatio).HasValue ? (request.AspectRatio).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"aspect_ratio\"");

                            }
                            if (request.ResolutionTier != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.ResolutionTier).HasValue ? (request.ResolutionTier).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"resolution_tier\"");

                            }
                            if (request.MagicPrompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.MagicPrompt).HasValue ? (request.MagicPrompt).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"magic_prompt\"");

                            }
                            if (request.Seed != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Seed, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"seed\"");

                            }
                            if (request.StyleReferenceAssetIdentifiers != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.StyleReferenceAssetIdentifiers!, x => x.ToJson(JsonSerializerContext)))}]"),
                                    name: "\"style_reference_asset_identifiers\"");

                            }
                            if (request.StyleReferenceCollectionId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.StyleReferenceCollectionId ?? string.Empty),
                                    name: "\"style_reference_collection_id\"");

                            }
                            if (request.StyleReferenceCollectionVersionId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.StyleReferenceCollectionVersionId ?? string.Empty),
                                    name: "\"style_reference_collection_version_id\"");

                            }
                            if (request.StylePreset != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.StylePreset).HasValue ? (request.StylePreset).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"style_preset\"");

                            }
                            if (request.ColorPalette != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.ColorPalette.ToString() ?? string.Empty),
                                    name: "\"color_palette\"");

                            }
                            if (request.StyleCodes != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.StyleCodes!, x => x))}]"),
                                    name: "\"style_codes\"");

                            }
                            if (request.StyleType != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.StyleType).HasValue ? (request.StyleType).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"style_type\"");

                            }
                            if (request.NumImages != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.NumImages, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"num_images\"");

                            }
                            if (request.EnableCopyrightDetection != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.EnableCopyrightDetection, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"enable_copyright_detection\"");

                            }
                            if (request.Async != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.Async, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"async\"");

                            }
                            if (request.WebhookUrl != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.WebhookUrl ?? string.Empty),
                                    name: "\"webhook_url\"");

                            }
                            if (request.Private != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.Private, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"private\"");

                            }
                            if (request.TargetCollectionId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.TargetCollectionId ?? string.Empty),
                                    name: "\"target_collection_id\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::Ideogram.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PreparePostToolRemixRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    dryRun: dryRun,
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
                                operationId: "PostToolRemix",
                                methodName: "PostToolRemixAsync",
                                pathTemplate: "\"/v2/image/remix/auto\"",
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
                                operationId: "PostToolRemix",
                                methodName: "PostToolRemixAsync",
                                pathTemplate: "\"/v2/image/remix/auto\"",
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
                                operationId: "PostToolRemix",
                                methodName: "PostToolRemixAsync",
                                pathTemplate: "\"/v2/image/remix/auto\"",
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
                ProcessPostToolRemixResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Ideogram.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Ideogram.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PostToolRemix",
                                methodName: "PostToolRemixAsync",
                                pathTemplate: "\"/v2/image/remix/auto\"",
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
                                operationId: "PostToolRemix",
                                methodName: "PostToolRemixAsync",
                                pathTemplate: "\"/v2/image/remix/auto\"",
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
                            if ((int)__response.StatusCode == 402)
                            {
                                string? __content_402 = null;
                                global::System.Exception? __exception_402 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_402 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_402 = __ex;
                                }


                                throw global::Ideogram.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_402 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_402,
                                    responseBody: __content_402,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            //
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::Ideogram.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            //
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::Ideogram.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
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
                            //
                            if ((int)__response.StatusCode == 503)
                            {
                                string? __content_503 = null;
                                global::System.Exception? __exception_503 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_503 = __ex;
                                }


                                throw global::Ideogram.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_503 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_503,
                                    responseBody: __content_503,
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
                                ProcessPostToolRemixResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Ideogram.ToolRemixResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ToolRemixResponse>(
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

                                    var __value = await global::Ideogram.ToolRemixResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ToolRemixResponse>(
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
        /// Remix an existing image, letting the server pick the best model<br/>
        /// Transform an existing image with a server-selected model, guided by a<br/>
        /// text prompt. Supply the source as `image` bytes (multipart requests<br/>
        /// only). `image_weight` controls how closely the result follows the<br/>
        /// source; when omitted the selected model chooses its usual strength.<br/>
        /// The server chooses a model that supports the requested remix controls:<br/>
        /// style references (ad hoc or saved), a color palette, style codes, a<br/>
        /// style preset, and a non-`AUTO` style type each<br/>
        /// restrict the request to a compatible model and to the 1K tier;<br/>
        /// remixes without those controls use the default model. Omit<br/>
        /// `resolution` and `aspect_ratio` to keep the source image's shape.<br/>
        /// Supplying `image_weight` together with a `resolution` or<br/>
        /// `aspect_ratio` that changes the source's aspect ratio routes the<br/>
        /// request to a model that crops the source to the new shape; that<br/>
        /// combination is served only at the 1K tier and is rejected at 2K.<br/>
        /// (The model-pinned remix endpoints such as<br/>
        /// `/v2/image/remix/ideogram-v4` reject the combination outright.)<br/>
        /// `seed` is honored only on the compatible model; the default model<br/>
        /// synthesizes an unseeded instruction prompt, so results are not<br/>
        /// reproducible there.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately after the<br/>
        /// request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The prompt that guides the remix.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// The existing upload or generated image to transform. Supply this or `image`, never both. Omit `resolution` and `aspect_ratio` to keep its shape.
        /// </param>
        /// <param name="image">
        /// The image to transform (max size 50MB), as raw bytes; only JPEG, PNG and WEBP are supported. Multipart requests only. Supply this or `image_asset_identifier`, never both. The bytes are staged for this generation request and are not added to your account's image assets.
        /// </param>
        /// <param name="imagename">
        /// The image to transform (max size 50MB), as raw bytes; only JPEG, PNG and WEBP are supported. Multipart requests only. Supply this or `image_asset_identifier`, never both. The bytes are staged for this generation request and are not added to your account's image assets.
        /// </param>
        /// <param name="imageWeight">
        /// Optional. How closely the result should follow the source image, from 1 to 100. When omitted the selected model chooses its usual strength. Combining a weight with a `resolution` or `aspect_ratio` that changes the source's aspect ratio requires the 1K tier.
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to exclude from the images. Descriptions in the prompt take precedence over descriptions in the negative prompt. Not every model consults it.
        /// </param>
        /// <param name="resolution">
        /// The requested output resolution, formatted as "WIDTHxHEIGHT" (for example "1280x800"). The output is served at the closest resolution the selected model supports in the corresponding 1K or 2K tier. Omit `aspect_ratio` when supplying a resolution. If `resolution_tier` is also supplied, it must match the tier implied by these dimensions. Combining a shape-changing value with `image_weight` requires the 1K tier.
        /// </param>
        /// <param name="aspectRatio">
        /// The requested output aspect ratio. Omit it to keep the source image's shape. `AUTO` also keeps the source shape. Omit `resolution` when supplying a concrete value. Combining a shape-changing value with `image_weight` requires the 1K tier.
        /// </param>
        /// <param name="resolutionTier">
        /// The output resolution tier. Influences which model serves the request. When omitted, the tier is inferred from `resolution`, or defaults to 1K when no exact resolution is supplied. Inputs that restrict the server's model choice (style references, saved styles, a color palette, style codes, a style preset, or a non-`AUTO` style type) currently support only 1K AUTO remixes.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `AUTO`. The selected model decides how to interpret it.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="seed">
        /// Optional. Honored when the server selects the model that supports deterministic remixes; the default model synthesizes its own prompt, so results are not reproducible there. The response reports the seed used.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="styleReferenceAssetIdentifiers">
        /// Existing upload or generated image assets whose style should guide the remix, by reference. Supplying style references restricts the server to a model that supports them and requires the 1K resolution tier. Ignored if `style_reference_collection_id` is also supplied.
        /// </param>
        /// <param name="styleReferenceCollectionId">
        /// A saved style to apply, by its URL-safe base64 collection id. Takes priority over `style_reference_asset_identifiers`. Restricts the server to a model that supports style references and requires the 1K resolution tier.
        /// </param>
        /// <param name="styleReferenceCollectionVersionId">
        /// Optional URL-safe base64 version id pinning a specific version of the `style_reference_collection_id` collection. Ignored without it.
        /// </param>
        /// <param name="stylePreset">
        /// A predefined style preset to apply. Restricts the server to a model that supports it and requires the 1K resolution tier. Cannot be combined with style codes or style references.
        /// </param>
        /// <param name="colorPalette">
        /// A color palette to apply. Restricts the server to a model that supports palettes and requires the 1K resolution tier.
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.<br/>
        /// Example: [AAFF5733, 0133FF57, DE3357FF]
        /// </param>
        /// <param name="styleType">
        /// The style type to generate with. A value other than `AUTO` restricts the server to a model that supports it and requires the 1K resolution tier.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images come back with `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request blocks until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v1/generations/{generation_id}` using the returned `generation_id`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl">
        /// HTTPS URL that Ideogram delivers the generated result to. Ideogram sends a<br/>
        /// JSON POST to this URL once all images for the request have finished<br/>
        /// generating. The body mirrors the synchronous generate response:<br/>
        /// `request_id`, `created`, and a `data` array<br/>
        /// containing every generated image (`url`, `prompt`, `resolution`, `seed`,<br/>
        /// `is_image_safe`). Each delivery is signed with Ed25519 and verifiable<br/>
        /// against the public keys at `https://api.ideogram.ai/v1/.well-known/jwks.json`. Must be HTTPS;<br/>
        /// private and loopback hosts and the cloud metadata service are rejected.<br/>
        /// Example: https://api.example.com/webhooks/ideogram
        /// </param>
        /// <param name="private">
        /// Whether the generated images should be kept private. Omitted or true keeps them private. False publishes them unless the caller's plan always generates privately.
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. The output images are added to it when the request completes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.ToolRemixResponse> PostToolRemixAsync(
            string prompt,
            bool? dryRun = default,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            int? imageWeight = default,
            string? negativePrompt = default,
            string? resolution = default,
            global::Ideogram.AspectRatioV4? aspectRatio = default,
            global::Ideogram.ToolRemixRequestResolutionTier? resolutionTier = default,
            global::Ideogram.MagicPromptOption? magicPrompt = default,
            int? seed = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? styleReferenceAssetIdentifiers = default,
            string? styleReferenceCollectionId = default,
            string? styleReferenceCollectionVersionId = default,
            global::Ideogram.StylePresetV3? stylePreset = default,
            global::Ideogram.ColorPaletteWithPresetNameOrMembers? colorPalette = default,
            global::System.Collections.Generic.IList<string>? styleCodes = default,
            global::Ideogram.StyleTypeV3? styleType = default,
            int? numImages = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            string? webhookUrl = default,
            bool? @private = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Ideogram.ToolRemixRequest
            {
                Prompt = prompt,
                ImageAssetIdentifier = imageAssetIdentifier,
                Image = image,
                Imagename = imagename,
                ImageWeight = imageWeight,
                NegativePrompt = negativePrompt,
                Resolution = resolution,
                AspectRatio = aspectRatio,
                ResolutionTier = resolutionTier,
                MagicPrompt = magicPrompt,
                Seed = seed,
                StyleReferenceAssetIdentifiers = styleReferenceAssetIdentifiers,
                StyleReferenceCollectionId = styleReferenceCollectionId,
                StyleReferenceCollectionVersionId = styleReferenceCollectionVersionId,
                StylePreset = stylePreset,
                ColorPalette = colorPalette,
                StyleCodes = styleCodes,
                StyleType = styleType,
                NumImages = numImages,
                EnableCopyrightDetection = enableCopyrightDetection,
                Async = async,
                WebhookUrl = webhookUrl,
                Private = @private,
                TargetCollectionId = targetCollectionId,
            };

            return await PostToolRemixAsync(
                dryRun: dryRun,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
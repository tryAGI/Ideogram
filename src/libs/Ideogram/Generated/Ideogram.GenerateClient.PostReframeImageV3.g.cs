
#nullable enable

namespace Ideogram
{
    public partial class GenerateClient
    {
        partial void PreparePostReframeImageV3Arguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Ideogram.ReframeImageRequestV3 request);
        partial void PreparePostReframeImageV3Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Ideogram.ReframeImageRequestV3 request);
        partial void ProcessPostReframeImageV3Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPostReframeImageV3ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Reframe with Ideogram 3.0<br/>
        /// Reframe a square image to a chosen resolution with Ideogram 3.0. The supported image formats include JPEG, PNG, and WebP.<br/>
        /// Image links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV3> PostReframeImageV3Async(
            global::Ideogram.ReframeImageRequestV3 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePostReframeImageV3Arguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Ideogram.PathBuilder(
                path: "/v1/ideogram-v3/reframe",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
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
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.Image ?? global::System.Array.Empty<byte>()),
                name: "image",
                fileName: request.Imagename ?? string.Empty);
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Resolution.ToValueString()}"),
                name: "resolution");
            if (request.NumImages != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.NumImages}"),
                    name: "num_images");
            } 
            if (request.Seed != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Seed}"),
                    name: "seed");
            } 
            if (request.RenderingSpeed != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.RenderingSpeed?.ToValueString()}"),
                    name: "rendering_speed");
            } 
            if (request.ColorPalette != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent(request.ColorPalette?.ToString() ?? string.Empty),
                    name: "color_palette");
            } 
            if (request.StyleCodes != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.StyleCodes, x => x))}]"),
                    name: "style_codes");
            } 
            if (request.StyleReferenceImages != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.StyleReferenceImages, x => x))}]"),
                    name: "style_reference_images");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePostReframeImageV3Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPostReframeImageV3Response(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Ideogram.ApiException(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::Ideogram.ApiException(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Prompt or Image failed the safety checks.
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::Ideogram.GenerateImageSafetyError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::Ideogram.GenerateImageSafetyError.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = await global::Ideogram.GenerateImageSafetyError.FromJsonStreamAsync(__contentStream_422, JsonSerializerContext).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::Ideogram.ApiException<global::Ideogram.GenerateImageSafetyError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        var __contentStream_429 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::Ideogram.ApiException(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessPostReframeImageV3ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Ideogram.ImageGenerationResponseV3.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Ideogram.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Ideogram.ImageGenerationResponseV3.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Ideogram.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }

        /// <summary>
        /// Reframe with Ideogram 3.0<br/>
        /// Reframe a square image to a chosen resolution with Ideogram 3.0. The supported image formats include JPEG, PNG, and WebP.<br/>
        /// Image links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="image">
        /// The image being reframed (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imagename">
        /// The image being reframed (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 3.0.<br/>
        /// Example: 1280x800
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="colorPalette">
        /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members). Not supported by V_1, V_1_TURBO, V_2A and V_2A_TURBO models.
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8 character hexadecimal codes representing the style of the image. Cannot be used in conjunction with style_reference_images or style_type.<br/>
        /// Example: [AAFF5733, 0133FF57, DE3357FF]
        /// </param>
        /// <param name="styleReferenceImages">
        /// A set of images to use as style references (maximum total size 10MB across all style references). The images should be in JPEG, PNG or WebP format.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV3> PostReframeImageV3Async(
            byte[] image,
            string imagename,
            global::Ideogram.ResolutionV3 resolution,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            global::Ideogram.ColorPaletteWithPresetNameOrMembers? colorPalette = default,
            global::System.Collections.Generic.IList<string>? styleCodes = default,
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Ideogram.ReframeImageRequestV3
            {
                Image = image,
                Imagename = imagename,
                Resolution = resolution,
                NumImages = numImages,
                Seed = seed,
                RenderingSpeed = renderingSpeed,
                ColorPalette = colorPalette,
                StyleCodes = styleCodes,
                StyleReferenceImages = styleReferenceImages,
            };

            return await PostReframeImageV3Async(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}

#nullable enable

namespace Ideogram
{
    public partial class GenerateClient
    {


        private static readonly global::Ideogram.EndPointSecurityRequirement s_PostTryOnV3SecurityRequirement0 =
            new global::Ideogram.EndPointSecurityRequirement
            {
                Authorizations = new global::Ideogram.EndPointAuthorizationRequirement[]
                {                    new global::Ideogram.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Ideogram.EndPointSecurityRequirement[] s_PostTryOnV3SecurityRequirements =
            new global::Ideogram.EndPointSecurityRequirement[]
            {                s_PostTryOnV3SecurityRequirement0,
            };
        partial void PreparePostTryOnV3Arguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Ideogram.TryOnRequestV3 request);
        partial void PreparePostTryOnV3Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Ideogram.TryOnRequestV3 request);
        partial void ProcessPostTryOnV3Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPostTryOnV3ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Virtual Try-On with Ideogram 3.0<br/>
        /// Performs virtual clothing try-on by automatically segmenting the clothing in the provided image<br/>
        /// and replacing it based on the prompt. The user provides an image and an optional prompt describing<br/>
        /// the desired clothing change (e.g., "change his shirt to a pink shirt").<br/>
        /// Supported image formats include JPEG, PNG, and WebP.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV3> PostTryOnV3Async(

            global::Ideogram.TryOnRequestV3 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePostTryOnV3Arguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Ideogram.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PostTryOnV3SecurityRequirements,
                operationName: "PostTryOnV3Async");

            var __pathBuilder = new global::Ideogram.PathBuilder(
                path: "/v1/ideogram-v3/try-on",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            var __contentImage = new global::System.Net.Http.ByteArrayContent(request.Image ?? global::System.Array.Empty<byte>());
            __httpRequestContent.Add(
                content: __contentImage,
                name: "\"image\"",
                fileName: request.Imagename != null ? $"\"{request.Imagename}\"" : string.Empty);
            if (__contentImage.Headers.ContentDisposition != null)
            {
                __contentImage.Headers.ContentDisposition.FileNameStar = null;
            }
            if (request.Prompt != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Prompt}"),
                    name: "\"prompt\"");
            } 
            if (request.MagicPrompt != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.MagicPrompt?.ToValueString()}"),
                    name: "\"magic_prompt\"");
            } 
            if (request.NumImages != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.NumImages}"),
                    name: "\"num_images\"");
            } 
            if (request.Seed != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Seed}"),
                    name: "\"seed\"");
            } 
            if (request.RenderingSpeed != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.RenderingSpeed?.ToValueString()}"),
                    name: "\"rendering_speed\"");
            } 
            if (request.StyleType != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.StyleType?.ToValueString()}"),
                    name: "\"style_type\"");
            } 
            if (request.StylePreset != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.StylePreset?.ToValueString()}"),
                    name: "\"style_preset\"");
            }
            for (var __iProductReferenceImages = 0; __iProductReferenceImages < request.ProductReferenceImages.Count; __iProductReferenceImages++)
            {
                var __contentProductReferenceImages = new global::System.Net.Http.ByteArrayContent(request.ProductReferenceImages[__iProductReferenceImages]);
                __httpRequestContent.Add(
                    content: __contentProductReferenceImages,
                    name: "\"product_reference_images\"",
                    fileName: $"\"file{__iProductReferenceImages}.bin\"");
                if (__contentProductReferenceImages.Headers.ContentDisposition != null)
                {
                    __contentProductReferenceImages.Headers.ContentDisposition.FileNameStar = null;
                }
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePostTryOnV3Request(
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
            ProcessPostTryOnV3Response(
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
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
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
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
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
            // Prompt or provided image failed safety check, or clothing segmentation failed.
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
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::Ideogram.GenerateImageSafetyError.FromJson(__content_422, JsonSerializerContext);
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
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
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
                ProcessPostTryOnV3ResponseContent(
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
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

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
        }
        /// <summary>
        /// Virtual Try-On with Ideogram 3.0<br/>
        /// Performs virtual clothing try-on by automatically segmenting the clothing in the provided image<br/>
        /// and replacing it based on the prompt. The user provides an image and an optional prompt describing<br/>
        /// the desired clothing change (e.g., "change his shirt to a pink shirt").<br/>
        /// Supported image formats include JPEG, PNG, and WebP.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="image">
        /// The image containing a person wearing clothing to be modified (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imagename">
        /// The image containing a person wearing clothing to be modified (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="prompt">
        /// The prompt describing the desired clothing change. Defaults to "Person wearing this piece of clothing" if omitted or empty.<br/>
        /// Default Value: Person wearing this piece of clothing<br/>
        /// Example: Change his shirt to a pink shirt
        /// </param>
        /// <param name="magicPrompt">
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
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
        /// <param name="styleType">
        /// The style type to generate with.<br/>
        /// Default Value: GENERAL<br/>
        /// Example: GENERAL
        /// </param>
        /// <param name="stylePreset">
        /// A predefined style preset that applies a specific artistic style to the generated image.<br/>
        /// Example: BRIGHT_ART
        /// </param>
        /// <param name="productReferenceImages">
        /// An image to use as the product reference for the try-on (exactly 1 image required). The image should be in JPEG, PNG or WebP format.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV3> PostTryOnV3Async(
            byte[] image,
            string imagename,
            global::System.Collections.Generic.IList<byte[]> productReferenceImages,
            string? prompt = default,
            global::Ideogram.MagicPromptOption? magicPrompt = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            global::Ideogram.StyleTypeV3? styleType = default,
            global::Ideogram.StylePresetV3? stylePreset = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Ideogram.TryOnRequestV3
            {
                Image = image,
                Imagename = imagename,
                Prompt = prompt,
                MagicPrompt = magicPrompt,
                NumImages = numImages,
                Seed = seed,
                RenderingSpeed = renderingSpeed,
                StyleType = styleType,
                StylePreset = stylePreset,
                ProductReferenceImages = productReferenceImages,
            };

            return await PostTryOnV3Async(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
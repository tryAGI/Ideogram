
#nullable enable

namespace Ideogram
{
    public partial class GenerateClient
    {
        partial void PreparePostLayerizeDesignV3Arguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Ideogram.LayerizeDesignRequestV3 request);
        partial void PreparePostLayerizeDesignV3Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Ideogram.LayerizeDesignRequestV3 request);
        partial void ProcessPostLayerizeDesignV3Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPostLayerizeDesignV3ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Layerize an existing flat graphic image with text detection and correction<br/>
        /// Processes an existing flat graphic image to detect and correct text layers without generating a new image from scratch.<br/>
        /// The uploaded image is analyzed for text content, which is then removed and returned as structured text layers with font matching, sizing, and color information.<br/>
        /// Supported image formats include JPEG, PNG, and WebP (max size 10MB).<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.LayeredImageGenerationResponseV3> PostLayerizeDesignV3Async(

            global::Ideogram.LayerizeDesignRequestV3 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePostLayerizeDesignV3Arguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Ideogram.PathBuilder(
                path: "/v1/ideogram-v3/layerize-design",
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
            var __contentFlatGraphicImage = new global::System.Net.Http.ByteArrayContent(request.FlatGraphicImage ?? global::System.Array.Empty<byte>());
            __httpRequestContent.Add(
                content: __contentFlatGraphicImage,
                name: "\"flat_graphic_image\"",
                fileName: request.FlatGraphicImagename != null ? $"\"{request.FlatGraphicImagename}\"" : string.Empty);
            if (__contentFlatGraphicImage.Headers.ContentDisposition != null)
            {
                __contentFlatGraphicImage.Headers.ContentDisposition.FileNameStar = null;
            }
            if (request.Prompt != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Prompt}"),
                    name: "\"prompt\"");
            } 
            if (request.Seed != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Seed}"),
                    name: "\"seed\"");
            } 
            if (request.FontFileH1 != default)
            {

                var __contentFontFileH1 = new global::System.Net.Http.ByteArrayContent(request.FontFileH1 ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentFontFileH1,
                    name: "\"font_file_h1\"",
                    fileName: request.FontFileH1name != null ? $"\"{request.FontFileH1name}\"" : string.Empty);
                if (__contentFontFileH1.Headers.ContentDisposition != null)
                {
                    __contentFontFileH1.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.FontNameH1 != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.FontNameH1}"),
                    name: "\"font_name_h1\"");
            } 
            if (request.FontFileH2 != default)
            {

                var __contentFontFileH2 = new global::System.Net.Http.ByteArrayContent(request.FontFileH2 ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentFontFileH2,
                    name: "\"font_file_h2\"",
                    fileName: request.FontFileH2name != null ? $"\"{request.FontFileH2name}\"" : string.Empty);
                if (__contentFontFileH2.Headers.ContentDisposition != null)
                {
                    __contentFontFileH2.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.FontNameH2 != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.FontNameH2}"),
                    name: "\"font_name_h2\"");
            } 
            if (request.FontFileBody != default)
            {

                var __contentFontFileBody = new global::System.Net.Http.ByteArrayContent(request.FontFileBody ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentFontFileBody,
                    name: "\"font_file_body\"",
                    fileName: request.FontFileBodyname != null ? $"\"{request.FontFileBodyname}\"" : string.Empty);
                if (__contentFontFileBody.Headers.ContentDisposition != null)
                {
                    __contentFontFileBody.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.FontNameBody != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.FontNameBody}"),
                    name: "\"font_name_body\"");
            } 
            if (request.FontFileSmall != default)
            {

                var __contentFontFileSmall = new global::System.Net.Http.ByteArrayContent(request.FontFileSmall ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentFontFileSmall,
                    name: "\"font_file_small\"",
                    fileName: request.FontFileSmallname != null ? $"\"{request.FontFileSmallname}\"" : string.Empty);
                if (__contentFontFileSmall.Headers.ContentDisposition != null)
                {
                    __contentFontFileSmall.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.FontNameSmall != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.FontNameSmall}"),
                    name: "\"font_name_small\"");
            } 
            if (request.ReferenceAssetImages != default)
            {

                for (var __iReferenceAssetImages = 0; __iReferenceAssetImages < request.ReferenceAssetImages.Count; __iReferenceAssetImages++)
                {
                    var __contentReferenceAssetImages = new global::System.Net.Http.ByteArrayContent(request.ReferenceAssetImages[__iReferenceAssetImages]);
                    __httpRequestContent.Add(
                        content: __contentReferenceAssetImages,
                        name: "\"reference_asset_images\"",
                        fileName: $"\"file{__iReferenceAssetImages}.bin\"");
                    if (__contentReferenceAssetImages.Headers.ContentDisposition != null)
                    {
                        __contentReferenceAssetImages.Headers.ContentDisposition.FileNameStar = null;
                    }
                }
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePostLayerizeDesignV3Request(
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
            ProcessPostLayerizeDesignV3Response(
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
                ProcessPostLayerizeDesignV3ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Ideogram.LayeredImageGenerationResponseV3.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Ideogram.LayeredImageGenerationResponseV3.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Layerize an existing flat graphic image with text detection and correction<br/>
        /// Processes an existing flat graphic image to detect and correct text layers without generating a new image from scratch.<br/>
        /// The uploaded image is analyzed for text content, which is then removed and returned as structured text layers with font matching, sizing, and color information.<br/>
        /// Supported image formats include JPEG, PNG, and WebP (max size 10MB).<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="flatGraphicImage">
        /// The flat graphic image to process for text detection and correction. The image should be in JPEG, PNG or WebP format (max size 10MB).
        /// </param>
        /// <param name="flatGraphicImagename">
        /// The flat graphic image to process for text detection and correction. The image should be in JPEG, PNG or WebP format (max size 10MB).
        /// </param>
        /// <param name="prompt">
        /// An optional prompt to describe the image. If not provided, a prompt will be auto-generated from the image via captioning.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="fontFileH1">
        /// Custom font file for H1 (heading) text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_h1.
        /// </param>
        /// <param name="fontFileH1name">
        /// Custom font file for H1 (heading) text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_h1.
        /// </param>
        /// <param name="fontNameH1">
        /// Font name from the available font library for H1 text. Ignored if font_file_h1 is provided.<br/>
        /// Example: Ubuntu-Bold.ttf
        /// </param>
        /// <param name="fontFileH2">
        /// Custom font file for H2 (subheading) text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_h2.
        /// </param>
        /// <param name="fontFileH2name">
        /// Custom font file for H2 (subheading) text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_h2.
        /// </param>
        /// <param name="fontNameH2">
        /// Font name from the available font library for H2 text. Ignored if font_file_h2 is provided.
        /// </param>
        /// <param name="fontFileBody">
        /// Custom font file for body text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_body.
        /// </param>
        /// <param name="fontFileBodyname">
        /// Custom font file for body text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_body.
        /// </param>
        /// <param name="fontNameBody">
        /// Font name from the available font library for body text. Ignored if font_file_body is provided.
        /// </param>
        /// <param name="fontFileSmall">
        /// Custom font file for small/caption text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_small.
        /// </param>
        /// <param name="fontFileSmallname">
        /// Custom font file for small/caption text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_small.
        /// </param>
        /// <param name="fontNameSmall">
        /// Font name from the available font library for small text. Ignored if font_file_small is provided.
        /// </param>
        /// <param name="referenceAssetImages">
        /// A set of asset images (e.g., logos, icons) to use as references for detection and replacement (maximum 10 images). The images should be in JPEG, PNG or WebP format.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.LayeredImageGenerationResponseV3> PostLayerizeDesignV3Async(
            byte[] flatGraphicImage,
            string flatGraphicImagename,
            string? prompt = default,
            int? seed = default,
            byte[]? fontFileH1 = default,
            string? fontFileH1name = default,
            string? fontNameH1 = default,
            byte[]? fontFileH2 = default,
            string? fontFileH2name = default,
            string? fontNameH2 = default,
            byte[]? fontFileBody = default,
            string? fontFileBodyname = default,
            string? fontNameBody = default,
            byte[]? fontFileSmall = default,
            string? fontFileSmallname = default,
            string? fontNameSmall = default,
            global::System.Collections.Generic.IList<byte[]>? referenceAssetImages = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Ideogram.LayerizeDesignRequestV3
            {
                FlatGraphicImage = flatGraphicImage,
                FlatGraphicImagename = flatGraphicImagename,
                Prompt = prompt,
                Seed = seed,
                FontFileH1 = fontFileH1,
                FontFileH1name = fontFileH1name,
                FontNameH1 = fontNameH1,
                FontFileH2 = fontFileH2,
                FontFileH2name = fontFileH2name,
                FontNameH2 = fontNameH2,
                FontFileBody = fontFileBody,
                FontFileBodyname = fontFileBodyname,
                FontNameBody = fontNameBody,
                FontFileSmall = fontFileSmall,
                FontFileSmallname = fontFileSmallname,
                FontNameSmall = fontNameSmall,
                ReferenceAssetImages = referenceAssetImages,
            };

            return await PostLayerizeDesignV3Async(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
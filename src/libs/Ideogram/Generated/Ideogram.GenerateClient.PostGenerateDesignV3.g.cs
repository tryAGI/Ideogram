
#nullable enable

namespace Ideogram
{
    public partial class GenerateClient
    {
        partial void PreparePostGenerateDesignV3Arguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Ideogram.GenerateDesignRequestV3 request);
        partial void PreparePostGenerateDesignV3Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Ideogram.GenerateDesignRequestV3 request);
        partial void ProcessPostGenerateDesignV3Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPostGenerateDesignV3ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate a design from a text prompt with text detection and correction<br/>
        /// Generates a design synchronously from a text prompt using the Ideogram 3.0 model, then detects and corrects text layers within the generated image.<br/>
        /// The response includes the generated image URL along with detected text layers (with font, size, color, position) and image asset layers.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.LayeredImageGenerationResponseV3> PostGenerateDesignV3Async(

            global::Ideogram.GenerateDesignRequestV3 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePostGenerateDesignV3Arguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Ideogram.PathBuilder(
                path: "/v1/ideogram-v3/generate-design",
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
                content: new global::System.Net.Http.StringContent($"{request.Prompt}"),
                name: "\"prompt\"");
            if (request.Seed != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Seed}"),
                    name: "\"seed\"");
            } 
            if (request.Resolution != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Resolution?.ToValueString()}"),
                    name: "\"resolution\"");
            } 
            if (request.AspectRatio != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AspectRatio?.ToValueString()}"),
                    name: "\"aspect_ratio\"");
            } 
            if (request.RenderingSpeed != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.RenderingSpeed?.ToValueString()}"),
                    name: "\"rendering_speed\"");
            } 
            if (request.MagicPrompt != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.MagicPrompt?.ToValueString()}"),
                    name: "\"magic_prompt\"");
            } 
            if (request.NegativePrompt != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.NegativePrompt}"),
                    name: "\"negative_prompt\"");
            } 
            if (request.NumImages != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.NumImages}"),
                    name: "\"num_images\"");
            } 
            if (request.ColorPalette != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent(request.ColorPalette?.ToString() ?? string.Empty),
                    name: "\"color_palette\"");
            } 
            if (request.StyleCodes != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.StyleCodes, x => x))}]"),
                    name: "\"style_codes\"");
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
            if (request.CustomModelUri != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.CustomModelUri}"),
                    name: "\"custom_model_uri\"");
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
            if (request.StyleReferenceImages != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.StyleReferenceImages, x => x))}]"),
                    name: "\"style_reference_images\"");
            } 
            if (request.ReferenceAssetImages != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.ReferenceAssetImages, x => x))}]"),
                    name: "\"reference_asset_images\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePostGenerateDesignV3Request(
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
            ProcessPostGenerateDesignV3Response(
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
            // Prompt failed the safety check.
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
                ProcessPostGenerateDesignV3ResponseContent(
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
        /// Generate a design from a text prompt with text detection and correction<br/>
        /// Generates a design synchronously from a text prompt using the Ideogram 3.0 model, then detects and corrects text layers within the generated image.<br/>
        /// The response includes the generated image URL along with detected text layers (with font, size, color, position) and image asset layers.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to use to generate the design.<br/>
        /// Example: A birthday card saying 'Happy Birthday'
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 3.0.<br/>
        /// Example: 1280x800
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio to use for image generation, which determines the image's resolution. Cannot be used in conjunction with resolution. Defaults to 1x1.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="magicPrompt">
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to exclude from a design. Descriptions in the prompt take precedence<br/>
        /// to descriptions in the negative prompt.<br/>
        /// Example: brush strokes, painting
        /// </param>
        /// <param name="numImages">
        /// Number of designs to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="colorPalette">
        /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members). Not supported by V_1, V_1_TURBO, V_2A and V_2A_TURBO models.
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8 character hexadecimal codes representing the style of the image. Cannot be used in conjunction with style_reference_images or style_type.<br/>
        /// Example: [AAFF5733, 0133FF57, DE3357FF]
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
        /// <param name="customModelUri">
        /// A custom model URI in the format model/&lt;model_name&gt;/version/&lt;version_name&gt;. <br/>
        /// When provided, the model version and style will be resolved from this URI, and style_type is not required.<br/>
        /// Example: model/my-custom-model/version/1
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
        /// <param name="styleReferenceImages">
        /// A set of images to use as style references (maximum total size 10MB across all style references). The images should be in JPEG, PNG or WebP format.
        /// </param>
        /// <param name="referenceAssetImages">
        /// A set of asset images (e.g., logos, icons) to use as references for detection and replacement (maximum 10 images). The images should be in JPEG, PNG or WebP format.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.LayeredImageGenerationResponseV3> PostGenerateDesignV3Async(
            string prompt,
            int? seed = default,
            global::Ideogram.ResolutionV3? resolution = default,
            global::Ideogram.AspectRatioV3? aspectRatio = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            global::Ideogram.MagicPromptOption? magicPrompt = default,
            string? negativePrompt = default,
            int? numImages = default,
            global::Ideogram.ColorPaletteWithPresetNameOrMembers? colorPalette = default,
            global::System.Collections.Generic.IList<string>? styleCodes = default,
            global::Ideogram.StyleTypeV3? styleType = default,
            global::Ideogram.StylePresetV3? stylePreset = default,
            string? customModelUri = default,
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
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages = default,
            global::System.Collections.Generic.IList<byte[]>? referenceAssetImages = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Ideogram.GenerateDesignRequestV3
            {
                Prompt = prompt,
                Seed = seed,
                Resolution = resolution,
                AspectRatio = aspectRatio,
                RenderingSpeed = renderingSpeed,
                MagicPrompt = magicPrompt,
                NegativePrompt = negativePrompt,
                NumImages = numImages,
                ColorPalette = colorPalette,
                StyleCodes = styleCodes,
                StyleType = styleType,
                StylePreset = stylePreset,
                CustomModelUri = customModelUri,
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
                StyleReferenceImages = styleReferenceImages,
                ReferenceAssetImages = referenceAssetImages,
            };

            return await PostGenerateDesignV3Async(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
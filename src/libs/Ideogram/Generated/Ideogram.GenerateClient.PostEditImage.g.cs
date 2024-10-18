
#nullable enable

namespace Ideogram
{
    public partial class GenerateClient
    {
        partial void PreparePostEditImageArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Ideogram.EditImageRequest request);
        partial void PreparePostEditImageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Ideogram.EditImageRequest request);
        partial void ProcessPostEditImageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPostEditImageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Edit<br/>
        /// Edit given images synchronously using the provided mask, prompt and optional parameters<br/>
        /// Supported image formats include JPEG, PNG, and WEBP
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageResponse> PostEditImageAsync(
            global::Ideogram.EditImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PreparePostEditImageArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/edit",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.ImageFile ?? global::System.Array.Empty<byte>())
                {
                    Headers =
                    {
                        ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data"),
                    },
                },
                name: "image_file",
                fileName: request.ImageFilename ?? string.Empty);
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.Mask ?? global::System.Array.Empty<byte>())
                {
                    Headers =
                    {
                        ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data"),
                    },
                },
                name: "mask",
                fileName: request.Maskname ?? string.Empty);
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Prompt}"),
                name: "prompt");
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Model.ToValueString()}"),
                name: "model");
            if (request.MagicPromptOption != global::Ideogram.MagicPromptOption.AUTO)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.MagicPromptOption?.ToValueString()}"),
                    name: "magic_prompt_option");
            } 
            if (request.Seed != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Seed}"),
                    name: "seed");
            } 
            if (request.StyleType != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.StyleType?.ToValueString()}"),
                    name: "style_type");
            }
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePostEditImageRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessPostEditImageResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPostEditImageResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Ideogram.GenerateImageResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Edit<br/>
        /// Edit given images synchronously using the provided mask, prompt and optional parameters<br/>
        /// Supported image formats include JPEG, PNG, and WEBP
        /// </summary>
        /// <param name="imageFile">
        /// The image being edited; only JPEG, WEBPs and PNGs are supported at this time
        /// </param>
        /// <param name="imageFilename">
        /// The image being edited; only JPEG, WEBPs and PNGs are supported at this time
        /// </param>
        /// <param name="mask">
        /// A black and white image of the same size as the image being edited. Black regions in the mask should match up with the regions of the image that you would like to edit; only JPEG, WEBPs and PNGs are supported at this time
        /// </param>
        /// <param name="maskname">
        /// A black and white image of the same size as the image being edited. Black regions in the mask should match up with the regions of the image that you would like to edit; only JPEG, WEBPs and PNGs are supported at this time
        /// </param>
        /// <param name="prompt">
        /// The prompt used to describe the edited result.<br/>
        /// Example: A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there is an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.
        /// </param>
        /// <param name="model">
        /// The model used to generate. Defaults to V_2.<br/>
        /// Default Value: V_2<br/>
        /// Example: V_2_TURBO
        /// </param>
        /// <param name="magicPromptOption">
        /// Determine if MagicPrompt should be used in generating the request or not<br/>
        /// Default Value: AUTO<br/>
        /// Example: ON
        /// </param>
        /// <param name="seed">
        /// Example: 12345
        /// </param>
        /// <param name="styleType">
        /// The style type to generate with; this is only applicable for models V_2 and above and should not be specified for model versions V_1.<br/>
        /// Example: REALISTIC
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageResponse> PostEditImageAsync(
            byte[] imageFile,
            string imageFilename,
            byte[] mask,
            string maskname,
            string prompt,
            global::Ideogram.ModelEnum model,
            global::Ideogram.MagicPromptOption? magicPromptOption = global::Ideogram.MagicPromptOption.AUTO,
            int? seed = default,
            global::Ideogram.StyleType? styleType = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Ideogram.EditImageRequest
            {
                ImageFile = imageFile,
                ImageFilename = imageFilename,
                Mask = mask,
                Maskname = maskname,
                Prompt = prompt,
                Model = model,
                MagicPromptOption = magicPromptOption,
                Seed = seed,
                StyleType = styleType,
            };

            return await PostEditImageAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
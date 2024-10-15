#nullable enable

namespace Ideogram
{
    public partial interface IInternalTestingClient
    {
        /// <summary>
        /// Testing<br/>
        /// Just a testing endpoint
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.PostInternalTesting200Response> PostInternalTestingAsync(
            global::Ideogram.InternalTestingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Testing<br/>
        /// Just a testing endpoint
        /// </summary>
        /// <param name="xPosition"></param>
        /// <param name="imageFile"></param>
        /// <param name="imageFilename"></param>
        /// <param name="anotherImageFile"></param>
        /// <param name="anotherImageFilename"></param>
        /// <param name="someText"></param>
        /// <param name="nestedObject"></param>
        /// <param name="nestedObjectRequiredFields"></param>
        /// <param name="dateTypeField"></param>
        /// <param name="requiredDateTypeField"></param>
        /// <param name="dateTimeTypeField"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.PostInternalTesting200Response> PostInternalTestingAsync(
            global::System.DateTime requiredDateTypeField,
            int? xPosition = default,
            byte[]? imageFile = default,
            string? imageFilename = default,
            byte[]? anotherImageFile = default,
            string? anotherImageFilename = default,
            string? someText = default,
            global::Ideogram.InternalTestingNestedObject? nestedObject = default,
            global::Ideogram.InternalTestingNestedObjectRequiredFields? nestedObjectRequiredFields = default,
            global::System.DateTime? dateTypeField = default,
            global::System.DateTime? dateTimeTypeField = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
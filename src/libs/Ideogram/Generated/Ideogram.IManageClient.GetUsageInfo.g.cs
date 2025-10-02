#nullable enable

namespace Ideogram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Retrieve usage information segmented by time period with tool-specific breakdowns
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="segmentBy">
        /// Time segment granularity for usage breakdown<br/>
        /// Example: DAY
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="modelVersions"></param>
        /// <param name="tools"></param>
        /// <param name="apiKeyIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GetUsageInfoResponse> GetUsageInfoAsync(
            string organizationId,
            global::Ideogram.SegmentBy segmentBy,
            global::System.DateTime startTime,
            global::System.DateTime? endTime = default,
            global::System.Collections.Generic.IList<global::Ideogram.ModelVersion>? modelVersions = default,
            global::System.Collections.Generic.IList<global::Ideogram.ToolType>? tools = default,
            global::System.Collections.Generic.IList<string>? apiKeyIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
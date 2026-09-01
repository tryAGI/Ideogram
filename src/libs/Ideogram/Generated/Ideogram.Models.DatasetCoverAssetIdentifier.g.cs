#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Cover asset of the dataset, null if not set.<br/>
    /// Example: {"asset_type":null,"asset_id":"asset_id"}
    /// </summary>
    public readonly partial struct DatasetCoverAssetIdentifier : global::System.IEquatable<DatasetCoverAssetIdentifier>
    {
        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.AssetIdentifier? AssetIdentifier { get; init; }
#else
        public global::Ideogram.AssetIdentifier? AssetIdentifier { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssetIdentifier))]
#endif
        public bool IsAssetIdentifier => AssetIdentifier != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAssetIdentifier(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ideogram.AssetIdentifier? value)
        {
            value = AssetIdentifier;
            return IsAssetIdentifier;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.AssetIdentifier PickAssetIdentifier() => IsAssetIdentifier
            ? AssetIdentifier!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AssetIdentifier' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DatasetCoverAssetIdentifier(global::Ideogram.AssetIdentifier value) => new DatasetCoverAssetIdentifier((global::Ideogram.AssetIdentifier?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.AssetIdentifier?(DatasetCoverAssetIdentifier @this) => @this.AssetIdentifier;

        /// <summary>
        ///
        /// </summary>
        public DatasetCoverAssetIdentifier(global::Ideogram.AssetIdentifier? value)
        {
            AssetIdentifier = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DatasetCoverAssetIdentifier FromAssetIdentifier(global::Ideogram.AssetIdentifier? value) => new DatasetCoverAssetIdentifier(value);

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AssetIdentifier as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AssetIdentifier?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAssetIdentifier;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Ideogram.AssetIdentifier, TResult>? assetIdentifier = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAssetIdentifier && assetIdentifier != null)
            {
                return assetIdentifier(AssetIdentifier!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Ideogram.AssetIdentifier>? assetIdentifier = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAssetIdentifier)
            {
                assetIdentifier?.Invoke(AssetIdentifier!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Ideogram.AssetIdentifier>? assetIdentifier = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAssetIdentifier)
            {
                assetIdentifier?.Invoke(AssetIdentifier!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AssetIdentifier,
                typeof(global::Ideogram.AssetIdentifier),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(DatasetCoverAssetIdentifier other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.AssetIdentifier?>.Default.Equals(AssetIdentifier, other.AssetIdentifier)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DatasetCoverAssetIdentifier obj1, DatasetCoverAssetIdentifier obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DatasetCoverAssetIdentifier>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DatasetCoverAssetIdentifier obj1, DatasetCoverAssetIdentifier obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DatasetCoverAssetIdentifier o && Equals(o);
        }
    }
}

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// A single element in the V4 prompt's compositional deconstruction.<br/>
    /// Discriminated by the `type` field.
    /// </summary>
    public readonly partial struct V4PromptElement : global::System.IEquatable<V4PromptElement>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.V4PromptElementDiscriminatorType? Type { get; }

        /// <summary>
        /// A non-text element (object, character, background detail) in the V4 prompt layout.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.V2.V4PromptElementVariant1? Obj { get; init; }
#else
        public global::Ideogram.V2.V4PromptElementVariant1? Obj { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Obj))]
#endif
        public bool IsObj => Obj != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickObj(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ideogram.V2.V4PromptElementVariant1? value)
        {
            value = Obj;
            return IsObj;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.V4PromptElementVariant1 PickObj() => Obj is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Obj' but the value was {ToString()}.");

        /// <summary>
        /// A text element to render in the V4 prompt layout.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ideogram.V2.V4PromptElementVariant2? Text { get; init; }
#else
        public global::Ideogram.V2.V4PromptElementVariant2? Text { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ideogram.V2.V4PromptElementVariant2? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Ideogram.V2.V4PromptElementVariant2 PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator V4PromptElement(global::Ideogram.V2.V4PromptElementVariant1 value) => new V4PromptElement((global::Ideogram.V2.V4PromptElementVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.V2.V4PromptElementVariant1?(V4PromptElement @this) => @this.Obj;

        /// <summary>
        ///
        /// </summary>
        public V4PromptElement(global::Ideogram.V2.V4PromptElementVariant1? value)
        {
            Obj = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static V4PromptElement FromObj(global::Ideogram.V2.V4PromptElementVariant1? value) => new V4PromptElement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator V4PromptElement(global::Ideogram.V2.V4PromptElementVariant2 value) => new V4PromptElement((global::Ideogram.V2.V4PromptElementVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Ideogram.V2.V4PromptElementVariant2?(V4PromptElement @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public V4PromptElement(global::Ideogram.V2.V4PromptElementVariant2? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static V4PromptElement FromText(global::Ideogram.V2.V4PromptElementVariant2? value) => new V4PromptElement(value);

        /// <summary>
        ///
        /// </summary>
        public V4PromptElement(
            global::Ideogram.V2.V4PromptElementDiscriminatorType? type,
            global::Ideogram.V2.V4PromptElementVariant1? obj,
            global::Ideogram.V2.V4PromptElementVariant2? text
            )
        {
            Type = type;

            Obj = obj;
            Text = text;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Text as object ??
            Obj as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Obj?.ToString() ??
            Text?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsObj && !IsText || !IsObj && IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Ideogram.V2.V4PromptElementVariant1, TResult>? obj = null,
            global::System.Func<global::Ideogram.V2.V4PromptElementVariant2, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Obj is { } __value0 && obj != null)
            {
                return obj(__value0);
            }
            else if (Text is { } __value1 && text != null)
            {
                return text(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Ideogram.V2.V4PromptElementVariant1>? obj = null,

            global::System.Action<global::Ideogram.V2.V4PromptElementVariant2>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Obj is { } __value0)
            {
                obj?.Invoke(__value0);
            }
            else if (Text is { } __value1)
            {
                text?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Ideogram.V2.V4PromptElementVariant1>? obj = null,
            global::System.Action<global::Ideogram.V2.V4PromptElementVariant2>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Obj is { } __value0)
            {
                obj?.Invoke(__value0);
            }
            else if (Text is { } __value1)
            {
                text?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Obj,
                typeof(global::Ideogram.V2.V4PromptElementVariant1),
                Text,
                typeof(global::Ideogram.V2.V4PromptElementVariant2),
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
        public bool Equals(V4PromptElement other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.V2.V4PromptElementVariant1?>.Default.Equals(Obj, other.Obj) &&
                global::System.Collections.Generic.EqualityComparer<global::Ideogram.V2.V4PromptElementVariant2?>.Default.Equals(Text, other.Text)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(V4PromptElement obj1, V4PromptElement obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<V4PromptElement>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(V4PromptElement obj1, V4PromptElement obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is V4PromptElement o && Equals(o);
        }
    }
}

// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Paper
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The list paper docs sort order object</para>
    /// </summary>
    public class ListPaperDocsSortOrder
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ListPaperDocsSortOrder> Encoder = new ListPaperDocsSortOrderEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ListPaperDocsSortOrder> Decoder = new ListPaperDocsSortOrderDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListPaperDocsSortOrder" />
        /// class.</para>
        /// </summary>
        public ListPaperDocsSortOrder()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Ascending</para>
        /// </summary>
        public bool IsAscending
        {
            get
            {
                return this is Ascending;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Ascending, or <c>null</c>.</para>
        /// </summary>
        public Ascending AsAscending
        {
            get
            {
                return this as Ascending;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Descending</para>
        /// </summary>
        public bool IsDescending
        {
            get
            {
                return this is Descending;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Descending, or <c>null</c>.</para>
        /// </summary>
        public Descending AsDescending
        {
            get
            {
                return this as Descending;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ListPaperDocsSortOrder" />.</para>
        /// </summary>
        private class ListPaperDocsSortOrderEncoder : enc.StructEncoder<ListPaperDocsSortOrder>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ListPaperDocsSortOrder value, enc.IJsonWriter writer)
            {
                if (value is Ascending)
                {
                    WriteProperty(".tag", "ascending", writer, enc.StringEncoder.Instance);
                    Ascending.Encoder.EncodeFields((Ascending)value, writer);
                    return;
                }
                if (value is Descending)
                {
                    WriteProperty(".tag", "descending", writer, enc.StringEncoder.Instance);
                    Descending.Encoder.EncodeFields((Descending)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ListPaperDocsSortOrder" />.</para>
        /// </summary>
        private class ListPaperDocsSortOrderDecoder : enc.UnionDecoder<ListPaperDocsSortOrder>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ListPaperDocsSortOrder"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ListPaperDocsSortOrder Create()
            {
                return new ListPaperDocsSortOrder();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override ListPaperDocsSortOrder Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "ascending":
                        return Ascending.Decoder.DecodeFields(reader);
                    case "descending":
                        return Descending.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Sorts the search result in ascending order.</para>
        /// </summary>
        public sealed class Ascending : ListPaperDocsSortOrder
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Ascending> Encoder = new AscendingEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Ascending> Decoder = new AscendingDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Ascending" /> class.</para>
            /// </summary>
            private Ascending()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Ascending</para>
            /// </summary>
            public static readonly Ascending Instance = new Ascending();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Ascending" />.</para>
            /// </summary>
            private class AscendingEncoder : enc.StructEncoder<Ascending>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Ascending value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Ascending" />.</para>
            /// </summary>
            private class AscendingDecoder : enc.StructDecoder<Ascending>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Ascending" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Ascending Create()
                {
                    return new Ascending();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Ascending DecodeFields(enc.IJsonReader reader)
                {
                    return Ascending.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Sorts the search result in descending order.</para>
        /// </summary>
        public sealed class Descending : ListPaperDocsSortOrder
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Descending> Encoder = new DescendingEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Descending> Decoder = new DescendingDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Descending" /> class.</para>
            /// </summary>
            private Descending()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Descending</para>
            /// </summary>
            public static readonly Descending Instance = new Descending();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Descending" />.</para>
            /// </summary>
            private class DescendingEncoder : enc.StructEncoder<Descending>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Descending value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Descending" />.</para>
            /// </summary>
            private class DescendingDecoder : enc.StructDecoder<Descending>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Descending" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Descending Create()
                {
                    return new Descending();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Descending DecodeFields(enc.IJsonReader reader)
                {
                    return Descending.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : ListPaperDocsSortOrder
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return new Other();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Other DecodeFields(enc.IJsonReader reader)
                {
                    return Other.Instance;
                }
            }

            #endregion
        }
    }
}

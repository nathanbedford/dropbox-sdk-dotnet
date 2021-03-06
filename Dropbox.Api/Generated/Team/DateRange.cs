// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Input arguments that can be provided for most reports.</para>
    /// </summary>
    public class DateRange
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DateRange> Encoder = new DateRangeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DateRange> Decoder = new DateRangeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DateRange" /> class.</para>
        /// </summary>
        /// <param name="startDate">Optional starting date (inclusive)</param>
        /// <param name="endDate">Optional ending date (exclusive)</param>
        public DateRange(sys.DateTime? startDate = null,
                         sys.DateTime? endDate = null)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DateRange" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public DateRange()
        {
        }

        /// <summary>
        /// <para>Optional starting date (inclusive)</para>
        /// </summary>
        public sys.DateTime? StartDate { get; protected set; }

        /// <summary>
        /// <para>Optional ending date (exclusive)</para>
        /// </summary>
        public sys.DateTime? EndDate { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DateRange" />.</para>
        /// </summary>
        private class DateRangeEncoder : enc.StructEncoder<DateRange>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DateRange value, enc.IJsonWriter writer)
            {
                if (value.StartDate != null)
                {
                    WriteProperty("start_date", value.StartDate.Value, writer, enc.DateTimeEncoder.Instance);
                }
                if (value.EndDate != null)
                {
                    WriteProperty("end_date", value.EndDate.Value, writer, enc.DateTimeEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DateRange" />.</para>
        /// </summary>
        private class DateRangeDecoder : enc.StructDecoder<DateRange>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="DateRange" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DateRange Create()
            {
                return new DateRange();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DateRange value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "start_date":
                        value.StartDate = enc.DateTimeDecoder.Instance.Decode(reader);
                        break;
                    case "end_date":
                        value.EndDate = enc.DateTimeDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}

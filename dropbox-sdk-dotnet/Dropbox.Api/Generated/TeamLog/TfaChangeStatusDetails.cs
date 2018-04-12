// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Enabled/disabled/changed two-step verification setting.</para>
    /// </summary>
    public class TfaChangeStatusDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TfaChangeStatusDetails> Encoder = new TfaChangeStatusDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TfaChangeStatusDetails> Decoder = new TfaChangeStatusDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TfaChangeStatusDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="newValue">The new two factor authentication configuration.</param>
        /// <param name="previousValue">The previous two factor authentication configuration.
        /// Might be missing due to historical data gap.</param>
        /// <param name="usedRescueCode">Used two factor authentication rescue code. This flag
        /// is relevant when the two factor authentication configuration is disabled.</param>
        public TfaChangeStatusDetails(TfaConfiguration newValue,
                                      TfaConfiguration previousValue = null,
                                      bool? usedRescueCode = null)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
            this.UsedRescueCode = usedRescueCode;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TfaChangeStatusDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public TfaChangeStatusDetails()
        {
        }

        /// <summary>
        /// <para>The new two factor authentication configuration.</para>
        /// </summary>
        public TfaConfiguration NewValue { get; protected set; }

        /// <summary>
        /// <para>The previous two factor authentication configuration. Might be missing due to
        /// historical data gap.</para>
        /// </summary>
        public TfaConfiguration PreviousValue { get; protected set; }

        /// <summary>
        /// <para>Used two factor authentication rescue code. This flag is relevant when the
        /// two factor authentication configuration is disabled.</para>
        /// </summary>
        public bool? UsedRescueCode { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TfaChangeStatusDetails" />.</para>
        /// </summary>
        private class TfaChangeStatusDetailsEncoder : enc.StructEncoder<TfaChangeStatusDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TfaChangeStatusDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.TfaConfiguration.Encoder);
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.TfaConfiguration.Encoder);
                }
                if (value.UsedRescueCode != null)
                {
                    WriteProperty("used_rescue_code", value.UsedRescueCode.Value, writer, enc.BooleanEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TfaChangeStatusDetails" />.</para>
        /// </summary>
        private class TfaChangeStatusDetailsDecoder : enc.StructDecoder<TfaChangeStatusDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TfaChangeStatusDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TfaChangeStatusDetails Create()
            {
                return new TfaChangeStatusDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TfaChangeStatusDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.TfaConfiguration.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.TfaConfiguration.Decoder.Decode(reader);
                        break;
                    case "used_rescue_code":
                        value.UsedRescueCode = enc.BooleanDecoder.Instance.Decode(reader);
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
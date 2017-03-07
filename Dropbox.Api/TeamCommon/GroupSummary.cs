// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamCommon
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Information about a group.</para>
    /// </summary>
    public class GroupSummary
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupSummary> Encoder = new GroupSummaryEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupSummary> Decoder = new GroupSummaryDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupSummary" /> class.</para>
        /// </summary>
        /// <param name="groupName">The group name</param>
        /// <param name="groupId">The group id</param>
        /// <param name="groupManagementType">Who is allowed to manage the group.</param>
        /// <param name="groupExternalId">External ID of group. This is an arbitrary ID that an
        /// admin can attach to a group.</param>
        /// <param name="memberCount">The number of members in the group.</param>
        public GroupSummary(string groupName,
                            string groupId,
                            GroupManagementType groupManagementType,
                            string groupExternalId = null,
                            uint? memberCount = null)
        {
            if (groupName == null)
            {
                throw new sys.ArgumentNullException("groupName");
            }

            if (groupId == null)
            {
                throw new sys.ArgumentNullException("groupId");
            }

            if (groupManagementType == null)
            {
                throw new sys.ArgumentNullException("groupManagementType");
            }

            this.GroupName = groupName;
            this.GroupId = groupId;
            this.GroupManagementType = groupManagementType;
            this.GroupExternalId = groupExternalId;
            this.MemberCount = memberCount;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupSummary" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public GroupSummary()
        {
        }

        /// <summary>
        /// <para>Gets the group name of the group summary</para>
        /// </summary>
        public string GroupName { get; protected set; }

        /// <summary>
        /// <para>Gets the group id of the group summary</para>
        /// </summary>
        public string GroupId { get; protected set; }

        /// <summary>
        /// <para>Who is allowed to manage the group.</para>
        /// </summary>
        public GroupManagementType GroupManagementType { get; protected set; }

        /// <summary>
        /// <para>External ID of group. This is an arbitrary ID that an admin can attach to a
        /// group.</para>
        /// </summary>
        public string GroupExternalId { get; protected set; }

        /// <summary>
        /// <para>The number of members in the group.</para>
        /// </summary>
        public uint? MemberCount { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupSummary" />.</para>
        /// </summary>
        private class GroupSummaryEncoder : enc.StructEncoder<GroupSummary>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupSummary value, enc.IJsonWriter writer)
            {
                WriteProperty("group_name", value.GroupName, writer, enc.StringEncoder.Instance);
                WriteProperty("group_id", value.GroupId, writer, enc.StringEncoder.Instance);
                WriteProperty("group_management_type", value.GroupManagementType, writer, Dropbox.Api.TeamCommon.GroupManagementType.Encoder);
                if (value.GroupExternalId != null)
                {
                    WriteProperty("group_external_id", value.GroupExternalId, writer, enc.StringEncoder.Instance);
                }
                if (value.MemberCount != null)
                {
                    WriteProperty("member_count", value.MemberCount.Value, writer, enc.UInt32Encoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupSummary" />.</para>
        /// </summary>
        private class GroupSummaryDecoder : enc.StructDecoder<GroupSummary>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupSummary" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupSummary Create()
            {
                return new GroupSummary();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GroupSummary value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "group_name":
                        value.GroupName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "group_id":
                        value.GroupId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "group_management_type":
                        value.GroupManagementType = Dropbox.Api.TeamCommon.GroupManagementType.Decoder.Decode(reader);
                        break;
                    case "group_external_id":
                        value.GroupExternalId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "member_count":
                        value.MemberCount = enc.UInt32Decoder.Instance.Decode(reader);
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
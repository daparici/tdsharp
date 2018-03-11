using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ChatMemberStatus : Structure
    {

        public partial class chatMemberStatusAdministrator : ChatMemberStatus
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "chatMemberStatusAdministrator";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_be_edited")]
                public bool can_be_edited_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_change_info")]
                public bool can_change_info_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_post_messages")]
                public bool can_post_messages_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_edit_messages")]
                public bool can_edit_messages_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_delete_messages")]
                public bool can_delete_messages_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_invite_users")]
                public bool can_invite_users_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_restrict_members")]
                public bool can_restrict_members_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_pin_messages")]
                public bool can_pin_messages_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_promote_members")]
                public bool can_promote_members_;

        }

    }

}

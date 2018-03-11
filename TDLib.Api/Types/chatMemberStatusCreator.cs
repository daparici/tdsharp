using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ChatMemberStatus : Structure
    {

        public partial class chatMemberStatusCreator : ChatMemberStatus
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "chatMemberStatusCreator";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_member")]
                public bool is_member_;

        }

    }

}

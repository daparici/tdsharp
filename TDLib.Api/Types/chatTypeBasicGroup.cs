using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ChatType : Structure
    {

        public partial class chatTypeBasicGroup : ChatType
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "chatTypeBasicGroup";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("basic_group_id")]
                public int basic_group_id_;

        }

    }

}

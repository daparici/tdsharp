using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class deleteChatReplyMarkup : Method<Ok>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "deleteChatReplyMarkup";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long chat_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("message_id")]
                public long message_id_;

        }

    }

}

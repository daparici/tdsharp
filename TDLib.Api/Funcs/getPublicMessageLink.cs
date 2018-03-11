using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class getPublicMessageLink : Method<PublicMessageLink>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "getPublicMessageLink";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long chat_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("message_id")]
                public long message_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("for_album")]
                public bool for_album_;

        }

    }

}

using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class removeTopChat : Method<Ok>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "removeTopChat";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("category")]
                public TopChatCategory category_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long chat_id_;

        }

    }

}

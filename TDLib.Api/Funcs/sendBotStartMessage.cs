using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class sendBotStartMessage : Method<Message>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "sendBotStartMessage";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("bot_user_id")]
                public int bot_user_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long chat_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("parameter")]
                public string parameter_;

        }

    }

}

using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class getGameHighScores : Method<GameHighScores>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "getGameHighScores";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long chat_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("message_id")]
                public long message_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_id")]
                public int user_id_;

        }

    }

}

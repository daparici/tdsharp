using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class setInlineGameScore : Method<Ok>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "setInlineGameScore";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("inline_message_id")]
                public string inline_message_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("edit_message")]
                public bool edit_message_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_id")]
                public int user_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("score")]
                public int score_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("force")]
                public bool force_;

        }

    }

}

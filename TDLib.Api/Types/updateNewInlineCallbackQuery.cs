using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public partial class updateNewInlineCallbackQuery : Update
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "updateNewInlineCallbackQuery";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public string id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sender_user_id")]
                public int sender_user_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("inline_message_id")]
                public string inline_message_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_instance")]
                public string chat_instance_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("payload")]
                public CallbackQueryPayload payload_;

        }

    }

}

using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public partial class TdApi
    {
        /// <summary>
        /// Incoming messages were read or number of unread messages has been changed 
        /// </summary>
        public partial class Update : Object
        {
            /// <summary>
            /// Incoming messages were read or number of unread messages has been changed 
            /// </summary>
            public class UpdateChatReadInbox : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateChatReadInbox";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Chat identifier 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long ChatId { get; set; }

                /// <summary>
                /// Identifier of the last read incoming message 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("last_read_inbox_message_id")]
                public long LastReadInboxMessageId { get; set; }

                /// <summary>
                /// The number of unread messages left in the chat
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("unread_count")]
                public int UnreadCount { get; set; }
            }
        }
    }
}
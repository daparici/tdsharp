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
        /// The last message of a chat was changed. If last_message is null then the last message in the chat became unknown. Some new unknown messages might be added to the chat in this case 
        /// </summary>
        public partial class Update : Object
        {
            /// <summary>
            /// The last message of a chat was changed. If last_message is null then the last message in the chat became unknown. Some new unknown messages might be added to the chat in this case 
            /// </summary>
            public class UpdateChatLastMessage : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateChatLastMessage";

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
                /// The new last message in the chat; may be null 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("last_message")]
                public Message LastMessage { get; set; }

                /// <summary>
                /// New value of the chat order
                /// </summary>
                [JsonConverter(typeof(Converter.Int64))]
                [JsonProperty("order")]
                public Int64 Order { get; set; }
            }
        }
    }
}
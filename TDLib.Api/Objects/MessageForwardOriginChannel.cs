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
        /// The message was originally a post in a channel
        /// </summary>
        public partial class MessageForwardOrigin : Object
        {
            /// <summary>
            /// The message was originally a post in a channel
            /// </summary>
            public class MessageForwardOriginChannel : MessageForwardOrigin
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageForwardOriginChannel";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier of the chat from which the message was originally forwarded
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long ChatId { get; set; }

                /// <summary>
                /// Message identifier of the original message; 0 if unknown
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("message_id")]
                public long MessageId { get; set; }

                /// <summary>
                /// Original post author signature
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("author_signature")]
                public string AuthorSignature { get; set; }
            }
        }
    }
}
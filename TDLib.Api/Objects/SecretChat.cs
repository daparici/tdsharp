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
        /// Represents a secret chat
        /// </summary>
        public class SecretChat : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "secretChat";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Secret chat identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("id")]
            public int Id { get; set; }

            /// <summary>
            /// Identifier of the chat partner
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public int UserId { get; set; }

            /// <summary>
            /// State of the secret chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("state")]
            public SecretChatState State { get; set; }

            /// <summary>
            /// True, if the chat was created by the current user; otherwise false
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_outbound")]
            public bool IsOutbound { get; set; }

            /// <summary>
            /// Current message Time To Live setting (self-destruct timer) for the chat, in seconds
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("ttl")]
            public int Ttl { get; set; }

            /// <summary>
            /// Hash of the currently used key for comparison with the hash of the chat partner's key. This is a string of 36 bytes, which must be used to make a 12x12 square image with a color depth of 4. The first 16 bytes should be used to make a central 8x8 square, while the remaining 20 bytes should be used to construct a 2-pixel-wide border around that square.
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("key_hash")]
            public byte[] KeyHash { get; set; }

            /// <summary>
            /// Secret chat layer; determines features supported by the other client. Video notes are supported if the layer >= 66
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("layer")]
            public int Layer { get; set; }
        }
    }
}
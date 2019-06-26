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
        /// Updates the game score of the specified user in the game; for bots only 
        /// </summary>
        public class SetGameScore : Function<Message>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setGameScore";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The chat to which the message with the game belongs 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Identifier of the message 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("message_id")]
            public long MessageId { get; set; }

            /// <summary>
            /// True, if the message should be edited 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("edit_message")]
            public bool EditMessage { get; set; }

            /// <summary>
            /// User identifier 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public int UserId { get; set; }

            /// <summary>
            /// The new score
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("score")]
            public int Score { get; set; }

            /// <summary>
            /// Pass true to update the score even if it decreases. If the score is 0, the user will be deleted from the high score table
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("force")]
            public bool Force { get; set; }
        }
    }
}
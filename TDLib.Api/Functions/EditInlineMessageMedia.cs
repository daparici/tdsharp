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
        /// Edits the content of a message with an animation, an audio, a document, a photo or a video in an inline message sent via a bot; for bots only 
        /// </summary>
        public class EditInlineMessageMedia : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "editInlineMessageMedia";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Inline message identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("inline_message_id")]
            public string InlineMessageId { get; set; }

            /// <summary>
            /// The new message reply markup; for bots only 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("reply_markup")]
            public ReplyMarkup ReplyMarkup { get; set; }

            /// <summary>
            /// New content of the message. Must be one of the following types: InputMessageAnimation, InputMessageAudio, InputMessageDocument, InputMessagePhoto or InputMessageVideo
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("input_message_content")]
            public InputMessageContent InputMessageContent { get; set; }
        }
    }
}
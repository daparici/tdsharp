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
        /// Represents a link to a page containing an embedded video player or a video file 
        /// </summary>
        public partial class InputInlineQueryResult : Object
        {
            /// <summary>
            /// Represents a link to a page containing an embedded video player or a video file 
            /// </summary>
            public class InputInlineQueryResultVideo : InputInlineQueryResult
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputInlineQueryResultVideo";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Unique identifier of the query result 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public string Id { get; set; }

                /// <summary>
                /// Title of the result 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string Title { get; set; }

                /// <summary>
                /// Represents a link to a page containing an embedded video player or a video file 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("description")]
                public string Description { get; set; }

                /// <summary>
                /// The URL of the video thumbnail (JPEG), if it exists 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("thumbnail_url")]
                public string ThumbnailUrl { get; set; }

                /// <summary>
                /// URL of the embedded video player or video file 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("video_url")]
                public string VideoUrl { get; set; }

                /// <summary>
                /// MIME type of the content of the video URL, only "text/html" or "video/mp4" are currently supported
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("mime_type")]
                public string MimeType { get; set; }

                /// <summary>
                /// Width of the video 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("video_width")]
                public int VideoWidth { get; set; }

                /// <summary>
                /// Height of the video 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("video_height")]
                public int VideoHeight { get; set; }

                /// <summary>
                /// Video duration, in seconds
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("video_duration")]
                public int VideoDuration { get; set; }

                /// <summary>
                /// The message reply markup. Must be of type replyMarkupInlineKeyboard or null
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("reply_markup")]
                public ReplyMarkup ReplyMarkup { get; set; }

                /// <summary>
                /// The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageVideo, InputMessageLocation, InputMessageVenue or InputMessageContact
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("input_message_content")]
                public InputMessageContent InputMessageContent { get; set; }
            }
        }
    }
}
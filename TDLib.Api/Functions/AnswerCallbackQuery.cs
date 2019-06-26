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
        /// Sets the result of a callback query; for bots only 
        /// </summary>
        public class AnswerCallbackQuery : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "answerCallbackQuery";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the callback query 
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("callback_query_id")]
            public Int64 CallbackQueryId { get; set; }

            /// <summary>
            /// Text of the answer 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("text")]
            public string Text { get; set; }

            /// <summary>
            /// If true, an alert should be shown to the user instead of a toast notification 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("show_alert")]
            public bool ShowAlert { get; set; }

            /// <summary>
            /// URL to be opened 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("url")]
            public string Url { get; set; }

            /// <summary>
            /// Time during which the result of the query can be cached, in seconds
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("cache_time")]
            public int CacheTime { get; set; }
        }
    }
}
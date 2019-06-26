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
        /// Represents a point on the map 
        /// </summary>
        public partial class InlineQueryResult : Object
        {
            /// <summary>
            /// Represents a point on the map 
            /// </summary>
            public class InlineQueryResultLocation : InlineQueryResult
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inlineQueryResultLocation";

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
                /// Location result 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("location")]
                public Location Location { get; set; }

                /// <summary>
                /// Title of the result 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string Title { get; set; }

                /// <summary>
                /// Result thumbnail; may be null
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("thumbnail")]
                public PhotoSize Thumbnail { get; set; }
            }
        }
    }
}
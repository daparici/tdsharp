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
        /// Removes a hashtag from the list of recently used hashtags 
        /// </summary>
        public class RemoveRecentHashtag : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "removeRecentHashtag";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Hashtag to delete
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("hashtag")]
            public string Hashtag { get; set; }
        }
    }
}
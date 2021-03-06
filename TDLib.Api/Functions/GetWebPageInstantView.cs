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
        /// Returns an instant view version of a web page if available. Returns a 404 error if the web page has no instant view page 
        /// </summary>
        public class GetWebPageInstantView : Function<WebPageInstantView>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getWebPageInstantView";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The web page URL 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("url")]
            public string Url { get; set; }

            /// <summary>
            /// If true, the full instant view for the web page will be returned
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("force_full")]
            public bool ForceFull { get; set; }
        }
    }
}
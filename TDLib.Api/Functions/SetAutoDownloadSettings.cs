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
        /// Sets auto-download settings 
        /// </summary>
        public class SetAutoDownloadSettings : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setAutoDownloadSettings";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// New user auto-download settings 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("settings")]
            public AutoDownloadSettings Settings { get; set; }

            /// <summary>
            /// Type of the network for which the new settings are applied
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("type")]
            public NetworkType Type { get; set; }
        }
    }
}
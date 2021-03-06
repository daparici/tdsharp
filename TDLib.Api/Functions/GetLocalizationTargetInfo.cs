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
        /// Returns information about the current localization target. This is an offline request if only_local is true. Can be called before authorization 
        /// </summary>
        public class GetLocalizationTargetInfo : Function<LocalizationTargetInfo>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getLocalizationTargetInfo";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// If true, returns only locally available information without sending network requests
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("only_local")]
            public bool OnlyLocal { get; set; }
        }
    }
}
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
        /// Deletes a Telegram Passport element 
        /// </summary>
        public class DeletePassportElement : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "deletePassportElement";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Element type
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("type")]
            public PassportElementType Type { get; set; }
        }
    }
}
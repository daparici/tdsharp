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
        /// Creates a new call 
        /// </summary>
        public class CreateCall : Function<CallId>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "createCall";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the user to be called 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public int UserId { get; set; }

            /// <summary>
            /// Description of the call protocols supported by the client
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("protocol")]
            public CallProtocol Protocol { get; set; }
        }
    }
}
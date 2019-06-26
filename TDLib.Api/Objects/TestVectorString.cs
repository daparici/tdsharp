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
        /// A simple object containing a vector of strings; for testing only 
        /// </summary>
        public class TestVectorString : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "testVectorString";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Vector of strings
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("value")]
            public string[] Value { get; set; }
        }
    }
}
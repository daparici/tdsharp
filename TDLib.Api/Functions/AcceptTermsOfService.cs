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
        /// Accepts Telegram terms of services 
        /// </summary>
        public class AcceptTermsOfService : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "acceptTermsOfService";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Terms of service identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("terms_of_service_id")]
            public string TermsOfServiceId { get; set; }
        }
    }
}
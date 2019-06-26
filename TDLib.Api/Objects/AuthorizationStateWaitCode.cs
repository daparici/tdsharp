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
        /// TDLib needs the user's authentication code to finalize authorization 
        /// </summary>
        public partial class AuthorizationState : Object
        {
            /// <summary>
            /// TDLib needs the user's authentication code to finalize authorization 
            /// </summary>
            public class AuthorizationStateWaitCode : AuthorizationState
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "authorizationStateWaitCode";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// True, if the user is already registered 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_registered")]
                public bool IsRegistered { get; set; }

                /// <summary>
                /// Telegram terms of service, which should be accepted before user can continue registration; may be null 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("terms_of_service")]
                public TermsOfService TermsOfService { get; set; }

                /// <summary>
                /// Information about the authorization code that was sent
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("code_info")]
                public AuthenticationCodeInfo CodeInfo { get; set; }
            }
        }
    }
}
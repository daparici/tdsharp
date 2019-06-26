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
        /// The user has been successfully authorized. TDLib is now ready to answer queries
        /// </summary>
        public partial class AuthorizationState : Object
        {
            /// <summary>
            /// The user has been successfully authorized. TDLib is now ready to answer queries
            /// </summary>
            public class AuthorizationStateReady : AuthorizationState
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "authorizationStateReady";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }
            }
        }
    }
}
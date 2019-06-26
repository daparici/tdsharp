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
        /// The user has been authorized, but needs to enter a password to start using the application 
        /// </summary>
        public partial class AuthorizationState : Object
        {
            /// <summary>
            /// The user has been authorized, but needs to enter a password to start using the application 
            /// </summary>
            public class AuthorizationStateWaitPassword : AuthorizationState
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "authorizationStateWaitPassword";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Hint for the password; may be empty 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("password_hint")]
                public string PasswordHint { get; set; }

                /// <summary>
                /// True if a recovery email address has been set up
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("has_recovery_email_address")]
                public bool HasRecoveryEmailAddress { get; set; }

                /// <summary>
                /// Pattern of the email address to which the recovery email was sent; empty until a recovery email has been sent
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("recovery_email_address_pattern")]
                public string RecoveryEmailAddressPattern { get; set; }
            }
        }
    }
}
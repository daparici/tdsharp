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
        /// Finishes user registration. Works only when the current authorization state is authorizationStateWaitRegistration
        /// </summary>
        public class RegisterUser : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "registerUser";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The first name of the user; 1-64 characters 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("first_name")]
            public string FirstName { get; set; }

            /// <summary>
            /// The last name of the user; 0-64 characters
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("last_name")]
            public string LastName { get; set; }
        }
    }
}
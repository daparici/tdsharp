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
        /// The message is being sent now, but has not yet been delivered to the server
        /// </summary>
        public partial class MessageSendingState : Object
        {
            /// <summary>
            /// The message is being sent now, but has not yet been delivered to the server
            /// </summary>
            public class MessageSendingStatePending : MessageSendingState
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageSendingStatePending";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }
            }
        }
    }
}
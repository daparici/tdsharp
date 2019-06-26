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
        /// Toggles whether the message history of a supergroup is available to new members; requires appropriate administrator rights in the supergroup. 
        /// </summary>
        public class ToggleSupergroupIsAllHistoryAvailable : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "toggleSupergroupIsAllHistoryAvailable";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The identifier of the supergroup 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("supergroup_id")]
            public int SupergroupId { get; set; }

            /// <summary>
            /// The new value of is_all_history_available
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_all_history_available")]
            public bool IsAllHistoryAvailable { get; set; }
        }
    }
}
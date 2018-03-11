using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class viewMessages : Method<Ok>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "viewMessages";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long chat_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("message_ids")]
                public long[] message_ids_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("force_read")]
                public bool force_read_;

        }

    }

}

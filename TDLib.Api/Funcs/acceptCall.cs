using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class acceptCall : Method<Ok>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "acceptCall";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("call_id")]
                public int call_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("protocol")]
                public CallProtocol.callProtocol protocol_;

        }

    }

}

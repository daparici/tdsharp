using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class setFileGenerationProgress : Method<Ok>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "setFileGenerationProgress";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("generation_id")]
                public string generation_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("expected_size")]
                public int expected_size_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("local_prefix_size")]
                public int local_prefix_size_;

        }

    }

}

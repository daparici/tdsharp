using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class OptionValue : Structure
    {

        public partial class optionValueInteger : OptionValue
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "optionValueInteger";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("value")]
                public int value_;

        }

    }

}

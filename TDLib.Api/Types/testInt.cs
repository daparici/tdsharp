using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TestInt : Structure
    {

        public partial class testInt : TestInt
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "testInt";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("value")]
                public int value_;

        }

    }

}

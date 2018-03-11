using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class deleteSupergroup : Method<Ok>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "deleteSupergroup";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("supergroup_id")]
                public int supergroup_id_;

        }

    }

}

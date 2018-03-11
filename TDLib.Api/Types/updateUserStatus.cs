using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public partial class updateUserStatus : Update
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "updateUserStatus";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_id")]
                public int user_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("status")]
                public UserStatus status_;

        }

    }

}

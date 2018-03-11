using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class DeviceToken : Structure
    {

        public partial class deviceTokenApplePush : DeviceToken
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "deviceTokenApplePush";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("device_token")]
                public string device_token_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_app_sandbox")]
                public bool is_app_sandbox_;

        }

    }

}

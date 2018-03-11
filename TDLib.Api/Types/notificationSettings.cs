using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class NotificationSettings : Structure
    {

        public partial class notificationSettings : NotificationSettings
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "notificationSettings";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("mute_for")]
                public int mute_for_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sound")]
                public string sound_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("show_preview")]
                public bool show_preview_;

        }

    }

}

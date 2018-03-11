using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Audio : Structure
    {

        public partial class audio : Audio
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "audio";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("duration")]
                public int duration_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string title_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("performer")]
                public string performer_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("file_name")]
                public string file_name_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("mime_type")]
                public string mime_type_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("album_cover_thumbnail")]
                public PhotoSize.photoSize album_cover_thumbnail_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("audio")]
                public File.file audio_;

        }

    }

}

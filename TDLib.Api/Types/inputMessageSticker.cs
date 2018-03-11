using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class InputMessageContent : Structure
    {

        public partial class inputMessageSticker : InputMessageContent
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "inputMessageSticker";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sticker")]
                public InputFile sticker_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("thumbnail")]
                public InputThumbnail.inputThumbnail thumbnail_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("width")]
                public int width_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("height")]
                public int height_;

        }

    }

}

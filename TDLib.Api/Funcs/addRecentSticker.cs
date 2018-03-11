using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class addRecentSticker : Method<Stickers>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "addRecentSticker";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_attached")]
                public bool is_attached_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sticker")]
                public InputFile sticker_;

        }

    }

}

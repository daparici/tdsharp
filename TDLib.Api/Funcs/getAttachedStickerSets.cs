using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class getAttachedStickerSets : Method<StickerSets>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "getAttachedStickerSets";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("file_id")]
                public int file_id_;

        }

    }

}

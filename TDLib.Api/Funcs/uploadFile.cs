using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class uploadFile : Method<File>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "uploadFile";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("file")]
                public InputFile file_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("file_type")]
                public FileType file_type_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("priority")]
                public int priority_;

        }

    }

}

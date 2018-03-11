using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class StorageStatisticsByFileType : Structure
    {

        public partial class storageStatisticsByFileType : StorageStatisticsByFileType
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "storageStatisticsByFileType";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("file_type")]
                public FileType file_type_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("size")]
                public long size_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("count")]
                public int count_;

        }

    }

}

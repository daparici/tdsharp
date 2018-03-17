using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class CancelUploadFile : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "cancelUploadFile";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("file_id")]
        public int FileId { get; set; }

    }

}
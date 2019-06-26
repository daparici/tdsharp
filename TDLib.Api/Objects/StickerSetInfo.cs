using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public partial class TdApi
    {
        /// <summary>
        /// Represents short information about a sticker set 
        /// </summary>
        public class StickerSetInfo : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "stickerSetInfo";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the sticker set 
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("id")]
            public Int64 Id { get; set; }

            /// <summary>
            /// Title of the sticker set 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("title")]
            public string Title { get; set; }

            /// <summary>
            /// Name of the sticker set 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("name")]
            public string Name { get; set; }

            /// <summary>
            /// True, if the sticker set has been installed by current user
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_installed")]
            public bool IsInstalled { get; set; }

            /// <summary>
            /// True, if the sticker set has been archived. A sticker set can't be installed and archived simultaneously 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_archived")]
            public bool IsArchived { get; set; }

            /// <summary>
            /// True, if the sticker set is official 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_official")]
            public bool IsOfficial { get; set; }

            /// <summary>
            /// True, if the stickers in the set are masks
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_masks")]
            public bool IsMasks { get; set; }

            /// <summary>
            /// True for already viewed trending sticker sets 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_viewed")]
            public bool IsViewed { get; set; }

            /// <summary>
            /// Total number of stickers in the set 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("size")]
            public int Size { get; set; }

            /// <summary>
            /// Contains up to the first 5 stickers from the set, depending on the context. If the client needs more stickers the full set should be requested
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("covers")]
            public Sticker[] Covers { get; set; }
        }
    }
}
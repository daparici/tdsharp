using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class WebPage : Structure
    {

        public partial class webPage : WebPage
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "webPage";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("url")]
                public string url_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("display_url")]
                public string display_url_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("type")]
                public string type_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("site_name")]
                public string site_name_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string title_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("description")]
                public string description_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("photo")]
                public Photo.photo photo_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("embed_url")]
                public string embed_url_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("embed_type")]
                public string embed_type_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("embed_width")]
                public int embed_width_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("embed_height")]
                public int embed_height_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("duration")]
                public int duration_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("author")]
                public string author_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("animation")]
                public Animation.animation animation_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("audio")]
                public Audio.audio audio_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("document")]
                public Document.document document_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sticker")]
                public Sticker.sticker sticker_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("video")]
                public Video.video video_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("video_note")]
                public VideoNote.videoNote video_note_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("voice_note")]
                public VoiceNote.voiceNote voice_note_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("has_instant_view")]
                public bool has_instant_view_;

        }

    }

}

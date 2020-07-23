namespace MCU_Matchup.Library.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;


    public partial class ActorDetails
    {
        [JsonProperty("nm0000375")]
        public Nm0000375 Nm0000375 { get; set; }

        //[JsonProperty("image")]
        //public Image Image { get; set; }
    }

    public partial class Nm0000375
    {
        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("knownfor")]
        public object Knownfor { get; set; }

        [JsonProperty("jobs")]
        public object Jobs { get; set; }

        [JsonProperty("starmeter")]
        public object Starmeter { get; set; }

        [JsonProperty("bornon")]
        public object Bornon { get; set; }

        [JsonProperty("charname")]
        public object[] Charname { get; set; }
        
    }

    public partial class Name
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("akas")]
        public string[] Akas { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("legacyNameText")]
        public string LegacyNameText { get; set; }

        [JsonProperty("name")]
        public string NameName { get; set; }
        
    }

    public partial class Image
    {
        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }
    }
}

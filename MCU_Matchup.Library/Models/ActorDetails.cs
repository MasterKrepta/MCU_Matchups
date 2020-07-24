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

        public Image Image { get; set; }
        public Name Name { get; set; }

        //[JsonProperty("image")]
        //public Image Image { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Image
    {
        public int height { get; set; }
        public string id { get; set; }
        public string url { get; set; }
        public int width { get; set; }


    }

    public class Name
    {
        public string @type { get; set; }
        public List<string> akas { get; set; }
        public string id { get; set; }
        public Image image { get; set; }
        public string legacyNameText { get; set; }
        public string name { get; set; }

    }

    public class Nm0000375
    {
        public Name name { get; set; }
        public object knownfor { get; set; }
        public object jobs { get; set; }
        public object starmeter { get; set; }
        public object bornon { get; set; }
        public List<object> charname { get; set; }

    }

    public class Root
    {
        public Nm0000375 nm0000375 { get; set; }

    }



    //public partial class Nm0000375
    //{
    //    [JsonProperty("name")]
    //    public Name Name { get; set; }

    //    [JsonProperty("knownfor")]
    //    public object Knownfor { get; set; }

    //    [JsonProperty("jobs")]
    //    public object Jobs { get; set; }

    //    [JsonProperty("starmeter")]
    //    public object Starmeter { get; set; }

    //    [JsonProperty("bornon")]
    //    public object Bornon { get; set; }

    //    [JsonProperty("charname")]
    //    public object[] Charname { get; set; }

    //}

    //public partial class Name
    //{
    //    [JsonProperty("@type")]
    //    public string Type { get; set; }

    //    [JsonProperty("akas")]
    //    public string[] Akas { get; set; }

    //    [JsonProperty("id")]
    //    public string Id { get; set; }

    //    [JsonProperty("image")]
    //    public Image Image { get; set; }

    //    [JsonProperty("legacyNameText")]
    //    public string LegacyNameText { get; set; }

    //    [JsonProperty("name")]
    //    public string NameName { get; set; }

    //}

    //public partial class Image
    //{
    //    [JsonProperty("height")]
    //    public long Height { get; set; }

    //    [JsonProperty("id")]
    //    public string Id { get; set; }

    //    [JsonProperty("url")]
    //    public Uri Url { get; set; }

    //    [JsonProperty("width")]
    //    public long Width { get; set; }
    //}
}

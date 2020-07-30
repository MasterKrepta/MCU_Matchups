using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MCU_Matchup.Library.Models
{
    public class Biography
    {
        [JsonProperty("full-name")]
        public string FullName { get; set; }
        [JsonProperty("alter-egos")]
        public string AlterEgos { get; set; }
        //public Aliases Aliases { get; set; }
    }
}

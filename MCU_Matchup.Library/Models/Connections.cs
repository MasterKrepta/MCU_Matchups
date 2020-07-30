using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MCU_Matchup.Library.Models
{
    public class Connections
    {
        [JsonProperty("group-affiliation")]
        public string GroupAffiliations { get; set; }
        public string Relatives { get; set; }
    }
}

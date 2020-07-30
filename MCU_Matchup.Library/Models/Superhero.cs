using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MCU_Matchup.Library.Models
{


    public class Superhero
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public PowerStats PowerStats { get; set; }
        public Biography Biography { get; set; }
        public Appearance Appearance { get; set; }
        public Work Work { get; set; }
        public Connections Connections { get; set; }

        [JsonProperty("image")]
        public ImageUrl ImageUrl { get; set; }

    }
}

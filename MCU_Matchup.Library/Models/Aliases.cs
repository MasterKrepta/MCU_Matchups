﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MCU_Matchup.Library.Models
{
    public class Aliases
    {
        [JsonProperty("aliases")]
        public List<string> AliasNames { get; set; } = new List<string>();
    }
}

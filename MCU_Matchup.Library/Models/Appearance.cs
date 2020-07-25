using System;
using System.Collections.Generic;
using System.Text;

namespace MCU_Matchup.Library.Models
{
    public class Appearance
    {
        public string Gender { get; set; }
        public string Race { get; set; }
        public Height Height { get; set; }
        public Weight Weight { get; set; }
        public string EyeColor { get; set; }
        public string HairColor { get; set; }
    }
}

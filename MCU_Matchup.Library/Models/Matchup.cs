using System;
using System.Collections.Generic;
using System.Text;
using MCU_Matchup.Library;
using MCU_Matchup.Library.DataAccess;

namespace MCU_Matchup.Library.Models
{
    public class Matchup
    {
        public Superhero SuperHero_1 { get; set; }
        public Superhero SuperHero_2 { get; set; }
        public Scenario Scenario { get; set; }
        private readonly DataAccess.DataAccess _dataAccess;

        public Matchup( string charOne, string charTwo, DataAccess.DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
            SuperHero_1 = _dataAccess.GetSuperHero(charOne);
            SuperHero_2 = _dataAccess.GetSuperHero(charTwo);
            Scenario = _dataAccess.GetRandomScenario();
        }
    }
}

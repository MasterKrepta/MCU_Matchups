using System;
using System.Collections.Generic;
using System.Text;
using MCU_Matchup.Library;
using MCU_Matchup.Library.DataAccess;
using MCU_Matchup.Library.Logic;

namespace MCU_Matchup.Library.Models
{
    public class Matchup
    {
        public int Id { get; set; }
        public Superhero SuperHero_1 { get; set; }
        public Superhero SuperHero_2 { get; set; }
        public Scenario Scenario { get; set; }
        private readonly DataAccess.DataAccess _dataAccess;

        public Matchup( string charOne, string charTwo, DataAccess.DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
            SuperHero_1 = _dataAccess.GetSuperHero(charOne);
            SuperHero_2 = _dataAccess.GetSuperHero(charTwo);
             

            //Prevent duplicates
            if (SuperHero_2.Name == SuperHero_1.Name)
            {
                var newChar = Helpers.GetRandomCharacters();
                
                while (newChar[0] != SuperHero_1.Name && newChar[1] != SuperHero_1.Name)
                {
                    newChar = Helpers.GetRandomCharacters();
                }

                SuperHero_2 = _dataAccess.GetSuperHero(newChar[0]);
            }
            
            Scenario = _dataAccess.GetRandomScenario();
            
        }
    }
}

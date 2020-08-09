using MCU_Matchup.Library.Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MCU_Matchup.Library.Models
{
    public class Scenario
    {
        
        
        public string Name { get; set; }
        public string Text { get; set; }
        //Todo add datarules for matchup

        public int DifficultyLevel { get; set; }

        //! this could be used if we add an RPG element to the site
        public int ScorePointsToGive { get; set; }

        public ScenarioRules Rules { get; set; }

        
        /// <summary>
        /// 
        /// Select most powerful stat to score the winner
        /// If RPG is included: Add a modifier to the scores based on current character level
        /// </summary>


    }
}

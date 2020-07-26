﻿using System;
using System.Collections.Generic;
using System.Text;
using MCU_Matchup.Library;
using MCU_Matchup.Library.DataAccess;

namespace MCU_Matchup.Library.Models
{
    public class Matchup
    {
        public ActorDetails Actor_One { get; set; }
        public ActorDetails Actor_Two { get; set; }
        public Superhero SuperHero_1 { get; set; }
        public Superhero SuperHero_2 { get; set; }
        private readonly DataAccess.DataAccess _dataAccess;

        public Matchup( string charOne, string charTwo, DataAccess.DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
            SuperHero_1 = _dataAccess.GetSuperHero(charOne);
            SuperHero_2 = _dataAccess.GetSuperHero(charTwo);
            //Actor_One  = _dataAccess.GetCharacterFromIMDB(charOne);
            //Actor_Two = _dataAccess.GetCharacterFromIMDB(charTwo);
        }
    }
}
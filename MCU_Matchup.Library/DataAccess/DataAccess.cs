﻿using MCU_Matchup.Library.Models;
using RestSharp;
using Newtonsoft.Json;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;
using System.Linq;

namespace MCU_Matchup.Library.DataAccess
{

    public class DataAccess
    {

        //https://rapidapi.com/apidojo/api/imdb8?endpoint=apiendpoint_b6d49d19-162a-402b-a4df-f7862b760372


        public Superhero GetSuperHero(string characterName)
        {
            var client = new RestClient($"https://superheroapi.com/api/10158692382838980/search/{characterName}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            SuperHeroResultsModel hero = JsonConvert.DeserializeObject<SuperHeroResultsModel>(response.Content);

            return hero.Results[0];
        }

        public Matchup GetMatchup(string characterOne, string characterTwo)
        {
            return new Matchup(characterOne, characterTwo, this);
            
        }
    }
}

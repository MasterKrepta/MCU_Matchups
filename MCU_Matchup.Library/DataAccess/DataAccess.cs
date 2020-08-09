using MCU_Matchup.Library.Models;
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


        public Superhero GetSuperHero(string characterId)
        {
            //todo research to set this explicity: thor is returning lex luthor by mistake. 
            
            var client = new RestClient($"https://superheroapi.com/api/10158692382838980/{characterId}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            //prevents nulls, since API is out of our control
            response.Content = response.Content.Replace("null", "0");


            Superhero hero = JsonConvert.DeserializeObject<Superhero>(response.Content);
            return hero;
        }

        public Scenario GetRandomScenario()
        {
            Scenario s = Helpers.GetRandomScenario();
            //s.Rules.InitModifiers();

            return s;
        }
        public Matchup GetMatchup(string characterOne, string characterTwo)
        {
            return new Matchup(characterOne, characterTwo, this);
            
        }
  
    }
}

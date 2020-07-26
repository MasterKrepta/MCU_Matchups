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

    //using RestSharp;
    //using RestSharp.Authenticators;

    //var client = new RestClient("https://api.twitter.com/1.1");
    //client.Authenticator = new HttpBasicAuthenticator("username", "password");

    //var request = new RestRequest("statuses/home_timeline.json", DataFormat.Json);

    //var response = client.Get(request);
    public class DataAccess
    {

        //https://rapidapi.com/apidojo/api/imdb8?endpoint=apiendpoint_b6d49d19-162a-402b-a4df-f7862b760372


        public Superhero GetSuperHero(string characterName)
        {
            var client = new RestClient($"https://superheroapi.com/api/10158692382838980/search/{characterName}");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            JToken token;
            try
            {
                token = JToken.Parse(response.Content);
            }
            catch (Exception)
            {

                throw;
            }
            //todo impliment this instead - all null
            //Superhero hero = JsonConvert.DeserializeObject<Superhero>(response.Content);

            //Superhero hero = response.Content.ReadFromJson<Superhero>(); //https://www.youtube.com/watch?v=cwgck1k0YKU

            Superhero superhero = new Superhero();
            
                //TODO REFACTOR: This should be parsed simpler with .NET
                superhero = new Superhero
                {
                    
                    Name = (string)token.SelectToken("results[0].name"),
                    PowerStats = GetPowerStats(token),
                    Biography = GetBiography(token),
                    Appearance = GetAppearance(token),
                    Work = GetWork(token),
                    Connections = GetConnections(token),
                    ImageUrl = (string)token.SelectToken("results[0].image.url")
                };
            
       

            return superhero;

        }

        private PowerStats GetPowerStats(JToken token)
        {

            
            var power = new PowerStats
            {
                
                Combat = (int)token.SelectToken("results[0].powerstats.combat"),

                Durability = (int)token.SelectToken("results[0].powerstats.durability"),
                Intelligence = (int)token.SelectToken("results[0].powerstats.intelligence"),
                Power = (int)token.SelectToken("results[0].powerstats.power"),
                Speed = (int)token.SelectToken("results[0].powerstats.speed"),
                Strength = (int)token.SelectToken("results[0].powerstats.strength")
            };

            return power;
        }

        private Connections GetConnections(JToken token)
        {
            var conn = new Connections
            {
                GroupAffiliations = (string)token.SelectToken("results[0].connections.group-affiliation"),
                Relatives = (string)token.SelectToken("results[0].connections.relatives")
            };

            return conn;
        }
        private Work GetWork(JToken token)
        {
            var work = new Work
            {
                Base = (string)token.SelectToken("results[0].work.base"),
                Occupation = (string)token.SelectToken("results[0].work.occupation")
            };
            return work;
        }

        private Appearance GetAppearance(JToken token)
        {
            var appearance = new Appearance
            {
                Gender = (string)token.SelectToken("results[0].appearance.gender"),
                Race = (string)token.SelectToken("results[0].appearance.race"),
                Height = GetHeight(token),
                Weight = GetWeight(token),
                EyeColor = (string)token.SelectToken("results[0].appearance.eye-color"),
                HairColor = (string)token.SelectToken("results[0].appearance.hair-color")

            };

            return appearance;

        }


        private Biography GetBiography(JToken token)
        {
            var bio = new Biography
            {
                FullName = (string)token.SelectToken("results[0].biography.full-name"),
                AlterEgos = (string)token.SelectToken("results[0].biography.alter-egos"),
                Aliases = GetAliases(token)

        };

            return bio;
        }

        private Weight GetWeight(JToken token)
        {
            var data = token.SelectToken("results[0].appearance.weight");

            var weight = new Weight();
            foreach (var a in data)
            {
                weight.WeightDetails.Add(a.ToString());
            }


            return weight;
        }

        private Height GetHeight(JToken token)
        {
            var data = token.SelectToken("results[0].appearance.height");

            var height = new Height();
            foreach (var a in data)
            {
                height.HeightList.Add(a.ToString());
            }


            return height;
        }

        private Aliases GetAliases(JToken token)
        {
            var data = token.SelectToken("results[0].biography.aliases");
            
            var alias = new Aliases();
            foreach (var a in data)
            {
                alias.AliasNames.Add(a.ToString());
            }
            

            return alias;
        }
    //public ActorDetails GetCharacterFromIMDB(string character)
    //    {

            
    //        var client = new RestClient($"https://imdb8.p.rapidapi.com/title/get-charname-list?currentCountry=US&marketplace=ATVPDKIKX0DER&purchaseCountry=US&id={character}&tconst=tt0944947");
    //        var request = new RestRequest(Method.GET);
    //        request.AddHeader("x-rapidapi-host", "imdb8.p.rapidapi.com");
    //        request.AddHeader("x-rapidapi-key", "3acacf8feemsh8281560185a0955p1e8594jsn954f4395d7b5");
    //        IRestResponse response = client.Execute(request);


    //        JToken token = JToken.Parse(response.Content);
    //        string query = $"{character}[0]";
    //        JArray name = (JArray)token.SelectToken(query);
            

    //        //TODO parse the json into usable data
    //        ActorDetails actor = JsonConvert.DeserializeObject<ActorDetails>(response.Content);
            
           

    //        return actor;
    //    }

        public Matchup GetMatchup(string characterOne, string characterTwo)
        {
            return new Matchup(characterOne, characterTwo, this);
            
        }
    }
}

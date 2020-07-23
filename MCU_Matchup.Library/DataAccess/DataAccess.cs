using MCU_Matchup.Library.Models;
using RestSharp;
using Newtonsoft.Json;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Text;

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
        public ActorDetails GetCharacter(string character)
        {
            var client = new RestClient($"https://imdb8.p.rapidapi.com/title/get-charname-list?currentCountry=US&marketplace=ATVPDKIKX0DER&purchaseCountry=US&id={character}&tconst=tt0944947");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "imdb8.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "3acacf8feemsh8281560185a0955p1e8594jsn954f4395d7b5");
            IRestResponse response = client.Execute(request);

            //TODO parse the json into usable data
            ActorDetails actor = JsonConvert.DeserializeObject<ActorDetails>(response.Content);
            
           

            return actor;
        }
    }
}

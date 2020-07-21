using RestSharp;
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

        public void GetCharacter(string name)
        {
            var client = new RestClient("https://imdb8.p.rapidapi.com/title/get-top-cast?tconst=tt0944947");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "imdb8.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "3acacf8feemsh8281560185a0955p1e8594jsn954f4395d7b5");
            IRestResponse response = client.Execute(request);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace MCU_Matchup.Library.DataAccess
{
    public static class Helpers
    {
        public static HttpClient ApiClient { get; set; } = new HttpClient();


        public static void InitialzeClient()
        {
            ApiClient = new HttpClient();
            //ApiClient.BaseAddress = new Uri("https://superheroapi.com/api");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        //https://www.imdb.com/title/tt4154796/fullcredits/?ref_=tt_ov_st_sm
        public const string IronMan = "ironman";/*"nm0000375";*/
        public const string CaptainAmerica = "nm0262635";
        public const string Hulk = "hulk";/*"nm0749263";*/
        public const string Thor = "nm11651100";
        public const string BlackWidow = "nm0424060";
        public const string HawkEye = "nm0719637";
        public const string WarMachine = "nm0000332";
        public const string AntMan = "nm0748620";
        public const string DrStrange = "nm1212722";
        public const string BlackPanther = "nm1569276";
        public const string CaptainMarvel = "nm0488953";
        public const string SpiderMan = "nm4043618";
        public const string Nebula = "nm2394794";
        public const string Gamora = "nm0757855";
        public const string Wasp = "nm1431940";
        //public const string Valkyrie = "nm1935086";
        public const string ScarletWitch = "nm0647634";
        public const string Falcon = "nm1107001";
        public const string Bucky = "nm1659221";
        public const string Loki = "nm1089991";

        //! list can return lex luthor for unknown reasons
        public static  IList<string> Characters = new ReadOnlyCollection<string>(new List<string>
        {
            "ironman",
            "hulk",
            "captain_america",
            "thor",
            "black_widow",
            "hawkeye",
            "war_machine",
            "ant_man",
            "doctor_strange",
            "black_panther",
            "spider_man",
            "nebula",
            "gamora",
            "wasp",
            //"valkyrie",
            "scarlet_witch",
            "falcon",
            "winter_soldier",
            "loki"
        });
        

        public static List<string> GetRandomCharacters()
        {
            var result = new List<string>();
            Random rnd = new Random();

            int first = rnd.Next(Characters.Count);
            int second = rnd.Next(Characters.Count);

            result.Add(Characters[first]);
            result.Add(Characters[second]);

            return result;


        }
    }
}

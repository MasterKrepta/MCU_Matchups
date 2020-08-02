﻿using MCU_Matchup.Library.Models;
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

        //! list can return lex luthor for unknown reasons
        static IList<string> Characters = new ReadOnlyCollection<string>(new List<string>
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
            "valkyrie",
            "scarlet_witch",
            "falcon",
            "winter_soldier",
            "loki"
        });

        static List<Scenario> Scenarios = new List<Scenario>()
        {
            new Scenario(){ Name = "Iron Man 2020 #5", Text = "Tony Stark is back !But is this the REAL Tony ? How is that possible ? !Where did that all - new armor come from ? !WHAT'S GOING ON?! There's no time to explain,                 human.Just know this: It's STARK VS. STARK ROUND 2, as Tony takes on Arno...in SPACE! Rated T+" },
            new Scenario(){ Name = "Captain Marvel #18", Text = "CAPTAIN MARVEL IS THE SUPREME ACCUSER! In the throes of war, Carol finds herself with a bold new role - and a brand-new weapon - the Universal Weapon, in fact. When a Kree soldier bombs a unified city of the Empire, Emperor Hulkling sends his new Accuser to bring down the swift and necessary hammer of justice. But what at first seems like a relatively simple directive will end up challenging Carol on a personal level she had never imagined."},
            new Scenario(){ Name = "Amazing Spider-Man #45", Text = "'SINS RISING' PART 1!  SIN-EATER is back and New York City is in TROUBLE.  Who will the shotgun-toting villain target, and can Spider-Man stand a chance against him?"},
            new Scenario(){ Name = "Symbiote Spider-Man Alien Reality #5", Text = "Thanks to the combined efforts of Nightmare, Dormammu and the Hobgoblin, the universe is fracturing like you've never seen before - REALITY ITSELF IS COLLAPSING!  The team behind the original Symbiote Spider-Man series closes out the second volume with a BANG! You won't want to miss this one!"},
            new Scenario(){ Name = "X-Men #10", Text= "EMPYRE TIE-IN! The Summers family has grown a Krakoan home on the moon. Now some new neighbors have moved in."}
        };  
        
        public static Scenario GetRandomScenario()
        {
            Random rnd = new Random();
            int selected = rnd.Next(Scenarios.Count);
            
            return Scenarios[selected];
        }
                
            

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

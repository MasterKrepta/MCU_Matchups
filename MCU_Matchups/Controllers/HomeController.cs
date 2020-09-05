using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MCU_Matchups.Models;
using MCU_Matchup.Library.DataAccess;
using MCU_Matchup.Library.Models;
using MCU_Matchup.Library.Logic;

namespace MCU_Matchups.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataAccess _dataAccess;
        private readonly MatchupProcessor _matchupProcessor;

        public HomeController(ILogger<HomeController> logger, DataAccess dataAccess/*, *MatchupProcessor matchupProcessor*/)
        {
            _logger = logger;
            _dataAccess = dataAccess;
            //_matchupProcessor = matchupProcessor;
        }

        public IActionResult Index()
        {
            //ActorDetails model = _dataAccess.GetCharacterFromIMDB(Helpers.IronMan);
            var randomMatchup = Helpers.GetRandomCharacters();
            Matchup model = _dataAccess.GetMatchup(randomMatchup[0], randomMatchup[1]);

            return View(model);
        }


        public IActionResult LoadMatchup()
        {
            var randomMatchup = Helpers.GetRandomCharacters();
            Matchup model = _dataAccess.GetMatchup(randomMatchup[0], randomMatchup[1]);

            return View(model);
        }

        public IActionResult ScoreMatchup(string hero1, string hero2)
        {
            var winner = _dataAccess.GetSuperHero(hero1);
            //todo what should i return (make endpoint model)?
            return View(winner);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

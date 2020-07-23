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

namespace MCU_Matchups.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataAccess _dataAccess;

        public HomeController(ILogger<HomeController> logger, DataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        public IActionResult Index()
        {
            ActorDetails model = _dataAccess.GetCharacter(Helpers.IronMan);


            return View(model);
        }


        public IActionResult LoadMatchup()
        {
            ActorDetails model = _dataAccess.GetCharacter(Helpers.IronMan);

            return View(model);
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

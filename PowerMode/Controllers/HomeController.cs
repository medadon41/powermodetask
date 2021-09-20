using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PowerMode.Data;
using PowerMode.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PowerMode.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PowerModeContext _context;

        public HomeController(ILogger<HomeController> logger, PowerModeContext context)
        {
            _logger = logger;
            _context = context;
        }

        public List<Areas.Identity.Data.PowerUser> GetUsers(string social) =>
           (from u in _context.Users where u.Social == social select u).ToList();

        public IActionResult Index()
        {
            var numberOfPeople = new List<int>();
            numberOfPeople.Add(GetUsers("Facebook").Count);
            numberOfPeople.Add(GetUsers("Vkontakte").Count);
            numberOfPeople.Add(GetUsers("Google").Count);

            ViewBag.NumberOfPeople = numberOfPeople;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

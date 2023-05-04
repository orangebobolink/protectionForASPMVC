using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prot.Data;
using prot.Models;
using System.Diagnostics;

namespace prot.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ApplicationContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var items = _context.Matchs.AsNoTracking().ToList();
            return View(items);
        }

        public IActionResult Bet(int matchId, string commandOne, string commandTwo, DateTime date)
        {
            if(date <= DateTime.Now)
            {
                return RedirectToAction("Index");
            }

            return View(new Bet
            {
                MatchId = matchId,
                Match = new Match
                {
                    Id = matchId,
                    CommandOne = commandOne,
                    CommandTwo = commandTwo,
                    Date = date
                }
            });
        }

        [HttpPost]
        public IActionResult CreateBet(Bet bet)
        {

            _context.Bets.Add(bet);
            _context.SaveChanges();

            return RedirectToAction("Index");
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
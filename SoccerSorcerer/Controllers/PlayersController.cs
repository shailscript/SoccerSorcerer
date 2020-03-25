//Shailendra Shukla - 301057291

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoccerSorcerer.Models;

namespace SoccerSorcerer.Controllers
{
    public class PlayersController : Controller
    {
        private IPlayerRepository repository;

        public PlayersController(IPlayerRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index() => View(repository.Players);
        
        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Player player)
        {
            //FakeClubRepository.AddClub(c);
            repository.AddPlayer(player);
            return RedirectToAction("Index");
        }

        public IActionResult Show() => View();
    }
}

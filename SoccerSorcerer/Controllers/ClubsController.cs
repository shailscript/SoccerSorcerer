//Shailendra Shukla - 301057291

using Microsoft.AspNetCore.Mvc;
using SoccerSorcerer.Models;

namespace SoccerSorcerer.Controllers
{
    public class ClubsController : Controller
    {
        private IClubRepository repository;

        public ClubsController(IClubRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index() => View(repository.Clubs);

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Club c)
        {
            FakeClubRepository.AddClub(c);
            return RedirectToAction("Index");
        }

        public IActionResult Show() => View();
    }
}

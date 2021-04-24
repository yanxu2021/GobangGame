using Microsoft.AspNetCore.Mvc;
using GobangGame.Models;
using System.Linq;

namespace GobangGame.Controllers
{
    public class HomeController : Controller
    {
        private IGameRepository repository;
        public int PageSize = 3;
        public HomeController(IGameRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index(int gamePage = 1)=> View(repository.Games.OrderBy(g => g.ID).Skip((gamePage - 1) * PageSize).Take(PageSize));
   
    }
}
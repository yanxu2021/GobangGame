using Microsoft.AspNetCore.Mvc;
using GobangGame.Models;
using System.Linq;
using GobangGame.Models.ViewModels;

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
        public ViewResult Index(int gamePage = 1)=> View(new RecordViewModel
            {
            Games = repository.Games.OrderBy(g => g.ID).Skip((gamePage - 1) * PageSize).Take(PageSize),
            PagingInfo = new PagingInfo
                {
                    CurrentPage = gamePage,
                    RecordsPerPage = PageSize,
                    TotalRecords = repository.Games.Count()
                 }
            });       
    }
}
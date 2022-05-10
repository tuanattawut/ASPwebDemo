
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index(int id)
        {
            var repo = new MovieRepository();
            var data = repo.GetMovies().Where(m => m.Id == id);
            return View(data);
        }
    }
}
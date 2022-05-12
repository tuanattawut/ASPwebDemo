
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index(int? id,String youtube)
        {
            var repo = new MovieRepository();
            var data = repo.GetMovies();
            if(id != null){
                data = data.Where(m=>m.Id == id ).ToList();
            }
        if(youtube != null){
        ViewData["youtube"] = youtube;}
            return View(data);
        }
    }
}
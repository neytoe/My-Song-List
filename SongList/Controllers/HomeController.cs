using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SongList.Models;
using System.Linq;

namespace SongList.Controllers
{
    public class HomeController : Controller
    {
        private SongContext context { get; set; }
        public HomeController(SongContext ctx)
        {
            context = ctx;
        }


        public IActionResult Index()
        {
            //Retrieve all songs 
            var songs = context.Songs.Include(s => s.Genre).OrderBy(m => m.year).ToList();
            return View(songs);
        }
    }
}

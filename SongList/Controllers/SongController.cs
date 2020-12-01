using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SongList.Models;

namespace SongList.Controllers
{
    public class SongController : Controller
    {
        private SongContext context { get; set; }
        public SongController(SongContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult Add(Song song)
        {
            ViewBag.Action = "Add";
            return View("Edit", new Song());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var song = context.Songs.Find(id);
            return View("Edit", song);
        }

        [HttpPost]
        public IActionResult Edit(Song song)
        {
            if (ModelState.IsValid)
            {
               if (song.SongID == 0)
                {
                    context.Songs.Add(song);                 
                }
                else
                {
                    context.Songs.Update(song);
                }
                context.SaveChanges();
                return RedirectToAction("index", "Home");
            }
            else
            {
                ViewBag.Action = song.SongID == 0 ? "Add" : "Edit";
                return View(song);
            }
            
        }

        [HttpGet]
        public IActionResult Delete (int id)
        {
            var Song = context.Songs.Find(id);
            return View(Song);
        }

        [HttpDelete]
        public IActionResult Delete(Song song)
        {
            context.Songs.Remove(song);
            context.SaveChanges();

            return RedirectToAction("index", "Home");
           
        }
    }
}

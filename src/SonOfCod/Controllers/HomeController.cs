using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;
using Microsoft.EntityFrameworkCore;

namespace SonOfCod.Controllers
{
    public class HomeController : Controller
    {
        private readonly SOCContext _db = new SOCContext();

        public IActionResult Index()
        {
            var funblurb = _db.Content.FirstOrDefault(blurb => blurb.Type == "funblurb");
            ViewBag.Thing = "thing";
            ViewBag.FunBlurb = funblurb;
            return View();
        }

        public IActionResult Edit(int id)
        {
            var thisContent = _db.Content.FirstOrDefault(c => c.Id == id);
            return View(thisContent);
        }

        [HttpPost]
        public IActionResult Edit(Content content)
        {
            _db.Entry(content).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

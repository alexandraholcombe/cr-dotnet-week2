using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;

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
    }
}

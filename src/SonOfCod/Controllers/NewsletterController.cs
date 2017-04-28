using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SonOfCod.Controllers
{
    public class NewsletterController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Subscribe");
        }

        public IActionResult Subscribe()
        {
            return View();
        }
    }
}

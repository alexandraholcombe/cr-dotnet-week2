using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;

namespace SonOfCod.Controllers
{
    public class NewsletterController : Controller
    {
        private readonly SOCContext _db = new SOCContext();

        public IActionResult Index()
        {
            return RedirectToAction("Subscribe");
        }

        public IActionResult Subscribe()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Subscribe(Subscriber subscriber)
        {
            _db.Subscribers.Add(subscriber);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

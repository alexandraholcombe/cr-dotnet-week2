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
            ViewBag.Subscribers = _db.Subscribers.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Subscribe(Subscriber subscriber)
        {
            _db.Subscribers.Add(subscriber);
            _db.SaveChanges();
            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            var thisSubscriber = _db.Subscribers.FirstOrDefault(s => s.Id == id);
            return View(thisSubscriber);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisSubscriber = _db.Subscribers.FirstOrDefault(s => s.Id == id);
            _db.Subscribers.Remove(thisSubscriber);
            _db.SaveChanges();
            return RedirectToAction("Subscribe");
        }
    }
}

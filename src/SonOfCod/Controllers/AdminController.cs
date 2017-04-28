using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SonOfCod.Models;

namespace SonOfCod.Controllers
{
    public class AccountController : Controller
    {
        private readonly SOCContext _db;
        private readonly UserManager<Admin> _userManager;
        private readonly SignInManager<Admin> _signInManager;

        public AccountController(UserManager<Admin> userManager, SignInManager<Admin> signInManager, SOCContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
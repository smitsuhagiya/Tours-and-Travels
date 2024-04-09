using Microsoft.AspNetCore.Mvc;
using Seeindia.Data;
using Seeindia.Models;
using SeeIndia.Models;
using System.Diagnostics;

namespace Seeindia.Controllers
{
    public class HomeController : Controller
    {
        private dbcontext s2;

        public HomeController(dbcontext dbcontext)
        {
            s2 = dbcontext;
        }

        public IActionResult Index() 
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Gold()
        {
            return View();
        }

        public IActionResult Silver()
        {
            return View();
        }

        public IActionResult Diamond()
        {
            return View();
        }
        public IActionResult India()
        {
            return View();
        }
        public IActionResult Switzerland()
        {
            return View();
        }
        public IActionResult London()
        {
            return View();
        }
        public IActionResult Dubai()
        {
            return View();
        }
        public IActionResult Account()
        {
            return View();
        }
        public IActionResult cart()
        {
            return View();
        }
        public IActionResult Wishlist()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UserModel abc)
        {
            var user = s2.Users.FirstOrDefault(u => u.UserName == abc.UserName && u.UserPassword == abc.UserPassword);
            if (user != null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "Login Failed !!!";
            }
            return View(abc);
        }
        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Signup(UserModel abc)
        {
            s2.Users.Add(abc);
            s2.SaveChanges();

            return RedirectToAction("Login");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

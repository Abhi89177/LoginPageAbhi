using LoginPageAbhi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
namespace LoginPageAbhi.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentLoginDBContext studentLoginDB;

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(StudentLoginDBContext studentLoginDB)
        {
            this.studentLoginDB = studentLoginDB;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(StudentLogin obj)
        {
            var myuser = studentLoginDB.studentLogins.Where(x => x.Email == obj.Email && x.Password == obj.Password).FirstOrDefault();
            if(myuser != null)
            {
                HttpContext.Session.SetString("UserSession", myuser.Email);
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.message = "Login Failed...";
            }
            return View();
        }
        public IActionResult DashBoard()
        {
           
            if(HttpContext.Session.GetString("UserSession")!=null)
            {
                ViewBag.Abhi = HttpContext.Session.GetString("UserSession").ToString();
            }
            else
            {
                return RedirectToAction("Login");
            }
            return View();
        }
        public IActionResult Logout()
        {
            if(HttpContext.Session.GetString("UserSession")!= null)
            {
                HttpContext.Session.Remove("UserSession");
                return RedirectToAction("Login");
            }
            return View();
        }


        public IActionResult Register(StudentLogin stdobj)
        {
            if(ModelState.IsValid)
            {
                 studentLoginDB.studentLogins.Add(stdobj);
                studentLoginDB.SaveChanges();
                TempData["Success"] = "Registerd SuccessFully";
                return RedirectToAction("login");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

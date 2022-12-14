using LearningEFCore.Entities;
using LearningEFCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LearningEFCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DatabaseContext db = new DatabaseContext();
            
            if (db.Users.Any() == false)
            {
                User user = new User()
                {
                    FullName = "Murat Başeren"
                };

                db.Users.Add(user);
                db.SaveChanges();
            }
            
            db.Users.ToList();

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
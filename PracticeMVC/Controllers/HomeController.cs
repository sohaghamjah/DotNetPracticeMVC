using Microsoft.AspNetCore.Mvc;
using PracticeMVC.Models;
using System.Diagnostics;

namespace PracticeMVC.Controllers
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
            //ViewData["company"] = "Akij Takaful Life Insurance";
            //ViewData["established"] = DateTime.Now.ToLongDateString();
            //string[] EmployeeNames = { "Sohag", "Shamim", "Salauddin" };
            //ViewData["EmployeeNames"] = EmployeeNames;

            //ViewData["AgentNames"] = new List<string>() {
            //    "Agent 1","Agent 2","Agent 3"
            //};

            var students = new List<StudnetModel> {
                new StudnetModel {Name = "Sohag Hamjah", Roll = 11, Gender = "Male"},
                new StudnetModel {Name = "Jhon Due", Roll = 12, Gender = "Male"},
                new StudnetModel {Name = "Mis A", Roll = 13, Gender = "Female"},
            };

            ViewData["AllStudents"] = students;

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

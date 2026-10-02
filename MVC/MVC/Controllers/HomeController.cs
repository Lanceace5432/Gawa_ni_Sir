using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Diagnostics;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            StudentModel student = new StudentModel();
            student.ID = 1;
            student.FirstName = "Ace";
            student.MiddleName = "Jimuel";
            student.LastName = "Ervin";
            student.Address = "Pasig City";

            StudentModel stud = new StudentModel();
            stud.FirstName = "Louis";

            ViewBag.KahitAno = "Welcome mga students!";
            ViewData["KahitAnoRinTo"] = 1235;

            return View(student);
        }

        public IActionResult Privacy()
        {
            List<StudentModel> students = new List<StudentModel>();
            students.Add(new StudentModel
            {
                ID = 1,
                FirstName = "Ace",
                MiddleName = "Jimuel",
                LastName = "Ervin",
                Address = "Pasig City"
            });
            students.Add(new StudentModel
            {
                ID = 2,
                FirstName = "Louis",
                MiddleName = "Andrey",
                LastName = "Martin",
                Address = "Maui City"
            });

            students.Add(new StudentModel
            {
                ID = 3,
                FirstName = "Ralph",
                MiddleName = "Laurence",
                LastName = "Rod",
                Address = "Mandaluyong City"
            });
       

            return View(students);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

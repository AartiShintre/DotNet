using Microsoft.AspNetCore.Mvc;
using StudentApp.Models;   

namespace studentApp.Controllers   // ✅ FIXED
{
    public class StudentController : Controller
    {
        static List<Student> students = new List<Student>();

        public IActionResult Index()
        {
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                students.Add(s);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
using Lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public class StudentController : Controller
    {
        public string ShowString()
        {
            return "Message From Controller";
        }
        public int ShowNum()
        {
            return 10;
        }
        public int ShowId(int id)
        {
            return id + 10;
        }
        public IActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ Id = 1, Name = "Omar"},
                new Student(){ Id = 2, Name = "Ahmed"},
                new Student(){ Id = 3, Name = "Mohamed"},
                new Student(){ Id = 4, Name = "Fathy"},

            };
            return View(students);
        }
    }
}

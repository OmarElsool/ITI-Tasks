using Lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public class DepartmentController : Controller
    {
        public int ShowIdByQuery()
        {
            int id = int.Parse(Request.Query["id"]);
            return id + 10;
        }
        public IActionResult Index()
        {
            List<Department> department = new List<Department>()
            {
                new Department(){Id = 1, Name = "SD"},
                new Department(){Id = 2, Name = "Web"},
                new Department(){Id = 3, Name = "Mobile"},
                new Department(){Id = 4, Name = ".Net"},

            };
            ViewData["Department"] = department;
            return View();
        }
    }
}

using Lab2.Models;
using Lab2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class DepartmentController : Controller
    {
        IEntity<Department> deptdb;
        public DepartmentController(IEntity<Department> _db)
        {
            deptdb = _db;
        }
        public IActionResult Index()
        {
            return View(deptdb.GetAll());
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Department dept = deptdb.GetById(id.Value);
            if (dept == null)
            {
                return NotFound();
            }
            return View(dept);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department dept)
        {
            deptdb.Add(dept);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            Department dept = deptdb.GetById(Id.Value);

            if (dept == null)
            {
                return NotFound();
            }

            return View(dept);
        }
        [HttpPost]
        public IActionResult Edit(Department NewDept)
        {
            deptdb.Update(NewDept);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            deptdb.Delete(id.Value);

            return RedirectToAction("Index");
        }
    }
}

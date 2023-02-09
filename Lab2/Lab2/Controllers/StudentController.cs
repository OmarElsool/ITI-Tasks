using Lab2.Models;
using Lab2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class StudentController : Controller
    {
        IEntity<Student> db;
        public StudentController(IEntity<Student> _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View(db.GetAll());
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Student std = db.GetById(id.Value);
            if (std == null)
            {
                return NotFound();
            }
            return View(std);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student std, IFormFile img)
        {
            if (!ModelState.IsValid)
            {
                return View(std);
            }
            if (img == null)
            {
                ModelState.AddModelError("", "Enter Img Plz");
            }
            var extention = img.FileName.Split(".").Last();
            var fileName = std.Id + "." + extention;
            std.StdImg = fileName;
            using (var fs = System.IO.File.Create("wwwroot/Images/" + fileName))
            {
                img.CopyTo(fs);
            }
            db.Add(std);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            Student student = db.GetById(Id.Value);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
        [HttpPost]
        public IActionResult Edit(Student newStd)
        {
            db.Update(newStd);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Student std = db.GetById(id.Value);
            return View(std);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            db.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Download(int id)
        {
            Student std = db.GetById(id);
            return File("~/Images/" + std.StdImg, "image/jpeg", std.Name + ".jpg");
        }
        public IActionResult checking(string username, int? Id)
        {
            if (Id == null)
            {
                Student std = db.GetAll().FirstOrDefault(s => s.Username == username);
                if (std == null)
                {
                    return Json(true);
                }
                else
                {
                    return Json(false);
                }
            }
            else
            {
                Student std = db.GetAll().FirstOrDefault(s => s.Username == username && s.Id != Id);
                if (std == null)
                {
                    return Json(true);
                }
                return Json(false);
            }
        }
    }
}

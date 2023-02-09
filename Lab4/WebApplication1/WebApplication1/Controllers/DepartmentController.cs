using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly AppDbContext _context;

        public DepartmentController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult UpdateCourse(int id)
        {
            var dept = _context.Departments.Include(c => c.Courses).FirstOrDefault(d => d.DeptId == id);
            var Allcourse = _context.Course.ToList();
            var coursesInDept = dept.Courses.ToList();
            var coursesNotInDept = Allcourse.Except(coursesInDept);

            ViewBag.CourseInDept = new SelectList(coursesInDept, "CrsId", "Name");
            ViewBag.CourseNotInDept = new SelectList(coursesNotInDept, "CrsId", "Name");

            return View(dept);
        }
        [HttpPost]
        public IActionResult UpdateCourse(int id, int[] courseToRemove, int[] courseToAdd)
        {
            var dept = _context.Departments.Include(d => d.Courses).FirstOrDefault(d => d.DeptId == id);
            foreach (var courseId in courseToAdd)
            {
                var course = _context.Course.FirstOrDefault(c => c.CrsId == courseId);
                dept.Courses.Add(course);
            }
            foreach (var courseId in courseToRemove)
            {
                var course = _context.Course.FirstOrDefault(c => c.CrsId == courseId);
                dept.Courses.Remove(course);
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        //public IActionResult show()
        //{
        //    //eager loading
        //    var department = _context.Departments.Include(s => s.Students).FirstOrDefault(d => d.DeptId == 1);

        //    ////lazy loading
        //    //var dept = _context.Departments.FirstOrDefault(d => d.DeptId == 2);
        //    //var FirstStd = dept.Students.FirstOrDefault().Id;

        //    ////explicit loading
        //    //_context.Entry(dept).Reference(d => d.Courses).Load();

        //    return Content($"Department Name:{department.Name} | First Student: {department.Students.FirstOrDefault().Name}");
        //}
        // GET: Department
        public async Task<IActionResult> Index()
        {
            return View(await _context.Departments.ToListAsync());
        }

        // GET: Department/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Departments == null)
            {
                return NotFound();
            }

            var department = await _context.Departments
                .FirstOrDefaultAsync(m => m.DeptId == id);
            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }

        // GET: Department/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Department/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DeptId,Name")] Department department)
        {
            if (ModelState.IsValid)
            {
                _context.Add(department);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(department);
        }

        // GET: Department/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Departments == null)
            {
                return NotFound();
            }

            var department = await _context.Departments.FindAsync(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }

        // POST: Department/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DeptId,Name")] Department department)
        {
            if (id != department.DeptId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(department);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepartmentExists(department.DeptId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(department);
        }

        // GET: Department/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Departments == null)
            {
                return NotFound();
            }

            var department = await _context.Departments
                .FirstOrDefaultAsync(m => m.DeptId == id);
            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }

        // POST: Department/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Departments == null)
            {
                return Problem("Entity set 'AppDbContext.Departments'  is null.");
            }
            var department = await _context.Departments.FindAsync(id);
            if (department != null)
            {
                _context.Departments.Remove(department);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DepartmentExists(int id)
        {
            return _context.Departments.Any(e => e.DeptId == id);
        }
    }
}

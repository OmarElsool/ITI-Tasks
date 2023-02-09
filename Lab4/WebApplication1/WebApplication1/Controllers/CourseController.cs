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
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult ShowStudents(int id)
        {
            var course = _context.Course.Include(c => c.Departments).ThenInclude(d => d.Students).ThenInclude(s => s.StudentCrs).FirstOrDefault(c => c.CrsId == id);
            return View(course);
        }
        [HttpPost]
        public IActionResult ShowStudents(int crsid, Dictionary<int, int> std)
        {
            foreach (var Student in std)
            {
                if (Student.Value > -1)
                {
                    var sc = _context.StudentCourse.FirstOrDefault(sc => sc.CrsId == crsid && sc.StdId == Student.Key);
                    if (sc == null)
                    {
                        _context.StudentCourse.Add(new StudentCourse() { StdId = Student.Key, CrsId = crsid, Degree = Student.Value });
                    }
                    else
                    {
                        sc.Degree = Student.Value;
                    }
                }
            }
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        //public IActionResult addCrsDept()
        //{

        //}
        //[HttpPost]
        //public IActionResult addCrsDept(Course Course, Department Department)
        //{

        //}

        // GET: Course
        public async Task<IActionResult> Index()
        {
            return View(await _context.Course.ToListAsync());
        }

        // GET: Course/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Course == null)
            {
                return NotFound();
            }

            var course = await _context.Course
                .FirstOrDefaultAsync(m => m.CrsId == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: Course/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CrsId,Name")] Course course)
        {
            if (ModelState.IsValid)
            {
                //var crs = course.Departments.FirstOrDefault();
                //var crs = _context.Course.FirstOrDefault(m => m.CrsId == course.CrsId);
                //var dept = course.Departments.FirstOrDefault(d => d.DeptId == ViewBag.Department.DeptId);
                //crs.Departments.Add(dept);

                _context.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //SelectList DepartmentsList = new SelectList(_context.Departments.ToList(), "DeptId", "Name");
            //ViewBag.Department = DepartmentsList;
            return View(course);
        }

        // GET: Course/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Course == null)
            {
                return NotFound();
            }

            var course = await _context.Course.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }

        // POST: Course/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CrsId,Name")] Course course)
        {
            if (id != course.CrsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(course);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(course.CrsId))
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
            return View(course);
        }

        // GET: Course/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Course == null)
            {
                return NotFound();
            }

            var course = await _context.Course
                .FirstOrDefaultAsync(m => m.CrsId == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Course == null)
            {
                return Problem("Entity set 'AppDbContext.Course'  is null.");
            }
            var course = await _context.Course.FindAsync(id);
            if (course != null)
            {
                _context.Course.Remove(course);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseExists(int id)
        {
            return _context.Course.Any(e => e.CrsId == id);
        }
    }
}

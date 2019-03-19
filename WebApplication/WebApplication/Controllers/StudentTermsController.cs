using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class StudentTermsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentTermsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: StudentTerms

        /* public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Terms.Include(s => s.Student);
            return View(await applicationDbContext.ToListAsync());
        }*/

        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.TermAbbrSortParm = String.IsNullOrEmpty(sortOrder) ? "termabbr_name_desc" : "";
            ViewBag.TermNumberSortParm = String.IsNullOrEmpty(sortOrder) ? "term_number_desc" : "";
            ViewBag.StuidSortParm = String.IsNullOrEmpty(sortOrder) ? "stuid_desc" : "";

            var students = from s in _context.Terms select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.TermName.ToString().Contains(searchString)
                                       || s.TermAbbr.ToString().Contains(searchString)
                                       || s.StudentId.ToString().Contains(searchString)
                                       || s.Term.ToString().Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    students = students.OrderByDescending(s => s.TermName);
                    break;
                case "termabbr_name_desc":
                    students = students.OrderByDescending(s => s.TermAbbr);
                    break;
                case "termabbr_name":
                    students = students.OrderBy(s => s.TermAbbr);
                    break;
                case "stuid_desc":
                    students = students.OrderByDescending(s => s.StudentId);
                    break;
                case "stuid":
                    students = students.OrderBy(s => s.StudentId);
                    break;
                case "term_number_desc":
                    students = students.OrderByDescending(s => s.Term);
                    break;
                case "term_number":
                    students = students.OrderBy(s => s.Term);
                    break;
                default:
                    students = students.OrderBy(s => s.TermName);
                    break;
            }
            return View(await students.AsNoTracking().ToListAsync());
        }

        // GET: StudentTerms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentTerm = await _context.Terms
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.StudentTermId == id);
            if (studentTerm == null)
            {
                return NotFound();
            }

            return View(studentTerm);
        }

        // GET: StudentTerms/Create
        public IActionResult Create()
        {
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "StudentId");
            return View();
        }

        // POST: StudentTerms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentTermId,StudentId,Term,TermAbbr,TermName")] StudentTerm studentTerm)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentTerm);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "StudentId", studentTerm.StudentId);
            return View(studentTerm);
        }

        // GET: StudentTerms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentTerm = await _context.Terms.FindAsync(id);
            if (studentTerm == null)
            {
                return NotFound();
            }
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "StudentId", studentTerm.StudentId);
            return View(studentTerm);
        }

        // POST: StudentTerms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentTermId,StudentId,Term,TermAbbr,TermName")] StudentTerm studentTerm)
        {
            if (id != studentTerm.StudentTermId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentTerm);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentTermExists(studentTerm.StudentTermId))
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
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "StudentId", studentTerm.StudentId);
            return View(studentTerm);
        }

        // GET: StudentTerms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentTerm = await _context.Terms
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.StudentTermId == id);
            if (studentTerm == null)
            {
                return NotFound();
            }

            return View(studentTerm);
        }

        // POST: StudentTerms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentTerm = await _context.Terms.FindAsync(id);
            _context.Terms.Remove(studentTerm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentTermExists(int id)
        {
            return _context.Terms.Any(e => e.StudentTermId == id);
        }
    }
}

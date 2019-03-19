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
    public class SlotsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SlotsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Slots
        /*public async Task<IActionResult> Index()
        {
          var applicationDbContext = _context.Slots.Include(s => s.Credit).Include(s => s.DegreePlan);
        return View(await applicationDbContext.ToListAsync());
        }*/

        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.NumberSortParm = String.IsNullOrEmpty(sortOrder) ? "number_desc" : "";
            ViewBag.TermNumberSortParm = String.IsNullOrEmpty(sortOrder) ? "term_number_desc" : "";
            ViewBag.DegplanNumberSortParm = String.IsNullOrEmpty(sortOrder) ? "degplan_number_desc" : "";
            var students = from s in _context.Slots
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.Credit.ToString().Contains(searchString)
                                       || s.Term.ToString().Contains(searchString)
                                       || s.Status.ToString().Contains(searchString)
                                       || s.DegreePlan.ToString().Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    students = students.OrderByDescending(s => s.Status);
                    break;
                case "number_desc":
                    students = students.OrderByDescending(s => s.CreditId);
                    break;
                case "number":
                    students = students.OrderBy(s => s.CreditId);
                    break;
                case "term_number_desc":
                    students = students.OrderByDescending(s => s.Term);
                    break;
                case "term_number":
                    students = students.OrderBy(s => s.Term);
                    break;
                case "degplan_number_desc":
                    students = students.OrderByDescending(s => s.DegreePlan);
                    break;
                case "degplan_number":
                    students = students.OrderBy(s => s.DegreePlan);
                    break;
                default:
                    students = students.OrderBy(s => s.Status);
                    break;
            }
            return View(await students.AsNoTracking().ToListAsync());
        }

        // GET: Slots/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slot = await _context.Slots
                .Include(s => s.Credit)
                .Include(s => s.DegreePlan)
                .FirstOrDefaultAsync(m => m.SlotId == id);
            if (slot == null)
            {
                return NotFound();
            }

            return View(slot);
        }

        // GET: Slots/Create
        public IActionResult Create()
        {
            ViewData["CreditId"] = new SelectList(_context.Credits, "CreditId", "CreditId");
            ViewData["DegreePlanId"] = new SelectList(_context.DegreePlans, "DegreePlanId", "DegreePlanId");
            return View();
        }

        // POST: Slots/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SlotId,DegreePlanId,Term,CreditId,Status")] Slot slot)
        {
            if (ModelState.IsValid)
            {
                _context.Add(slot);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CreditId"] = new SelectList(_context.Credits, "CreditId", "CreditId", slot.CreditId);
            ViewData["DegreePlanId"] = new SelectList(_context.DegreePlans, "DegreePlanId", "DegreePlanId", slot.DegreePlanId);
            return View(slot);
        }

        // GET: Slots/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slot = await _context.Slots.FindAsync(id);
            if (slot == null)
            {
                return NotFound();
            }
            ViewData["CreditId"] = new SelectList(_context.Credits, "CreditId", "CreditId", slot.CreditId);
            ViewData["DegreePlanId"] = new SelectList(_context.DegreePlans, "DegreePlanId", "DegreePlanId", slot.DegreePlanId);
            return View(slot);
        }

        // POST: Slots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SlotId,DegreePlanId,Term,CreditId,Status")] Slot slot)
        {
            if (id != slot.SlotId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(slot);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SlotExists(slot.SlotId))
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
            ViewData["CreditId"] = new SelectList(_context.Credits, "CreditId", "CreditId", slot.CreditId);
            ViewData["DegreePlanId"] = new SelectList(_context.DegreePlans, "DegreePlanId", "DegreePlanId", slot.DegreePlanId);
            return View(slot);
        }

        // GET: Slots/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slot = await _context.Slots
                .Include(s => s.Credit)
                .Include(s => s.DegreePlan)
                .FirstOrDefaultAsync(m => m.SlotId == id);
            if (slot == null)
            {
                return NotFound();
            }

            return View(slot);
        }

        // POST: Slots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var slot = await _context.Slots.FindAsync(id);
            _context.Slots.Remove(slot);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SlotExists(int id)
        {
            return _context.Slots.Any(e => e.SlotId == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenHuongGiang800.Models;

namespace NguyenHuongGiang800.Controllers
{
    public class CompanyNHG800Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public CompanyNHG800Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CompanyNHG800
        public async Task<IActionResult> Index()
        {
              return _context.CompanyNHG800 != null ? 
                          View(await _context.CompanyNHG800.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.CompanyNHG800'  is null.");
        }

        // GET: CompanyNHG800/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.CompanyNHG800 == null)
            {
                return NotFound();
            }

            var companyNHG800 = await _context.CompanyNHG800
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyNHG800 == null)
            {
                return NotFound();
            }

            return View(companyNHG800);
        }

        // GET: CompanyNHG800/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanyNHG800/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName")] CompanyNHG800 companyNHG800)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyNHG800);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyNHG800);
        }

        // GET: CompanyNHG800/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.CompanyNHG800 == null)
            {
                return NotFound();
            }

            var companyNHG800 = await _context.CompanyNHG800.FindAsync(id);
            if (companyNHG800 == null)
            {
                return NotFound();
            }
            return View(companyNHG800);
        }

        // POST: CompanyNHG800/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyId,CompanyName")] CompanyNHG800 companyNHG800)
        {
            if (id != companyNHG800.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyNHG800);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyNHG800Exists(companyNHG800.CompanyId))
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
            return View(companyNHG800);
        }

        // GET: CompanyNHG800/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.CompanyNHG800 == null)
            {
                return NotFound();
            }

            var companyNHG800 = await _context.CompanyNHG800
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyNHG800 == null)
            {
                return NotFound();
            }

            return View(companyNHG800);
        }

        // POST: CompanyNHG800/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.CompanyNHG800 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CompanyNHG800'  is null.");
            }
            var companyNHG800 = await _context.CompanyNHG800.FindAsync(id);
            if (companyNHG800 != null)
            {
                _context.CompanyNHG800.Remove(companyNHG800);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyNHG800Exists(string id)
        {
          return (_context.CompanyNHG800?.Any(e => e.CompanyId == id)).GetValueOrDefault();
        }
    }
}

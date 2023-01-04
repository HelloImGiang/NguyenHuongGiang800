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
    public class NHG0800Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public NHG0800Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NHG0800
        public async Task<IActionResult> Index()
        {
              return _context.NHG0800 != null ? 
                          View(await _context.NHG0800.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.NHG0800'  is null.");
        }

        // GET: NHG0800/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.NHG0800 == null)
            {
                return NotFound();
            }

            var nHG0800 = await _context.NHG0800
                .FirstOrDefaultAsync(m => m.NHGId == id);
            if (nHG0800 == null)
            {
                return NotFound();
            }

            return View(nHG0800);
        }

        // GET: NHG0800/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NHG0800/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NHGId,NHGName,NHGGender")] NHG0800 nHG0800)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nHG0800);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nHG0800);
        }

        // GET: NHG0800/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.NHG0800 == null)
            {
                return NotFound();
            }

            var nHG0800 = await _context.NHG0800.FindAsync(id);
            if (nHG0800 == null)
            {
                return NotFound();
            }
            return View(nHG0800);
        }

        // POST: NHG0800/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NHGId,NHGName,NHGGender")] NHG0800 nHG0800)
        {
            if (id != nHG0800.NHGId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nHG0800);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NHG0800Exists(nHG0800.NHGId))
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
            return View(nHG0800);
        }

        // GET: NHG0800/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.NHG0800 == null)
            {
                return NotFound();
            }

            var nHG0800 = await _context.NHG0800
                .FirstOrDefaultAsync(m => m.NHGId == id);
            if (nHG0800 == null)
            {
                return NotFound();
            }

            return View(nHG0800);
        }

        // POST: NHG0800/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.NHG0800 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.NHG0800'  is null.");
            }
            var nHG0800 = await _context.NHG0800.FindAsync(id);
            if (nHG0800 != null)
            {
                _context.NHG0800.Remove(nHG0800);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NHG0800Exists(string id)
        {
          return (_context.NHG0800?.Any(e => e.NHGId == id)).GetValueOrDefault();
        }
    }
}

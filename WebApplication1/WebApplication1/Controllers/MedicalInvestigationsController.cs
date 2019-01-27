using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MedicalInvestigationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MedicalInvestigationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MedicalInvestigations
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.MedicalInvestigations.ToListAsync());
        }

        // GET: MedicalInvestigations/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicalInvestigations = await _context.MedicalInvestigations
                .FirstOrDefaultAsync(m => m.IdInvestigation == id);
            if (medicalInvestigations == null)
            {
                return NotFound();
            }

            return View(medicalInvestigations);
        }

        // GET: MedicalInvestigations/Create

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: MedicalInvestigations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdInvestigation,InvName,InvDescription,InvPret")] MedicalInvestigations medicalInvestigations)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medicalInvestigations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medicalInvestigations);
        }

        // GET: MedicalInvestigations/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicalInvestigations = await _context.MedicalInvestigations.FindAsync(id);
            if (medicalInvestigations == null)
            {
                return NotFound();
            }
            return View(medicalInvestigations);
        }

        // POST: MedicalInvestigations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdInvestigation,InvName,InvDescription,InvPret")] MedicalInvestigations medicalInvestigations)
        {
            if (id != medicalInvestigations.IdInvestigation)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medicalInvestigations);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicalInvestigationsExists(medicalInvestigations.IdInvestigation))
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
            return View(medicalInvestigations);
        }

        [Authorize(Roles = "Admin")]
        // GET: MedicalInvestigations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicalInvestigations = await _context.MedicalInvestigations
                .FirstOrDefaultAsync(m => m.IdInvestigation == id);
            if (medicalInvestigations == null)
            {
                return NotFound();
            }

            return View(medicalInvestigations);
        }

        // POST: MedicalInvestigations/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medicalInvestigations = await _context.MedicalInvestigations.FindAsync(id);
            _context.MedicalInvestigations.Remove(medicalInvestigations);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicalInvestigationsExists(int id)
        {
            return _context.MedicalInvestigations.Any(e => e.IdInvestigation == id);
        }
    }
}

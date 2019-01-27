using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DaySchedulesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DaySchedulesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DaySchedules
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DaySchedule.Include(d => d.IdDayNavigation).Include(d => d.IdDoctorNavigation).Include(d => d.IdHourNavigation);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: DaySchedules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var daySchedule = await _context.DaySchedule
                .Include(d => d.IdDayNavigation)
                .Include(d => d.IdDoctorNavigation)
                .Include(d => d.IdHourNavigation)
                .FirstOrDefaultAsync(m => m.IdSchedule == id);
            if (daySchedule == null)
            {
                return NotFound();
            }

            return View(daySchedule);
        }

        // GET: DaySchedules/Create
        public IActionResult Create()
        {
            ViewData["IdDay"] = new SelectList(_context.Set<WorkingDays>(), "IdDay", "IdDay");
            ViewData["IdDoctor"] = new SelectList(_context.Doctors, "IdDoctor", "IdDoctor");
            ViewData["IdHour"] = new SelectList(_context.Set<AvailableHours>(), "IdHour", "IdHour");
            return View();
        }

        // POST: DaySchedules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSchedule,IdDoctor,IdDay,IdHour")] DaySchedule daySchedule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(daySchedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdDay"] = new SelectList(_context.Set<WorkingDays>(), "IdDay", "IdDay", daySchedule.IdDay);
            ViewData["IdDoctor"] = new SelectList(_context.Doctors, "IdDoctor", "IdDoctor", daySchedule.IdDoctor);
            ViewData["IdHour"] = new SelectList(_context.Set<AvailableHours>(), "IdHour", "IdHour", daySchedule.IdHour);
            return View(daySchedule);
        }

        // GET: DaySchedules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var daySchedule = await _context.DaySchedule.FindAsync(id);
            if (daySchedule == null)
            {
                return NotFound();
            }
            ViewData["IdDay"] = new SelectList(_context.Set<WorkingDays>(), "IdDay", "IdDay", daySchedule.IdDay);
            ViewData["IdDoctor"] = new SelectList(_context.Doctors, "IdDoctor", "IdDoctor", daySchedule.IdDoctor);
            ViewData["IdHour"] = new SelectList(_context.Set<AvailableHours>(), "IdHour", "IdHour", daySchedule.IdHour);
            return View(daySchedule);
        }

        // POST: DaySchedules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdSchedule,IdDoctor,IdDay,IdHour")] DaySchedule daySchedule)
        {
            if (id != daySchedule.IdSchedule)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(daySchedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DayScheduleExists(daySchedule.IdSchedule))
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
            ViewData["IdDay"] = new SelectList(_context.Set<WorkingDays>(), "IdDay", "IdDay", daySchedule.IdDay);
            ViewData["IdDoctor"] = new SelectList(_context.Doctors, "IdDoctor", "IdDoctor", daySchedule.IdDoctor);
            ViewData["IdHour"] = new SelectList(_context.Set<AvailableHours>(), "IdHour", "IdHour", daySchedule.IdHour);
            return View(daySchedule);
        }

        // GET: DaySchedules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var daySchedule = await _context.DaySchedule
                .Include(d => d.IdDayNavigation)
                .Include(d => d.IdDoctorNavigation)
                .Include(d => d.IdHourNavigation)
                .FirstOrDefaultAsync(m => m.IdSchedule == id);
            if (daySchedule == null)
            {
                return NotFound();
            }

            return View(daySchedule);
        }

        // POST: DaySchedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var daySchedule = await _context.DaySchedule.FindAsync(id);
            _context.DaySchedule.Remove(daySchedule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DayScheduleExists(int id)
        {
            return _context.DaySchedule.Any(e => e.IdSchedule == id);
        }
    }
}

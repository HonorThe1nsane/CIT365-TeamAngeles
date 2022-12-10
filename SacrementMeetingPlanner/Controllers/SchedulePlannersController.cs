using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Controllers
{
    public class SchedulePlannersController : Controller
    {
        private readonly SacramentMeetingPlannerContext _context;

        public SchedulePlannersController(SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        // GET: SchedulePlanners
        public async Task<IActionResult> Index()
        {
              return View(await _context.SchedulePlanner.ToListAsync());
        }

        // GET: SchedulePlanners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SchedulePlanner == null)
            {
                return NotFound();
            }

            var schedulePlanner = await _context.SchedulePlanner
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schedulePlanner == null)
            {
                return NotFound();
            }

            return View(schedulePlanner);
        }

        // GET: SchedulePlanners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SchedulePlanners/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ConductingLeader,OpeningSong,SacramentHymn,SacramentHymnTitle,IntermediateNumber,IntermediateNumberTitle,OpeningPrayer,ClosingHymn,ClosingHymnTitle,ClosingPrayer,NumberOfSpeakers,SpeakerSubjects")] SchedulePlanner schedulePlanner)
        {
            if (ModelState.IsValid)
            {
                _context.Add(schedulePlanner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(schedulePlanner);
        }

        // GET: SchedulePlanners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SchedulePlanner == null)
            {
                return NotFound();
            }

            var schedulePlanner = await _context.SchedulePlanner.FindAsync(id);
            if (schedulePlanner == null)
            {
                return NotFound();
            }
            return View(schedulePlanner);
        }

        // POST: SchedulePlanners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ConductingLeader,OpeningSong,SacramentHymn,SacramentHymnTitle,IntermediateNumber,IntermediateNumberTitle,OpeningPrayer,ClosingHymn,ClosingHymnTitle,ClosingPrayer,NumberOfSpeakers,SpeakerSubjects")] SchedulePlanner schedulePlanner)
        {
            if (id != schedulePlanner.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(schedulePlanner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SchedulePlannerExists(schedulePlanner.Id))
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
            return View(schedulePlanner);
        }

        // GET: SchedulePlanners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SchedulePlanner == null)
            {
                return NotFound();
            }

            var schedulePlanner = await _context.SchedulePlanner
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schedulePlanner == null)
            {
                return NotFound();
            }

            return View(schedulePlanner);
        }

        // POST: SchedulePlanners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SchedulePlanner == null)
            {
                return Problem("Entity set 'SacramentMeetingPlannerContext.SchedulePlanner'  is null.");
            }
            var schedulePlanner = await _context.SchedulePlanner.FindAsync(id);
            if (schedulePlanner != null)
            {
                _context.SchedulePlanner.Remove(schedulePlanner);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SchedulePlannerExists(int id)
        {
          return _context.SchedulePlanner.Any(e => e.Id == id);
        }
    }
}

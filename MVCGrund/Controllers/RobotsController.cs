using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCGrund.Data;
using MVCGrund.Models;

namespace MVCGrund.Controllers
{
    public class RobotsController : Controller
    {
        private readonly MVCGrundContext _context;

        public RobotsController(MVCGrundContext context)
        {
            _context = context;
        }

        // GET: Robots
        public async Task<IActionResult> Index()
        {
              return _context.Robot != null ? 
                          View(await _context.Robot.ToListAsync()) :
                          Problem("Entity set 'MVCGrundContext.Robot'  is null.");
        }

        // GET: Robots/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Robot == null)
            {
                return NotFound();
            }

            var robot = await _context.Robot
                .FirstOrDefaultAsync(m => m.Id == id);
            if (robot == null)
            {
                return NotFound();
            }

            return View(robot);
        }

        // GET: Robots/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Robots/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Model,RAM")] Robot robot)
        {
            if (ModelState.IsValid)
            {
                _context.Add(robot);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(robot);
        }

        // GET: Robots/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Robot == null)
            {
                return NotFound();
            }

            var robot = await _context.Robot.FindAsync(id);
            if (robot == null)
            {
                return NotFound();
            }
            return View(robot);
        }

        // POST: Robots/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Model,RAM")] Robot robot)
        {
            if (id != robot.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(robot);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RobotExists(robot.Id))
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
            return View(robot);
        }

        // GET: Robots/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Robot == null)
            {
                return NotFound();
            }

            var robot = await _context.Robot
                .FirstOrDefaultAsync(m => m.Id == id);
            if (robot == null)
            {
                return NotFound();
            }

            return View(robot);
        }

        // POST: Robots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Robot == null)
            {
                return Problem("Entity set 'MVCGrundContext.Robot'  is null.");
            }
            var robot = await _context.Robot.FindAsync(id);
            if (robot != null)
            {
                _context.Robot.Remove(robot);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RobotExists(int id)
        {
          return (_context.Robot?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

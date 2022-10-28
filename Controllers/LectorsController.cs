using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoIntegrador.Data;
using ProyectoIntegrador.Models;

namespace ProyectoIntegrador.Areas.Empleado.controllers
{
    [Authorize]
    public class LectorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LectorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Empleado/Lectors
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Lector.Include(l => l.Institucion);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Empleado/Lectors/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lector = await _context.Lector
                .Include(l => l.Institucion)
                .FirstOrDefaultAsync(m => m.LectorID == id);
            if (lector == null)
            {
                return NotFound();
            }

            return View(lector);
        }

        // GET: Empleado/Lectors/Create
        public IActionResult Create()
        {
            ViewData["InstitucionID"] = new SelectList(_context.Instituciones, "InstitucionID", "NombreInstitucion");
            return View();
        }

        // POST: Empleado/Lectors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LectorID,PrimerNombre,PrimerApellido,Telefono,Correo,DirectorioFoto,InstitucionID")] Lector lector)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lector);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InstitucionID"] = new SelectList(_context.Instituciones, "InstitucionID", "NombreInstitucion", lector.InstitucionID);
            return View(lector);
        }

        // GET: Empleado/Lectors/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lector = await _context.Lector.FindAsync(id);
            if (lector == null)
            {
                return NotFound();
            }
            ViewData["InstitucionID"] = new SelectList(_context.Instituciones, "InstitucionID", "NombreInstitucion", lector.InstitucionID);
            return View(lector);
        }

        // POST: Empleado/Lectors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("LectorID,PrimerNombre,PrimerApellido,Telefono,Correo,DirectorioFoto,InstitucionID")] Lector lector)
        {
            if (id != lector.LectorID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lector);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LectorExists(lector.LectorID))
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
            ViewData["InstitucionID"] = new SelectList(_context.Instituciones, "InstitucionID", "NombreInstitucion", lector.InstitucionID);
            return View(lector);
        }

        // GET: Empleado/Lectors/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lector = await _context.Lector
                .Include(l => l.Institucion)
                .FirstOrDefaultAsync(m => m.LectorID == id);
            if (lector == null)
            {
                return NotFound();
            }

            return View(lector);
        }

        // POST: Empleado/Lectors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var lector = await _context.Lector.FindAsync(id);
            _context.Lector.Remove(lector);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LectorExists(string id)
        {
            return _context.Lector.Any(e => e.LectorID == id);
        }
    }
}

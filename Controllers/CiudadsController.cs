using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoIntegrador.Data;
using ProyectoIntegrador.Models;

namespace ProyectoIntegrador.Areas.Empleado.controllers
{
    
    public class CiudadsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CiudadsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Empleado/Ciudads
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Ciudades.Include(c => c.pais);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Empleado/Ciudads/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciudad = await _context.Ciudades
                .Include(c => c.pais)
                .FirstOrDefaultAsync(m => m.CiudadID == id);
            if (ciudad == null)
            {
                return NotFound();
            }

            return View(ciudad);
        }

        // GET: Empleado/Ciudads/Create
        public IActionResult Create()
        {
            ViewData["PaisID"] = new SelectList(_context.Paises, "PaisID", "NombrePais");
            return View();
        }

        // POST: Empleado/Ciudads/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CiudadID,NombreCiudad,PaisID")] Ciudad ciudad)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ciudad);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PaisID"] = new SelectList(_context.Paises, "PaisID", "NombrePais", ciudad.PaisID);
            return View(ciudad);
        }

        // GET: Empleado/Ciudads/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciudad = await _context.Ciudades.FindAsync(id);
            if (ciudad == null)
            {
                return NotFound();
            }
            ViewData["PaisID"] = new SelectList(_context.Paises, "PaisID", "NombrePais", ciudad.PaisID);
            return View(ciudad);
        }

        // POST: Empleado/Ciudads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CiudadID,NombreCiudad,PaisID")] Ciudad ciudad)
        {
            if (id != ciudad.CiudadID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ciudad);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CiudadExists(ciudad.CiudadID))
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
            ViewData["PaisID"] = new SelectList(_context.Paises, "PaisID", "NombrePais", ciudad.PaisID);
            return View(ciudad);
        }

        // GET: Empleado/Ciudads/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciudad = await _context.Ciudades
                .Include(c => c.pais)
                .FirstOrDefaultAsync(m => m.CiudadID == id);
            if (ciudad == null)
            {
                return NotFound();
            }

            return View(ciudad);
        }

        // POST: Empleado/Ciudads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ciudad = await _context.Ciudades.FindAsync(id);
            _context.Ciudades.Remove(ciudad);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CiudadExists(int id)
        {
            return _context.Ciudades.Any(e => e.CiudadID == id);
        }
    }
}

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
    public class EjemplarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EjemplarsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Empleado/Ejemplars
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Ejemplares.Include(e => e.titulo);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Empleado/Ejemplars/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ejemplar = await _context.Ejemplares
                .Include(e => e.titulo)
                .FirstOrDefaultAsync(m => m.EjemplarID == id);
            if (ejemplar == null)
            {
                return NotFound();
            }

            return View(ejemplar);
        }

        // GET: Empleado/Ejemplars/Create
        public IActionResult Create()
        {
            ViewData["TituloID"] = new SelectList(_context.Titulos, "TituloID", "Descripcion");
            return View();
        }

        // POST: Empleado/Ejemplars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EjemplarID,EstadoBibliografico,Disponibilidad,TituloID")] Ejemplar ejemplar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ejemplar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TituloID"] = new SelectList(_context.Titulos, "TituloID", "Descripcion", ejemplar.TituloID);
            return View(ejemplar);
        }

        // GET: Empleado/Ejemplars/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ejemplar = await _context.Ejemplares.FindAsync(id);
            if (ejemplar == null)
            {
                return NotFound();
            }
            ViewData["TituloID"] = new SelectList(_context.Titulos, "TituloID", "Descripcion", ejemplar.TituloID);
            return View(ejemplar);
        }

        // POST: Empleado/Ejemplars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("EjemplarID,EstadoBibliografico,Disponibilidad,TituloID")] Ejemplar ejemplar)
        {
            if (id != ejemplar.EjemplarID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ejemplar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EjemplarExists(ejemplar.EjemplarID))
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
            ViewData["TituloID"] = new SelectList(_context.Titulos, "TituloID", "Descripcion", ejemplar.TituloID);
            return View(ejemplar);
        }

        // GET: Empleado/Ejemplars/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ejemplar = await _context.Ejemplares
                .Include(e => e.titulo)
                .FirstOrDefaultAsync(m => m.EjemplarID == id);
            if (ejemplar == null)
            {
                return NotFound();
            }

            return View(ejemplar);
        }

        // POST: Empleado/Ejemplars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var ejemplar = await _context.Ejemplares.FindAsync(id);
            _context.Ejemplares.Remove(ejemplar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EjemplarExists(string id)
        {
            return _context.Ejemplares.Any(e => e.EjemplarID == id);
        }
    }
}

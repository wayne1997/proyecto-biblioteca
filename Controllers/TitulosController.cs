using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoIntegrador.Data;
using ProyectoIntegrador.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace ProyectoIntegrador.Areas.Empleado.controllers
{
    [Authorize]
    public class TitulosController : Controller
    {
        private readonly ApplicationDbContext _context;
        public readonly IHostingEnvironment hostingEnviroment;
        string DirectorioPortada;
        public TitulosController(ApplicationDbContext context, IHostingEnvironment enviroment)
        {
            _context = context;
            hostingEnviroment = enviroment;
        }

        // GET: Empleado/Titulos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Titulos.Include(t => t.Area).Include(t => t.Ciudad).Include(t => t.Pais);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Empleado/Titulos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var titulo = await _context.Titulos
                .Include(t => t.Area)
                .Include(t => t.Ciudad)
                .Include(t => t.Pais)
                .FirstOrDefaultAsync(m => m.TituloID == id);
            if (titulo == null)
            {
                return NotFound();
            }

            return View(titulo);
        }

        // GET: Empleado/Titulos/Create
        public IActionResult Create()
        {
              
            ViewData["AreaID"] = new SelectList(_context.Areas, "AreaID", "NombreArea");
            ViewData["CiudadID"] = new SelectList(_context.Ciudades, "CiudadID", "NombreCiudad");
            ViewData["PaisID"] = new SelectList(_context.Paises, "PaisID", "NombrePais");
            return View();
        }

        // POST: Empleado/Titulos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TituloID,Nombre,ISBN,Edicion,Fecha_lanzamiento,Cantidad,Descripcion,UrlReview,PaisID,CiudadID,AreaID")] Titulo titulo, IFormFile portadaLibro)
        {
            if (portadaLibro != null)
            {
                var portada = Path.Combine(hostingEnviroment.WebRootPath, Path.GetFileName(portadaLibro.FileName));
                portadaLibro.CopyTo(new FileStream(portada, FileMode.Create));
                DirectorioPortada = "/" + Path.GetFileName(portadaLibro.FileName);
                titulo.DirectorioPortada = DirectorioPortada;
            }
          

            if (ModelState.IsValid)
            {
                _context.Add(titulo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AreaID"] = new SelectList(_context.Areas, "AreaID", "NombreArea", titulo.AreaID);
            ViewData["CiudadID"] = new SelectList(_context.Ciudades, "CiudadID", "NombreCiudad", titulo.CiudadID);
            ViewData["PaisID"] = new SelectList(_context.Paises, "PaisID", "NombrePais", titulo.PaisID);
            return View(titulo);
        }

        // GET: Empleado/Titulos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var titulo = await _context.Titulos.FindAsync(id);
            if (titulo == null)
            {
                return NotFound();
            }
            ViewData["AreaID"] = new SelectList(_context.Areas, "AreaID", "NombreArea", titulo.AreaID);
            ViewData["CiudadID"] = new SelectList(_context.Ciudades, "CiudadID", "NombreCiudad", titulo.CiudadID);
            ViewData["PaisID"] = new SelectList(_context.Paises, "PaisID", "NombrePais", titulo.PaisID);
            return View(titulo);
        }

        // POST: Empleado/Titulos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TituloID,Nombre,ISBN,Edicion,Fecha_lanzamiento,Cantidad,Descripcion,DirectorioPortada,UrlReview,PaisID,CiudadID,AreaID")] Titulo titulo)
        {
            if (id != titulo.TituloID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(titulo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TituloExists(titulo.TituloID))
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
            ViewData["AreaID"] = new SelectList(_context.Areas, "AreaID", "NombreArea", titulo.AreaID);
            ViewData["CiudadID"] = new SelectList(_context.Ciudades, "CiudadID", "NombreCiudad", titulo.CiudadID);
            ViewData["PaisID"] = new SelectList(_context.Paises, "PaisID", "NombrePais", titulo.PaisID);
            return View(titulo);
        }

        // GET: Empleado/Titulos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var titulo = await _context.Titulos
                .Include(t => t.Area)
                .Include(t => t.Ciudad)
                .Include(t => t.Pais)
                .FirstOrDefaultAsync(m => m.TituloID == id);
            if (titulo == null)
            {
                return NotFound();
            }

            return View(titulo);
        }

        // POST: Empleado/Titulos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var titulo = await _context.Titulos.FindAsync(id);
            _context.Titulos.Remove(titulo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TituloExists(int id)
        {
            return _context.Titulos.Any(e => e.TituloID == id);
        }
    }
}

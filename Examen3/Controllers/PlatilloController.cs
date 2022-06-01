using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Examen3.Data;
using Examen3.Models;

namespace Examen3.Controllers
{
    public class PlatilloController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public PlatilloController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Platillo
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Platillo.Include(p => p.Categoria);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Platillo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Platillo == null)
            {
                return NotFound();
            }

            var platillo = await _context.Platillo
                .Include(p => p.Categoria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (platillo == null)
            {
                return NotFound();
            }

            return View(platillo);
        }

        // GET: Platillo/Create
        public IActionResult Create()
        {
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "Id", "Nombre");
            return View();
        }

        // POST: Platillo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,IdCategoria,Precio,UrlImagen")] Platillo platillo)
        {
            if (ModelState.IsValid)
            {
                string rutaPrincipal = _hostEnvironment.WebRootPath;
                var archivos = HttpContext.Request.Form.Files;
                if (archivos.Count() > 0)
                {
                    string nombreArchivo = Guid.NewGuid().ToString();
                    var subidas = Path.Combine(rutaPrincipal, @"pics\platillos\");
                    var extencion = Path.GetExtension(archivos[0].FileName);
                    using (var fileString = new FileStream(Path.Combine(subidas, nombreArchivo + extencion), FileMode.Create))
                    {
                        archivos[0].CopyTo(fileString);
                    }
                    platillo.UrlImagen = @"pics\platillos\" + nombreArchivo + extencion;
                }
                _context.Add(platillo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "Id", "Nombre", platillo.IdCategoria);
            return View(platillo);
        }

        // GET: Platillo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Platillo == null)
            {
                return NotFound();
            }

            var platillo = await _context.Platillo.FindAsync(id);
            if (platillo == null)
            {
                return NotFound();
            }
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "Id", "Nombre", platillo.IdCategoria);
            return View(platillo);
        }

        // POST: Platillo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,IdCategoria,Precio,UrlImagen")] Platillo platillo)
        {
            if (id != platillo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string rutaPrincipal = _hostEnvironment.WebRootPath;
                    var archivos = HttpContext.Request.Form.Files;
                    if (archivos.Count() > 0)
                    {
                        Platillo platilloDb = await _context.Platillo.FindAsync(id);
                        if (platilloDb != null && platilloDb != null)
                        {
                            var rutaImagenActual = Path.Combine(rutaPrincipal, platilloDb.UrlImagen);
                            if (System.IO.File.Exists(rutaImagenActual))
                            {
                                System.IO.File.Delete(rutaImagenActual);
                            }
                            _context.Entry(platilloDb).State = EntityState.Detached;
                        }
                        string nombreArchivo = Guid.NewGuid().ToString();
                        var subidas = Path.Combine(rutaPrincipal, @"pics\platillos\");
                        var extencion = Path.GetExtension(archivos[0].FileName);
                        using (var fileString = new FileStream(Path.Combine(subidas, nombreArchivo + extencion), FileMode.Create))
                        {
                            archivos[0].CopyTo(fileString);
                        }
                        platillo.UrlImagen = @"pics\platillos\" + nombreArchivo + extencion;
                        _context.Entry(platillo).State = EntityState.Modified;
                    }
                    _context.Update(platillo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlatilloExists(platillo.Id))
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
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "Id", "Nombre", platillo.IdCategoria);
            return View(platillo);
        }

        // GET: Platillo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Platillo == null)
            {
                return NotFound();
            }

            var platillo = await _context.Platillo
                .Include(p => p.Categoria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (platillo == null)
            {
                return NotFound();
            }

            return View(platillo);
        }

        // POST: Platillo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Platillo == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Platillo'  is null.");
            }
            var platillo = await _context.Platillo.FindAsync(id);
            if (platillo != null)
            {
                _context.Platillo.Remove(platillo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlatilloExists(int id)
        {
            return (_context.Platillo?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
